//
// ITaskItem.cs: Defines an MSBuild item that can be consumed and emitted by
// tasks.
//
// Author:
//   Marek Sieradzki (marek.sieradzki@gmail.com)
//
// (C) 2005 Marek Sieradzki
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

#if NET_2_0

using System;
using System.Collections;

namespace Microsoft.Build.Framework
{
[System.Runtime.InteropServices.GuidAttribute ("8661674F-2148-4F71-A92A-49875511C528")]
[System.Runtime.InteropServices.ComVisible (true)]
public interface ITaskItem
{
    IDictionary CloneCustomMetadata ();

    void CopyMetadataTo (ITaskItem destinationItem);

    string GetMetadata (string metadataName);

    void RemoveMetadata (string metadataName);

    void SetMetadata (string metadataName, string metadataValue);

    string ItemSpec
    {
        get;
        set;
    }

    int MetadataCount
    {
        get;
    }

    ICollection MetadataNames
    {
        get;
    }
}
}

#endif