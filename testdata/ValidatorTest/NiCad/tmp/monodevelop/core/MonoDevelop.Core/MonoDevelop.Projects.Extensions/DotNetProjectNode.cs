// MSBuildDotNetProjectExtensionNode.cs
//
// Author:
//   Lluis Sanchez Gual <lluis@novell.com>
//
// Copyright (c) 2008 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using System;
using Mono.Addins;
using MonoDevelop.Core;
using MonoDevelop.Projects.Formats.MSBuild;
using MonoDevelop.Projects.Extensions;

namespace MonoDevelop.Projects.Extensions
{
public class DotNetProjectNode: ItemTypeNode
{
    [NodeAttribute (Required=true)]
    string language = null;

    [NodeAttribute]
    string resourceHandler = null;

    public override bool CanHandleItem (SolutionEntityItem item)
    {
        return (item is DotNetProject) && ((DotNetProject)item).LanguageName == language;
    }

    public override bool CanHandleFile (string fileName, string typeGuid)
    {
        if (base.CanHandleFile (fileName, typeGuid))
            return true;
        else if (!string.IsNullOrEmpty (typeGuid) && typeGuid.Contains (Guid))
        {
            DotNetProjectSubtypeNode node = MSBuildProjectService.GetDotNetProjectSubtype (typeGuid);
            if (node != null && node.CanHandleFile (fileName, typeGuid))
                return true;
        }
        return false;
    }

    public override SolutionEntityItem LoadSolutionItem (IProgressMonitor monitor, string fileName, MSBuildFileFormat expectedFormat, string itemGuid)
    {
        MSBuildProjectHandler handler = CreateHandler<MSBuildProjectHandler> (fileName, itemGuid);
        handler.SetCustomResourceHandler (GetResourceHandler ());
        return handler.Load (monitor, fileName, expectedFormat, language, null);
    }

    public IResourceHandler GetResourceHandler ()
    {
        if (!string.IsNullOrEmpty (resourceHandler))
            return (IResourceHandler) Addin.CreateInstance (resourceHandler, true);
        else
            return new MSBuildResourceHandler ();
    }
}
}
