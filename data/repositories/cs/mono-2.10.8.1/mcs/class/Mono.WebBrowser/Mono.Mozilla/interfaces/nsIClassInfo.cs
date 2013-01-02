// THIS FILE AUTOMATICALLY GENERATED BY xpidl2cs.pl
// EDITING IS PROBABLY UNWISE
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2007, 2008 Novell, Inc.
//
// Authors:
//	Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Mozilla
{

[Guid ("986c11d0-f340-11d4-9075-0010a4e73d9a")]
[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
[ComImport ()]
internal interface nsIClassInfo
{

    #region nsIClassInfo
    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getInterfaces (
        out UInt32 count,
        out IntPtr array);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getHelperForLanguage (
        UInt32 language,[MarshalAs (UnmanagedType.Interface)]  out IntPtr ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getContractID ( ref IntPtr ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getClassDescription ( ref IntPtr ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getClassID ([MarshalAs (UnmanagedType.LPStruct)]  out Guid ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getImplementationLanguage ( out UInt32 ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getFlags ( out UInt32 ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getClassIDNoAlloc ([MarshalAs (UnmanagedType.LPStruct)]  out Guid ret);

    #endregion
}


internal class nsClassInfo
{
    public static nsIClassInfo GetProxy (Mono.WebBrowser.IWebBrowser control, nsIClassInfo obj)
    {
        object o = Base.GetProxyForObject (control, typeof(nsIClassInfo).GUID, obj);
        return o as nsIClassInfo;
    }
}
}