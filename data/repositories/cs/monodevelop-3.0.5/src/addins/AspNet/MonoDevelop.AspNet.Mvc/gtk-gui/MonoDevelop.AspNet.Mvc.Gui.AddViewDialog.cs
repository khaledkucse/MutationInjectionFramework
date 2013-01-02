
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AspNet.Mvc.Gui
{
public partial class AddViewDialog
{
    private global::Gtk.VBox vbox2;
    private global::Gtk.Table table1;
    private global::Gtk.Label label1;
    private global::Gtk.Label label4;
    private global::Gtk.Entry nameEntry;
    private global::Gtk.ComboBox templateCombo;
    private global::Gtk.Frame frame1;
    private global::Gtk.Alignment alignment1;
    private global::Gtk.VBox vbox4;
    private global::Gtk.CheckButton partialCheck;
    private global::Gtk.CheckButton stronglyTypedCheck;
    private global::Gtk.Alignment typePanel;
    private global::Gtk.HBox hbox1;
    private global::Gtk.Label label3;
    private global::Gtk.Alignment dataClassAlignment;
    private global::Gtk.CheckButton masterCheck;
    private global::Gtk.Alignment masterPanel;
    private global::Gtk.VBox vbox3;
    private global::Gtk.HBox hbox4;
    private global::Gtk.Label label5;
    private global::Gtk.Entry masterEntry;
    private global::Gtk.Button masterButton;
    private global::Gtk.HBox hbox3;
    private global::Gtk.Label label2;
    private global::Gtk.ComboBoxEntry primaryPlaceholderCombo;
    private global::Gtk.Label GtkLabel6;
    private global::Gtk.Button buttonCancel;
    private global::Gtk.Button buttonOk;

    protected virtual void Build ()
    {
        global::Stetic.Gui.Initialize (this);
        // Widget MonoDevelop.AspNet.Mvc.Gui.AddViewDialog
        this.Name = "MonoDevelop.AspNet.Mvc.Gui.AddViewDialog";
        this.Title = global::Mono.Unix.Catalog.GetString ("Add View");
        this.WindowPosition = ((global::Gtk.WindowPosition)(4));
        this.BorderWidth = ((uint)(6));
        this.Resizable = false;
        this.AllowGrow = false;
        // Internal child MonoDevelop.AspNet.Mvc.Gui.AddViewDialog.VBox
        global::Gtk.VBox w1 = this.VBox;
        w1.Name = "dialog1_VBox";
        w1.BorderWidth = ((uint)(2));
        // Container child dialog1_VBox.Gtk.Box+BoxChild
        this.vbox2 = new global::Gtk.VBox ();
        this.vbox2.Name = "vbox2";
        this.vbox2.Spacing = 6;
        // Container child vbox2.Gtk.Box+BoxChild
        this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
        this.table1.Name = "table1";
        this.table1.RowSpacing = ((uint)(6));
        this.table1.ColumnSpacing = ((uint)(6));
        // Container child table1.Gtk.Table+TableChild
        this.label1 = new global::Gtk.Label ();
        this.label1.Name = "label1";
        this.label1.Xalign = 0F;
        this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Name:");
        this.label1.UseUnderline = true;
        this.table1.Add (this.label1);
        global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
        w2.XOptions = ((global::Gtk.AttachOptions)(4));
        w2.YOptions = ((global::Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.label4 = new global::Gtk.Label ();
        this.label4.Name = "label4";
        this.label4.Xalign = 0F;
        this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("_Template:");
        this.label4.UseUnderline = true;
        this.table1.Add (this.label4);
        global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
        w3.TopAttach = ((uint)(1));
        w3.BottomAttach = ((uint)(2));
        w3.XOptions = ((global::Gtk.AttachOptions)(4));
        w3.YOptions = ((global::Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.nameEntry = new global::Gtk.Entry ();
        this.nameEntry.CanFocus = true;
        this.nameEntry.Name = "nameEntry";
        this.nameEntry.IsEditable = true;
        this.nameEntry.InvisibleChar = '●';
        this.table1.Add (this.nameEntry);
        global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.nameEntry]));
        w4.LeftAttach = ((uint)(1));
        w4.RightAttach = ((uint)(2));
        w4.YOptions = ((global::Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.templateCombo = global::Gtk.ComboBox.NewText ();
        this.templateCombo.Name = "templateCombo";
        this.table1.Add (this.templateCombo);
        global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.templateCombo]));
        w5.TopAttach = ((uint)(1));
        w5.BottomAttach = ((uint)(2));
        w5.LeftAttach = ((uint)(1));
        w5.RightAttach = ((uint)(2));
        w5.XOptions = ((global::Gtk.AttachOptions)(4));
        w5.YOptions = ((global::Gtk.AttachOptions)(4));
        this.vbox2.Add (this.table1);
        global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
        w6.Position = 0;
        w6.Expand = false;
        w6.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        this.frame1 = new global::Gtk.Frame ();
        this.frame1.Name = "frame1";
        this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
        this.frame1.BorderWidth = ((uint)(2));
        // Container child frame1.Gtk.Container+ContainerChild
        this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
        this.alignment1.Name = "alignment1";
        this.alignment1.LeftPadding = ((uint)(4));
        this.alignment1.TopPadding = ((uint)(4));
        this.alignment1.RightPadding = ((uint)(4));
        this.alignment1.BottomPadding = ((uint)(4));
        // Container child alignment1.Gtk.Container+ContainerChild
        this.vbox4 = new global::Gtk.VBox ();
        this.vbox4.Name = "vbox4";
        this.vbox4.Spacing = 6;
        // Container child vbox4.Gtk.Box+BoxChild
        this.partialCheck = new global::Gtk.CheckButton ();
        this.partialCheck.CanFocus = true;
        this.partialCheck.Name = "partialCheck";
        this.partialCheck.Label = global::Mono.Unix.Catalog.GetString ("_Partial view (ascx)");
        this.partialCheck.DrawIndicator = true;
        this.partialCheck.UseUnderline = true;
        this.vbox4.Add (this.partialCheck);
        global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.partialCheck]));
        w7.Position = 0;
        w7.Expand = false;
        w7.Fill = false;
        // Container child vbox4.Gtk.Box+BoxChild
        this.stronglyTypedCheck = new global::Gtk.CheckButton ();
        this.stronglyTypedCheck.CanFocus = true;
        this.stronglyTypedCheck.Name = "stronglyTypedCheck";
        this.stronglyTypedCheck.Label = global::Mono.Unix.Catalog.GetString ("_Strongly typed");
        this.stronglyTypedCheck.DrawIndicator = true;
        this.stronglyTypedCheck.UseUnderline = true;
        this.vbox4.Add (this.stronglyTypedCheck);
        global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.stronglyTypedCheck]));
        w8.Position = 1;
        w8.Expand = false;
        w8.Fill = false;
        // Container child vbox4.Gtk.Box+BoxChild
        this.typePanel = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
        this.typePanel.Name = "typePanel";
        this.typePanel.LeftPadding = ((uint)(24));
        // Container child typePanel.Gtk.Container+ContainerChild
        this.hbox1 = new global::Gtk.HBox ();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.label3 = new global::Gtk.Label ();
        this.label3.Name = "label3";
        this.label3.Xalign = 0F;
        this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("_Data class:");
        this.label3.UseUnderline = true;
        this.hbox1.Add (this.label3);
        global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
        w9.Position = 0;
        w9.Expand = false;
        w9.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.dataClassAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
        this.dataClassAlignment.Name = "dataClassAlignment";
        this.hbox1.Add (this.dataClassAlignment);
        global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.dataClassAlignment]));
        w10.Position = 1;
        this.typePanel.Add (this.hbox1);
        this.vbox4.Add (this.typePanel);
        global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.typePanel]));
        w12.Position = 2;
        w12.Fill = false;
        // Container child vbox4.Gtk.Box+BoxChild
        this.masterCheck = new global::Gtk.CheckButton ();
        this.masterCheck.CanFocus = true;
        this.masterCheck.Name = "masterCheck";
        this.masterCheck.Label = global::Mono.Unix.Catalog.GetString ("Has _master page:");
        this.masterCheck.DrawIndicator = true;
        this.masterCheck.UseUnderline = true;
        this.vbox4.Add (this.masterCheck);
        global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.masterCheck]));
        w13.Position = 3;
        w13.Expand = false;
        w13.Fill = false;
        // Container child vbox4.Gtk.Box+BoxChild
        this.masterPanel = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
        this.masterPanel.Name = "masterPanel";
        this.masterPanel.LeftPadding = ((uint)(24));
        // Container child masterPanel.Gtk.Container+ContainerChild
        this.vbox3 = new global::Gtk.VBox ();
        this.vbox3.Name = "vbox3";
        this.vbox3.Spacing = 6;
        // Container child vbox3.Gtk.Box+BoxChild
        this.hbox4 = new global::Gtk.HBox ();
        this.hbox4.Name = "hbox4";
        this.hbox4.Spacing = 6;
        // Container child hbox4.Gtk.Box+BoxChild
        this.label5 = new global::Gtk.Label ();
        this.label5.Name = "label5";
        this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("_File:");
        this.label5.UseUnderline = true;
        this.hbox4.Add (this.label5);
        global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label5]));
        w14.Position = 0;
        w14.Expand = false;
        w14.Fill = false;
        // Container child hbox4.Gtk.Box+BoxChild
        this.masterEntry = new global::Gtk.Entry ();
        this.masterEntry.CanFocus = true;
        this.masterEntry.Name = "masterEntry";
        this.masterEntry.IsEditable = true;
        this.masterEntry.InvisibleChar = '●';
        this.hbox4.Add (this.masterEntry);
        global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.masterEntry]));
        w15.Position = 1;
        // Container child hbox4.Gtk.Box+BoxChild
        this.masterButton = new global::Gtk.Button ();
        this.masterButton.CanFocus = true;
        this.masterButton.Name = "masterButton";
        this.masterButton.UseUnderline = true;
        this.masterButton.Label = global::Mono.Unix.Catalog.GetString ("...");
        this.hbox4.Add (this.masterButton);
        global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.masterButton]));
        w16.Position = 2;
        w16.Expand = false;
        w16.Fill = false;
        this.vbox3.Add (this.hbox4);
        global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
        w17.Position = 0;
        w17.Expand = false;
        w17.Fill = false;
        // Container child vbox3.Gtk.Box+BoxChild
        this.hbox3 = new global::Gtk.HBox ();
        this.hbox3.Name = "hbox3";
        this.hbox3.Spacing = 6;
        // Container child hbox3.Gtk.Box+BoxChild
        this.label2 = new global::Gtk.Label ();
        this.label2.Name = "label2";
        this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("P_rimary placeholder: ");
        this.label2.UseUnderline = true;
        this.hbox3.Add (this.label2);
        global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
        w18.Position = 0;
        w18.Expand = false;
        w18.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.primaryPlaceholderCombo = global::Gtk.ComboBoxEntry.NewText ();
        this.primaryPlaceholderCombo.WidthRequest = 250;
        this.primaryPlaceholderCombo.Name = "primaryPlaceholderCombo";
        this.hbox3.Add (this.primaryPlaceholderCombo);
        global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.primaryPlaceholderCombo]));
        w19.Position = 1;
        this.vbox3.Add (this.hbox3);
        global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
        w20.Position = 1;
        w20.Expand = false;
        w20.Fill = false;
        this.masterPanel.Add (this.vbox3);
        this.vbox4.Add (this.masterPanel);
        global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.masterPanel]));
        w22.Position = 4;
        w22.Expand = false;
        w22.Fill = false;
        this.alignment1.Add (this.vbox4);
        this.frame1.Add (this.alignment1);
        this.GtkLabel6 = new global::Gtk.Label ();
        this.GtkLabel6.Name = "GtkLabel6";
        this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("Options");
        this.frame1.LabelWidget = this.GtkLabel6;
        this.vbox2.Add (this.frame1);
        global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
        w25.Position = 1;
        w25.Expand = false;
        w25.Fill = false;
        w1.Add (this.vbox2);
        global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
        w26.Position = 0;
        w26.Expand = false;
        w26.Fill = false;
        // Internal child MonoDevelop.AspNet.Mvc.Gui.AddViewDialog.ActionArea
        global::Gtk.HButtonBox w27 = this.ActionArea;
        w27.Name = "dialog1_ActionArea";
        w27.Spacing = 6;
        w27.BorderWidth = ((uint)(5));
        w27.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
        // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
        this.buttonCancel = new global::Gtk.Button ();
        this.buttonCancel.CanDefault = true;
        this.buttonCancel.CanFocus = true;
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.UseStock = true;
        this.buttonCancel.UseUnderline = true;
        this.buttonCancel.Label = "gtk-cancel";
        this.AddActionWidget (this.buttonCancel, -6);
        global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w27 [this.buttonCancel]));
        w28.Expand = false;
        w28.Fill = false;
        // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
        this.buttonOk = new global::Gtk.Button ();
        this.buttonOk.CanDefault = true;
        this.buttonOk.CanFocus = true;
        this.buttonOk.Name = "buttonOk";
        this.buttonOk.UseStock = true;
        this.buttonOk.UseUnderline = true;
        this.buttonOk.Label = "gtk-ok";
        this.AddActionWidget (this.buttonOk, -5);
        global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w27 [this.buttonOk]));
        w29.Position = 1;
        w29.Expand = false;
        w29.Fill = false;
        if ((this.Child != null))
        {
            this.Child.ShowAll ();
        }
        this.DefaultWidth = 470;
        this.DefaultHeight = 387;
        this.label1.MnemonicWidget = this.nameEntry;
        this.label4.MnemonicWidget = this.templateCombo;
        this.label5.MnemonicWidget = this.masterEntry;
        this.Hide ();
        this.templateCombo.Changed += new global::System.EventHandler (this.Validate);
        this.nameEntry.Changed += new global::System.EventHandler (this.Validate);
        this.partialCheck.Toggled += new global::System.EventHandler (this.UpdateMasterPanelSensitivity);
        this.stronglyTypedCheck.Toggled += new global::System.EventHandler (this.UpdateTypePanelSensitivity);
        this.masterCheck.Toggled += new global::System.EventHandler (this.UpdateMasterPanelSensitivity);
        this.masterEntry.Changed += new global::System.EventHandler (this.MasterChanged);
        this.masterButton.Clicked += new global::System.EventHandler (this.ShowMasterSelectionDialog);
        this.primaryPlaceholderCombo.Changed += new global::System.EventHandler (this.Validate);
    }
}
}