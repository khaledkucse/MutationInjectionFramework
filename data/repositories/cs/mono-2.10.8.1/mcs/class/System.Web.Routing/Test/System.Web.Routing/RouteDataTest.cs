//
// RouteDataTest.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2008 Novell Inc. http://novell.com
//

//
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
using System;
using System.Web;
using System.Web.Routing;
using NUnit.Framework;

namespace MonoTests.System.Web.Routing
{
[TestFixture]
public class RouteDataTest
{
    [Test]
    public void ConstructorNullArgs ()
    {
        new RouteData (null, null);
    }

    [Test]
    public void DefaultValues ()
    {
        var d = new RouteData ();
        Assert.IsNull (d.Route, "#1");
        Assert.IsNull (d.RouteHandler, "#2");
        Assert.AreEqual (0, d.DataTokens.Count, "#3");
        Assert.AreEqual (0, d.Values.Count, "#4");
    }

    [Test]
    [ExpectedException (typeof (ArgumentNullException))]
    public void GetRequiredStringNull ()
    {
        var d = new RouteData ();
        d.GetRequiredString (null);
    }

    [Test]
    [ExpectedException (typeof (InvalidOperationException))]
    public void GetRequiredStringNonexistent ()
    {
        var d = new RouteData ();
        d.GetRequiredString ("a");
    }

    [Test]
    public void GetRequiredStringExistent ()
    {
        var d = new RouteData ();
        d.Values.Add ("a", "x");
        Assert.AreEqual ("x", d.GetRequiredString ("a"));
    }

    [Test]
    [ExpectedException (typeof (InvalidOperationException))]
    public void GetRequiredStringForNonStringValue ()
    {
        var d = new RouteData ();
        d.Values.Add ("a", 10);
        Assert.AreEqual ("10", d.GetRequiredString ("a"));
    }
}
}
