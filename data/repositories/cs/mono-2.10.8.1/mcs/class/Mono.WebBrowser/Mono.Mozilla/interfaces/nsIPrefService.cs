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

[Guid ("decb9cc7-c08f-4ea5-be91-a8fc637ce2d2")]
[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
[ComImport ()]
internal interface nsIPrefService
{

    #region nsIPrefService
    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int readUserPrefs (
        [MarshalAs (UnmanagedType.Interface)]   nsIFile aFile);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int resetPrefs ();

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int resetUserPrefs ();

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int savePrefFile (
        [MarshalAs (UnmanagedType.Interface)]   nsIFile aFile);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getBranch (
        [MarshalAs (UnmanagedType.LPStr)]   string aPrefRoot,[MarshalAs (UnmanagedType.Interface)]  out nsIPrefBranch ret);

    [PreserveSigAttribute]
    [MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int getDefaultBranch (
        [MarshalAs (UnmanagedType.LPStr)]   string aPrefRoot,[MarshalAs (UnmanagedType.Interface)]  out nsIPrefBranch ret);

    #endregion
}


internal class nsPrefService
{
    public static nsIPrefService GetProxy (Mono.WebBrowser.IWebBrowser control, nsIPrefService obj)
    {
        object o = Base.GetProxyForObject (control, typeof(nsIPrefService).GUID, obj);
        return o as nsIPrefService;
    }
}
}