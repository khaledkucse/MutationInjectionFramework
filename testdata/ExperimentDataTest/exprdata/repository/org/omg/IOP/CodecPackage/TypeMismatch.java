package org.omg.IOP.CodecPackage;


/**
* org/omg/IOP/CodecPackage/TypeMismatch.java .
* Generated by the IDL-to-Java compiler (portable), version "3.2"
* from ../../../../src/share/classes/org/omg/PortableInterceptor/IOP.idl
* Friday, April 20, 2012 2:12:47 PM UTC
*/

public final class TypeMismatch extends org.omg.CORBA.UserException
{

    public TypeMismatch ()
    {
        super(TypeMismatchHelper.id());
    } // ctor


    public TypeMismatch (String $reason)
    {
        super(TypeMismatchHelper.id() + "  " + $reason);
    } // ctor

} // class TypeMismatch