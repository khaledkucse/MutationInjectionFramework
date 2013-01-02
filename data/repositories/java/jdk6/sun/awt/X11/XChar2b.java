// This file is an automatically generated file, please do not edit this file, modify the WrapperGenerator.java file instead !

package sun.awt.X11;

import sun.misc.*;

import java.util.logging.*;
public class XChar2b extends XWrapperBase
{
    private Unsafe unsafe = XlibWrapper.unsafe;
    private final boolean should_free_memory;
    public static int getSize()
    {
        return 2;
    }
    public int getDataSize()
    {
        return getSize();
    }

    long pData;

    public long getPData()
    {
        return pData;
    }


    public XChar2b(long addr)
    {
        log.finest("Creating");
        pData=addr;
        should_free_memory = false;
    }


    public XChar2b()
    {
        log.finest("Creating");
        pData = unsafe.allocateMemory(getSize());
        should_free_memory = true;
    }


    public void dispose()
    {
        log.finest("Disposing");
        if (should_free_memory)
        {
            log.finest("freeing memory");
            unsafe.freeMemory(pData);
        }
    }
    public byte get_byte1()
    {
        log.finest("");
        return (Native.getByte(pData+0));
    }
    public void set_byte1(byte v)
    {
        log.finest("");
        Native.putByte(pData+0, v);
    }
    public byte get_byte2()
    {
        log.finest("");
        return (Native.getByte(pData+1));
    }
    public void set_byte2(byte v)
    {
        log.finest("");
        Native.putByte(pData+1, v);
    }


    String getName()
    {
        return "XChar2b";
    }


    String getFieldsAsString()
    {
        String ret="";

        ret += ""+"byte1 = " + get_byte1() +", ";
        ret += ""+"byte2 = " + get_byte2() +", ";
        return ret;
    }


}


