package org.omg.IOP.CodecFactoryPackage;


/**
* org/omg/IOP/CodecFactoryPackage/UnknownEncoding.java .
* Generated by the IDL-to-Java compiler (portable), version "3.2"
* from ../../../../src/share/classes/org/omg/PortableInterceptor/IOP.idl
* Wednesday, October 24, 2012 4:15:35 PM UTC
*/

public final class UnknownEncoding extends org.omg.CORBA.UserException
{

    public UnknownEncoding ()
    {
        super(UnknownEncodingHelper.id());
    } // ctor


    public UnknownEncoding (String $reason)
    {
        super(UnknownEncodingHelper.id() + "  " + $reason);
    } // ctor

} // class UnknownEncoding
