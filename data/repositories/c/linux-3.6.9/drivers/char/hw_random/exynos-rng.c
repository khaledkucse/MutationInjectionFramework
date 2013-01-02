/*
 * exynos-rng.c - Random Number Generator driver for the exynos
 *
 * Copyright (C) 2012 Samsung Electronics
 * Jonghwa Lee <jonghwa3.lee@smasung.com>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation;
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 *
 */

#include <linux/hw_random.h>
#include <linux/kernel.h>
#include <linux/module.h>
#include <linux/init.h>
#include <linux/io.h>
#include <linux/platform_device.h>
#include <linux/clk.h>
#include <linux/pm_runtime.h>
#include <linux/err.h>

#define EXYNOS_PRNG_STATUS_OFFSET	0x10
#define EXYNOS_PRNG_SEED_OFFSET		0x140
#define EXYNOS_PRNG_OUT1_OFFSET		0x160
#define SEED_SETTING_DONE		BIT(1)
#define PRNG_START			0x18
#define PRNG_DONE			BIT(5)
#define EXYNOS_AUTOSUSPEND_DELAY	100

struct exynos_rng
{
    struct device *dev;
    struct hwrng rng;
    void __iomem *mem;
    struct clk *clk;
};

static u32 exynos_rng_readl(struct exynos_rng *rng, u32 offset)
{
    return	__raw_readl(rng->mem + offset);
}

static void exynos_rng_writel(struct exynos_rng *rng, u32 val, u32 offset)
{
    __raw_writel(val, rng->mem + offset);
}

static int exynos_init(struct hwrng *rng)
{
    struct exynos_rng *exynos_rng = container_of(rng,
                                    struct exynos_rng, rng);
    int i;
    int ret = 0;

    pm_runtime_get_sync(exynos_rng->dev);

    for (i = 0 ; i < 5 ; i++)
        exynos_rng_writel(exynos_rng, jiffies,
                          EXYNOS_PRNG_SEED_OFFSET + 4*i);

    if (!(exynos_rng_readl(exynos_rng, EXYNOS_PRNG_STATUS_OFFSET)
            & SEED_SETTING_DONE))
        ret = -EIO;

    pm_runtime_put_noidle(exynos_rng->dev);

    return ret;
}

static int exynos_read(struct hwrng *rng, void *buf,
                       size_t max, bool wait)
{
    struct exynos_rng *exynos_rng = container_of(rng,
                                    struct exynos_rng, rng);
    u32 *data = buf;

    pm_runtime_get_sync(exynos_rng->dev);

    exynos_rng_writel(exynos_rng, PRNG_START, 0);

    while (!(exynos_rng_readl(exynos_rng,
                              EXYNOS_PRNG_STATUS_OFFSET) & PRNG_DONE))
        cpu_relax();

    exynos_rng_writel(exynos_rng, PRNG_DONE, EXYNOS_PRNG_STATUS_OFFSET);

    *data = exynos_rng_readl(exynos_rng, EXYNOS_PRNG_OUT1_OFFSET);

    pm_runtime_mark_last_busy(exynos_rng->dev);
    pm_runtime_autosuspend(exynos_rng->dev);

    return 4;
}

static int __devinit exynos_rng_probe(struct platform_device *pdev)
{
    struct exynos_rng *exynos_rng;

    exynos_rng = devm_kzalloc(&pdev->dev, sizeof(struct exynos_rng),
                              GFP_KERNEL);
    if (!exynos_rng)
        return -ENOMEM;

    exynos_rng->dev = &pdev->dev;
    exynos_rng->rng.name = "exynos";
    exynos_rng->rng.init =	exynos_init;
    exynos_rng->rng.read = exynos_read;
    exynos_rng->clk = devm_clk_get(&pdev->dev, "secss");
    if (IS_ERR(exynos_rng->clk))
    {
        dev_err(&pdev->dev, "Couldn't get clock.\n");
        return -ENOENT;
    }

    exynos_rng->mem = devm_request_and_ioremap(&pdev->dev,
                      platform_get_resource(pdev, IORESOURCE_MEM, 0));
    if (!exynos_rng->mem)
        return -EBUSY;

    platform_set_drvdata(pdev, exynos_rng);

    pm_runtime_set_autosuspend_delay(&pdev->dev, EXYNOS_AUTOSUSPEND_DELAY);
    pm_runtime_use_autosuspend(&pdev->dev);
    pm_runtime_enable(&pdev->dev);

    return hwrng_register(&exynos_rng->rng);
}

static int __devexit exynos_rng_remove(struct platform_device *pdev)
{
    struct exynos_rng *exynos_rng = platform_get_drvdata(pdev);

    hwrng_unregister(&exynos_rng->rng);

    return 0;
}

static int exynos_rng_runtime_suspend(struct device *dev)
{
    struct platform_device *pdev = to_platform_device(dev);
    struct exynos_rng *exynos_rng = platform_get_drvdata(pdev);

    clk_disable_unprepare(exynos_rng->clk);

    return 0;
}

static int exynos_rng_runtime_resume(struct device *dev)
{
    struct platform_device *pdev = to_platform_device(dev);
    struct exynos_rng *exynos_rng = platform_get_drvdata(pdev);

    return clk_prepare_enable(exynos_rng->clk);
}


UNIVERSAL_DEV_PM_OPS(exynos_rng_pm_ops, exynos_rng_runtime_suspend,
                     exynos_rng_runtime_resume, NULL);

static struct platform_driver exynos_rng_driver =
{
    .driver		= {
        .name	= "exynos-rng",
        .owner	= THIS_MODULE,
        .pm	= &exynos_rng_pm_ops,
    },
    .probe		= exynos_rng_probe,
    .remove		= __devexit_p(exynos_rng_remove),
};

module_platform_driver(exynos_rng_driver);

MODULE_DESCRIPTION("EXYNOS 4 H/W Random Number Generator driver");
MODULE_AUTHOR("Jonghwa Lee <jonghwa3.lee@samsung.com>");
MODULE_LICENSE("GPL");