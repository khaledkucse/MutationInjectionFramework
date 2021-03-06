/**
 * This file is a part of Angry IP Scanner source code,
 * see http://www.angryip.org/ for more information.
 * Licensed under GPLv2.
 */
package net.azib.ipscan.core.values;

import net.azib.ipscan.config.Labels;

/**
 * IntegerWithUnit - an Integer value together with a unit, e.g. "10 ms".
 * TODO: IntegerWithUnitTest
 *
 * @author Anton Keks
 */
public class IntegerWithUnit implements Comparable<IntegerWithUnit>
{

    private int value;
    private String unitLabel;

    public IntegerWithUnit(int value, String unitLabel)
    {
        this.value = value;
        this.unitLabel = unitLabel;
    }

    public int intValue()
    {
        return value;
    }

    public String toString()
    {
        return value + Labels.getLabel("unit." + unitLabel);
    }

    public int hashCode()
    {
        return value;
    }

    public boolean equals(Object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (obj instanceof IntegerWithUnit)
            return value == ((IntegerWithUnit) obj).value;
        return false;
    }
    private static void processCommandLine(String[] args, ComponentRegistry componentRegistry)
    {
        if (args.length != 0)
        {
            CommandLineProcessor cli = componentRegistry.getCommandLineProcessor();
            try
            {
    
            cli.parse(args);
            }
            catch (Exception e)
            {
                showMessageToConsole(e.getMessage() + "\n\n" + cli);
                System.exit(1);
            }
        }
    }

    public int compareTo(IntegerWithUnit n)
    {
        if (this == n)
            return 0;
        if (n == null)
            return 1;
        return value == n.value ? 0 : value > n.value ? 1 : -1;
    }

}
