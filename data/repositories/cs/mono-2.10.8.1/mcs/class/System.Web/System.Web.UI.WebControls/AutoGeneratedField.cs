//
// System.Web.UI.WebControls.AutoGeneratedField.cs
//
// Authors:
//	Lluis Sanchez Gual (lluis@novell.com)
//
// (C) 2005-2010 Novell, Inc (http://www.novell.com)
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

using System.Collections;
using System.Collections.Specialized;
using System.Web.UI;
using System.ComponentModel;
using System.Security.Permissions;

namespace System.Web.UI.WebControls
{
[EditorBrowsableAttribute (EditorBrowsableState.Never)]
[AspNetHostingPermissionAttribute (SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
[AspNetHostingPermissionAttribute (SecurityAction.InheritanceDemand, Level = AspNetHostingPermissionLevel.Minimal)]
public sealed class AutoGeneratedField : BoundField
{
    Type dataType = typeof(string);

    internal AutoGeneratedField ()
    {
    }

    public AutoGeneratedField (string dataField)
    {
        DataField = dataField;
    }

    internal AutoGeneratedField (AutoGeneratedFieldProperties fieldProperties)
    {
        DataField = fieldProperties.DataField;
        DataType = fieldProperties.Type;
        SortExpression = fieldProperties.Name;
        HeaderText = fieldProperties.Name;
        ReadOnly = fieldProperties.IsReadOnly;
    }

    public Type DataType
    {
        get
        {
            return dataType;
        }
        set
        {
            dataType = value;
        }
    }

    public override bool ConvertEmptyStringToNull
    {
        get
        {
            return true;
        }
        set
        {
            throw new NotSupportedException ();
        }
    }

    public override string DataFormatString
    {
        get
        {
            return string.Empty;
        }
        set
        {
            throw new NotSupportedException ();
        }
    }

    public override bool InsertVisible
    {
        get
        {
            return true;
        }
        set
        {
            throw new NotSupportedException ();
        }
    }

    [MonoTODO ("Support other data types")]
    public override void ExtractValuesFromCell (IOrderedDictionary dictionary,
            DataControlFieldCell cell, DataControlRowState rowState, bool includeReadOnly)
    {
        if (dataType == typeof(bool))
        {
            bool editable = IsEditable (rowState);
            if (editable || includeReadOnly)
            {
                CheckBox box = (CheckBox) cell.Controls [0];
                dictionary [DataField] = box.Checked;
            }
        }
        else
            base.ExtractValuesFromCell (dictionary, cell, rowState, includeReadOnly);
    }


    [MonoTODO ("Support other data types")]
    protected override void InitializeDataCell (DataControlFieldCell cell, DataControlRowState rowState)
    {
        if (dataType == typeof(bool))
        {
            bool editable = IsEditable (rowState);
            CheckBox box = new CheckBox ();
            box.Enabled = editable;
            box.ToolTip = HeaderText;
            cell.Controls.Add (box);
        }
        else
            base.InitializeDataCell (cell, rowState);
    }

    [MonoTODO ("Support other data types")]
    protected override void OnDataBindField (object sender, EventArgs e)
    {
        DataControlFieldCell cell = (DataControlFieldCell) sender;
        if (dataType == typeof(bool))
        {
            CheckBox box = (CheckBox) cell.Controls [0];
            object val = GetValue (cell.BindingContainer);
            if (val != null && val != DBNull.Value)
                box.Checked = (bool)val;
            else if (string.IsNullOrEmpty (DataField))
            {
                box.Visible = false;
                return;
            }

            if (!box.Visible)
                box.Visible = true;
        }
        else
            base.OnDataBindField (sender, e);
    }

    public override void ValidateSupportsCallback ()
    {
    }

    protected override DataControlField CreateField ()
    {
        return new AutoGeneratedField ();
    }

    protected override void CopyProperties (DataControlField newField)
    {
        base.CopyProperties (newField);
        AutoGeneratedField field = (AutoGeneratedField) newField;
        field.DataType = DataType;
    }

    protected override object GetDesignTimeValue()
    {
        return base.GetDesignTimeValue ();
    }
}
}

