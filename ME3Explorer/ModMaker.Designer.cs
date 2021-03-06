﻿namespace ME3Explorer
{
    partial class ModMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModMaker));
            this.TopStrip = new System.Windows.Forms.ToolStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripButton();
            this.RunAllButton = new System.Windows.Forms.ToolStripButton();
            this.ClearAllButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAllButton = new System.Windows.Forms.ToolStripButton();
            this.ThreeLabel = new System.Windows.Forms.ToolStripLabel();
            this.TwoLabel = new System.Windows.Forms.ToolStripLabel();
            this.OneLabel = new System.Windows.Forms.ToolStripLabel();
            this.GameFoundLabel = new System.Windows.Forms.ToolStripLabel();
            this.ChangePathsButton = new System.Windows.Forms.ToolStripButton();
            this.HelpButton = new System.Windows.Forms.ToolStripButton();
            this.BottomStrip = new System.Windows.Forms.ToolStrip();
            this.MainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.CancelationButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainSplitter = new System.Windows.Forms.SplitContainer();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainContextStrip = new System.Windows.Forms.ToolStrip();
            this.RunSelectedButton = new System.Windows.Forms.ToolStripButton();
            this.SaveSelectedButton = new System.Windows.Forms.ToolStripButton();
            this.MoveUpButton = new System.Windows.Forms.ToolStripButton();
            this.MoveDownButton = new System.Windows.Forms.ToolStripButton();
            this.ExtractDataButton = new System.Windows.Forms.ToolStripButton();
            this.DetailsSplitter = new KFreonLib.Helpers.FlickerFreeSplitContainer();
            this.MiddleSplitter = new KFreonLib.Helpers.FlickerFreeSplitContainer();
            this.TopSplitter = new KFreonLib.Helpers.FlickerFreeSplitContainer();
            this.GameVersionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsBox = new System.Windows.Forms.RichTextBox();
            this.PCCSplitter = new KFreonLib.Helpers.FlickerFreeSplitContainer();
            this.PCCList = new System.Windows.Forms.CheckedListBox();
            this.ExpIDLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ExpIDBox = new System.Windows.Forms.TextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.ScriptPaneSplitter = new KFreonLib.Helpers.FlickerFreeSplitContainer();
            this.HideShowButton = new System.Windows.Forms.Button();
            this.ExpandScriptButton = new System.Windows.Forms.Button();
            this.ScriptPane = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip = new System.Windows.Forms.ToolStrip();
            this.ResetScriptButton = new System.Windows.Forms.ToolStripButton();
            this.SelectAllButton = new System.Windows.Forms.ToolStripButton();
            this.UpdateJobButton = new System.Windows.Forms.ToolStripButton();
            this.PrimaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TopStrip.SuspendLayout();
            this.BottomStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.Panel2.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            this.MainContextStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsSplitter)).BeginInit();
            this.DetailsSplitter.Panel1.SuspendLayout();
            this.DetailsSplitter.Panel2.SuspendLayout();
            this.DetailsSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleSplitter)).BeginInit();
            this.MiddleSplitter.Panel1.SuspendLayout();
            this.MiddleSplitter.Panel2.SuspendLayout();
            this.MiddleSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopSplitter)).BeginInit();
            this.TopSplitter.Panel1.SuspendLayout();
            this.TopSplitter.Panel2.SuspendLayout();
            this.TopSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCCSplitter)).BeginInit();
            this.PCCSplitter.Panel1.SuspendLayout();
            this.PCCSplitter.Panel2.SuspendLayout();
            this.PCCSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptPaneSplitter)).BeginInit();
            this.ScriptPaneSplitter.Panel1.SuspendLayout();
            this.ScriptPaneSplitter.Panel2.SuspendLayout();
            this.ScriptPaneSplitter.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopStrip
            // 
            this.TopStrip.BackColor = System.Drawing.Color.White;
            this.TopStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.RunAllButton,
            this.ClearAllButton,
            this.SaveAllButton,
            this.ThreeLabel,
            this.TwoLabel,
            this.OneLabel,
            this.GameFoundLabel,
            this.ChangePathsButton,
            this.HelpButton});
            this.TopStrip.Location = new System.Drawing.Point(0, 0);
            this.TopStrip.Name = "TopStrip";
            this.TopStrip.Size = new System.Drawing.Size(1331, 25);
            this.TopStrip.TabIndex = 0;
            this.TopStrip.Text = "toolStrip1";
            // 
            // LoadButton
            // 
            this.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(37, 22);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // RunAllButton
            // 
            this.RunAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RunAllButton.Enabled = false;
            this.RunAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunAllButton.Name = "RunAllButton";
            this.RunAllButton.Size = new System.Drawing.Size(49, 22);
            this.RunAllButton.Text = "Run All";
            this.RunAllButton.Click += new System.EventHandler(this.RunAllButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearAllButton.Enabled = false;
            this.ClearAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(81, 22);
            this.ClearAllButton.Text = "Clear All Jobs";
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveAllButton.Enabled = false;
            this.SaveAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(97, 22);
            this.SaveAllButton.Text = "Save All to .mod";
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // ThreeLabel
            // 
            this.ThreeLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ThreeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ThreeLabel.ForeColor = System.Drawing.Color.Red;
            this.ThreeLabel.Name = "ThreeLabel";
            this.ThreeLabel.Size = new System.Drawing.Size(17, 22);
            this.ThreeLabel.Text = "3";
            // 
            // TwoLabel
            // 
            this.TwoLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TwoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TwoLabel.ForeColor = System.Drawing.Color.Red;
            this.TwoLabel.Name = "TwoLabel";
            this.TwoLabel.Size = new System.Drawing.Size(17, 22);
            this.TwoLabel.Text = "2";
            // 
            // OneLabel
            // 
            this.OneLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.OneLabel.ForeColor = System.Drawing.Color.Red;
            this.OneLabel.Name = "OneLabel";
            this.OneLabel.Size = new System.Drawing.Size(17, 22);
            this.OneLabel.Text = "1";
            // 
            // GameFoundLabel
            // 
            this.GameFoundLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GameFoundLabel.Enabled = false;
            this.GameFoundLabel.Name = "GameFoundLabel";
            this.GameFoundLabel.Size = new System.Drawing.Size(80, 22);
            this.GameFoundLabel.Text = "Game Found?";
            // 
            // ChangePathsButton
            // 
            this.ChangePathsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChangePathsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangePathsButton.Name = "ChangePathsButton";
            this.ChangePathsButton.Size = new System.Drawing.Size(118, 22);
            this.ChangePathsButton.Text = "Change Game Paths";
            this.ChangePathsButton.Click += new System.EventHandler(this.ChangePathsButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(36, 22);
            this.HelpButton.Text = "Help";
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // BottomStrip
            // 
            this.BottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainProgressBar,
            this.toolStripSeparator1,
            this.MainStatusLabel,
            this.CancelationButton,
            this.toolStripLabel1});
            this.BottomStrip.Location = new System.Drawing.Point(0, 589);
            this.BottomStrip.Name = "BottomStrip";
            this.BottomStrip.Size = new System.Drawing.Size(1331, 25);
            this.BottomStrip.TabIndex = 1;
            this.BottomStrip.Text = "toolStrip1";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(39, 22);
            this.MainStatusLabel.Text = "Ready";
            // 
            // CancelationButton
            // 
            this.CancelationButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CancelationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CancelationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelationButton.Name = "CancelationButton";
            this.CancelationButton.Size = new System.Drawing.Size(47, 22);
            this.CancelationButton.Text = "Cancel";
            this.CancelationButton.Visible = false;
            this.CancelationButton.Click += new System.EventHandler(this.CancelationButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(208, 22);
            this.toolStripLabel1.Text = "WV, AK, Salt, Gibbed = The Real Heros";
            // 
            // MainImageList
            // 
            this.MainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.MainImageList.ImageSize = new System.Drawing.Size(64, 64);
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter.Location = new System.Drawing.Point(0, 25);
            this.MainSplitter.Name = "MainSplitter";
            // 
            // MainSplitter.Panel1
            // 
            this.MainSplitter.Panel1.Controls.Add(this.SearchTextBox);
            this.MainSplitter.Panel1.Controls.Add(this.MainListView);
            this.MainSplitter.Panel1.Controls.Add(this.MainContextStrip);
            this.MainSplitter.Panel1MinSize = 0;
            // 
            // MainSplitter.Panel2
            // 
            this.MainSplitter.Panel2.Controls.Add(this.DetailsSplitter);
            this.MainSplitter.Panel2.Controls.Add(this.ContextMenuStrip);
            this.MainSplitter.Panel2MinSize = 0;
            this.MainSplitter.Size = new System.Drawing.Size(1331, 564);
            this.MainSplitter.SplitterDistance = 620;
            this.MainSplitter.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(614, 20);
            this.SearchTextBox.TabIndex = 2;
            // 
            // MainListView
            // 
            this.MainListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.MainListView.AllowDrop = true;
            this.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.MainListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(0, 31);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(620, 508);
            this.MainListView.SmallImageList = this.MainImageList;
            this.MainListView.TabIndex = 1;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            this.MainListView.SelectedIndexChanged += new System.EventHandler(this.MainListView_SelectedIndexChanged);
            this.MainListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainListView_DragDrop);
            this.MainListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainListView_DragEnter);
            this.MainListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainListView_KeyDown);
            this.MainListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainListView_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 622;
            // 
            // MainContextStrip
            // 
            this.MainContextStrip.AutoSize = false;
            this.MainContextStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainContextStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunSelectedButton,
            this.SaveSelectedButton,
            this.MoveUpButton,
            this.MoveDownButton,
            this.ExtractDataButton});
            this.MainContextStrip.Location = new System.Drawing.Point(0, 539);
            this.MainContextStrip.Name = "MainContextStrip";
            this.MainContextStrip.Size = new System.Drawing.Size(620, 25);
            this.MainContextStrip.TabIndex = 0;
            this.MainContextStrip.Text = "MainContextStrip";
            // 
            // RunSelectedButton
            // 
            this.RunSelectedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RunSelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunSelectedButton.Name = "RunSelectedButton";
            this.RunSelectedButton.Size = new System.Drawing.Size(79, 22);
            this.RunSelectedButton.Text = "Run Selected";
            this.RunSelectedButton.Click += new System.EventHandler(this.RunSelectedButton_Click);
            // 
            // SaveSelectedButton
            // 
            this.SaveSelectedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveSelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveSelectedButton.Name = "SaveSelectedButton";
            this.SaveSelectedButton.Size = new System.Drawing.Size(127, 22);
            this.SaveSelectedButton.Text = "Save Selected to .mod";
            this.SaveSelectedButton.Click += new System.EventHandler(this.SaveSelectedButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MoveUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(59, 22);
            this.MoveUpButton.Text = "Move Up";
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MoveDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(75, 22);
            this.MoveDownButton.Text = "Move Down";
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // ExtractDataButton
            // 
            this.ExtractDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExtractDataButton.Image = ((System.Drawing.Image)(resources.GetObject("ExtractDataButton.Image")));
            this.ExtractDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExtractDataButton.Name = "ExtractDataButton";
            this.ExtractDataButton.Size = new System.Drawing.Size(73, 22);
            this.ExtractDataButton.Text = "Extract Data";
            this.ExtractDataButton.Click += new System.EventHandler(this.ExtractDataButton_Click);
            // 
            // DetailsSplitter
            // 
            this.DetailsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsSplitter.Location = new System.Drawing.Point(0, 0);
            this.DetailsSplitter.Name = "DetailsSplitter";
            // 
            // DetailsSplitter.Panel1
            // 
            this.DetailsSplitter.Panel1.Controls.Add(this.MiddleSplitter);
            this.DetailsSplitter.Panel1MinSize = 0;
            // 
            // DetailsSplitter.Panel2
            // 
            this.DetailsSplitter.Panel2.Controls.Add(this.ScriptPaneSplitter);
            this.DetailsSplitter.Panel2MinSize = 0;
            this.DetailsSplitter.Size = new System.Drawing.Size(707, 539);
            this.DetailsSplitter.SplitterDistance = 354;
            this.DetailsSplitter.SplitterWidth = 1;
            this.DetailsSplitter.TabIndex = 1;
            // 
            // MiddleSplitter
            // 
            this.MiddleSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MiddleSplitter.IsSplitterFixed = true;
            this.MiddleSplitter.Location = new System.Drawing.Point(0, 0);
            this.MiddleSplitter.Name = "MiddleSplitter";
            this.MiddleSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MiddleSplitter.Panel1
            // 
            this.MiddleSplitter.Panel1.Controls.Add(this.TopSplitter);
            this.MiddleSplitter.Panel1MinSize = 0;
            // 
            // MiddleSplitter.Panel2
            // 
            this.MiddleSplitter.Panel2.Controls.Add(this.PCCSplitter);
            this.MiddleSplitter.Panel2MinSize = 0;
            this.MiddleSplitter.Size = new System.Drawing.Size(354, 539);
            this.MiddleSplitter.SplitterDistance = 148;
            this.MiddleSplitter.SplitterWidth = 1;
            this.MiddleSplitter.TabIndex = 0;
            // 
            // TopSplitter
            // 
            this.TopSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.TopSplitter.IsSplitterFixed = true;
            this.TopSplitter.Location = new System.Drawing.Point(0, 0);
            this.TopSplitter.Name = "TopSplitter";
            this.TopSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TopSplitter.Panel1
            // 
            this.TopSplitter.Panel1.Controls.Add(this.GameVersionBox);
            this.TopSplitter.Panel1.Controls.Add(this.label1);
            // 
            // TopSplitter.Panel2
            // 
            this.TopSplitter.Panel2.Controls.Add(this.DetailsBox);
            this.TopSplitter.Size = new System.Drawing.Size(354, 148);
            this.TopSplitter.SplitterDistance = 30;
            this.TopSplitter.SplitterWidth = 1;
            this.TopSplitter.TabIndex = 1;
            // 
            // GameVersionBox
            // 
            this.GameVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVersionBox.FormattingEnabled = true;
            this.GameVersionBox.Items.AddRange(new object[] {
            "UNKNOWN",
            "1",
            "2",
            "3"});
            this.GameVersionBox.Location = new System.Drawing.Point(85, 4);
            this.GameVersionBox.Name = "GameVersionBox";
            this.GameVersionBox.Size = new System.Drawing.Size(121, 21);
            this.GameVersionBox.TabIndex = 1;
            this.GameVersionBox.SelectedIndexChanged += new System.EventHandler(this.GameVersionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Version:";
            // 
            // DetailsBox
            // 
            this.DetailsBox.BackColor = System.Drawing.Color.White;
            this.DetailsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsBox.Location = new System.Drawing.Point(0, 0);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.ReadOnly = true;
            this.DetailsBox.Size = new System.Drawing.Size(354, 117);
            this.DetailsBox.TabIndex = 1;
            this.DetailsBox.Text = "";
            this.DetailsBox.WordWrap = false;
            // 
            // PCCSplitter
            // 
            this.PCCSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCCSplitter.Location = new System.Drawing.Point(0, 0);
            this.PCCSplitter.Name = "PCCSplitter";
            this.PCCSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PCCSplitter.Panel1
            // 
            this.PCCSplitter.Panel1.Controls.Add(this.PCCList);
            this.PCCSplitter.Panel1MinSize = 0;
            // 
            // PCCSplitter.Panel2
            // 
            this.PCCSplitter.Panel2.Controls.Add(this.ExpIDLabel);
            this.PCCSplitter.Panel2.Controls.Add(this.PathLabel);
            this.PCCSplitter.Panel2.Controls.Add(this.ExpIDBox);
            this.PCCSplitter.Panel2.Controls.Add(this.PathBox);
            this.PCCSplitter.Panel2MinSize = 0;
            this.PCCSplitter.Size = new System.Drawing.Size(354, 390);
            this.PCCSplitter.SplitterDistance = 334;
            this.PCCSplitter.SplitterWidth = 1;
            this.PCCSplitter.TabIndex = 0;
            this.PCCSplitter.Leave += new System.EventHandler(this.PCCSplitter_FocusLost);
            // 
            // PCCList
            // 
            this.PCCList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PCCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCCList.FormattingEnabled = true;
            this.PCCList.HorizontalScrollbar = true;
            this.PCCList.IntegralHeight = false;
            this.PCCList.Location = new System.Drawing.Point(0, 0);
            this.PCCList.Name = "PCCList";
            this.PCCList.Size = new System.Drawing.Size(354, 334);
            this.PCCList.TabIndex = 0;
            this.PCCList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PCCList_CheckChanged);
            this.PCCList.SelectedIndexChanged += new System.EventHandler(this.PCCList_SelectedIndexChanged);
            // 
            // ExpIDLabel
            // 
            this.ExpIDLabel.AutoSize = true;
            this.ExpIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpIDLabel.Location = new System.Drawing.Point(3, 32);
            this.ExpIDLabel.Name = "ExpIDLabel";
            this.ExpIDLabel.Size = new System.Drawing.Size(45, 13);
            this.ExpIDLabel.TabIndex = 2;
            this.ExpIDLabel.Text = "ExpID:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(3, 6);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(37, 13);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Path:";
            // 
            // ExpIDBox
            // 
            this.ExpIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpIDBox.Location = new System.Drawing.Point(54, 29);
            this.ExpIDBox.Name = "ExpIDBox";
            this.ExpIDBox.Size = new System.Drawing.Size(295, 20);
            this.ExpIDBox.TabIndex = 3;
            this.ExpIDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpIDBox_KeyDown);
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.Location = new System.Drawing.Point(54, 3);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(295, 20);
            this.PathBox.TabIndex = 0;
            this.PathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathBox_KeyDown);
            // 
            // ScriptPaneSplitter
            // 
            this.ScriptPaneSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptPaneSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ScriptPaneSplitter.IsSplitterFixed = true;
            this.ScriptPaneSplitter.Location = new System.Drawing.Point(0, 0);
            this.ScriptPaneSplitter.Name = "ScriptPaneSplitter";
            this.ScriptPaneSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScriptPaneSplitter.Panel1
            // 
            this.ScriptPaneSplitter.Panel1.Controls.Add(this.HideShowButton);
            this.ScriptPaneSplitter.Panel1.Controls.Add(this.ExpandScriptButton);
            this.ScriptPaneSplitter.Panel1MinSize = 0;
            // 
            // ScriptPaneSplitter.Panel2
            // 
            this.ScriptPaneSplitter.Panel2.Controls.Add(this.ScriptPane);
            this.ScriptPaneSplitter.Panel2MinSize = 0;
            this.ScriptPaneSplitter.Size = new System.Drawing.Size(352, 539);
            this.ScriptPaneSplitter.SplitterDistance = 30;
            this.ScriptPaneSplitter.SplitterWidth = 1;
            this.ScriptPaneSplitter.TabIndex = 1;
            // 
            // HideShowButton
            // 
            this.HideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HideShowButton.Location = new System.Drawing.Point(46, 4);
            this.HideShowButton.Name = "HideShowButton";
            this.HideShowButton.Size = new System.Drawing.Size(27, 23);
            this.HideShowButton.TabIndex = 2;
            this.HideShowButton.Text = ">>";
            this.HideShowButton.UseVisualStyleBackColor = true;
            this.HideShowButton.Click += new System.EventHandler(this.HideShowButton_Click);
            // 
            // ExpandScriptButton
            // 
            this.ExpandScriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExpandScriptButton.Location = new System.Drawing.Point(5, 4);
            this.ExpandScriptButton.Name = "ExpandScriptButton";
            this.ExpandScriptButton.Size = new System.Drawing.Size(35, 23);
            this.ExpandScriptButton.TabIndex = 1;
            this.ExpandScriptButton.Text = "<<<";
            this.ExpandScriptButton.UseVisualStyleBackColor = true;
            this.ExpandScriptButton.Click += new System.EventHandler(this.ExpandScriptButton_Click);
            // 
            // ScriptPane
            // 
            this.ScriptPane.AcceptsTab = true;
            this.ScriptPane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptPane.Location = new System.Drawing.Point(0, 0);
            this.ScriptPane.Name = "ScriptPane";
            this.ScriptPane.Size = new System.Drawing.Size(352, 508);
            this.ScriptPane.TabIndex = 0;
            this.ScriptPane.Text = "";
            this.ScriptPane.WordWrap = false;
            this.ScriptPane.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScriptPane_KeyDown);
            this.ScriptPane.Leave += new System.EventHandler(this.ScriptPane_FocusLost);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContextMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetScriptButton,
            this.SelectAllButton,
            this.UpdateJobButton});
            this.ContextMenuStrip.Location = new System.Drawing.Point(0, 539);
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(707, 25);
            this.ContextMenuStrip.TabIndex = 0;
            this.ContextMenuStrip.Text = "toolStrip1";
            // 
            // ResetScriptButton
            // 
            this.ResetScriptButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ResetScriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetScriptButton.Name = "ResetScriptButton";
            this.ResetScriptButton.Size = new System.Drawing.Size(72, 22);
            this.ResetScriptButton.Text = "Reset Script";
            this.ResetScriptButton.Click += new System.EventHandler(this.ResetScriptButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(59, 22);
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // UpdateJobButton
            // 
            this.UpdateJobButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UpdateJobButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateJobButton.Name = "UpdateJobButton";
            this.UpdateJobButton.Size = new System.Drawing.Size(70, 22);
            this.UpdateJobButton.Text = "Update Job";
            this.UpdateJobButton.Click += new System.EventHandler(this.UpdateJobButton_Click);
            // 
            // ModMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 614);
            this.Controls.Add(this.MainSplitter);
            this.Controls.Add(this.BottomStrip);
            this.Controls.Add(this.TopStrip);
            this.DoubleBuffered = true;
            this.Name = "ModMaker";
            this.Text = "Mod Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.TopStrip.ResumeLayout(false);
            this.TopStrip.PerformLayout();
            this.BottomStrip.ResumeLayout(false);
            this.BottomStrip.PerformLayout();
            this.MainSplitter.Panel1.ResumeLayout(false);
            this.MainSplitter.Panel1.PerformLayout();
            this.MainSplitter.Panel2.ResumeLayout(false);
            this.MainSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).EndInit();
            this.MainSplitter.ResumeLayout(false);
            this.MainContextStrip.ResumeLayout(false);
            this.MainContextStrip.PerformLayout();
            this.DetailsSplitter.Panel1.ResumeLayout(false);
            this.DetailsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailsSplitter)).EndInit();
            this.DetailsSplitter.ResumeLayout(false);
            this.MiddleSplitter.Panel1.ResumeLayout(false);
            this.MiddleSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MiddleSplitter)).EndInit();
            this.MiddleSplitter.ResumeLayout(false);
            this.TopSplitter.Panel1.ResumeLayout(false);
            this.TopSplitter.Panel1.PerformLayout();
            this.TopSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopSplitter)).EndInit();
            this.TopSplitter.ResumeLayout(false);
            this.PCCSplitter.Panel1.ResumeLayout(false);
            this.PCCSplitter.Panel2.ResumeLayout(false);
            this.PCCSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCCSplitter)).EndInit();
            this.PCCSplitter.ResumeLayout(false);
            this.ScriptPaneSplitter.Panel1.ResumeLayout(false);
            this.ScriptPaneSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptPaneSplitter)).EndInit();
            this.ScriptPaneSplitter.ResumeLayout(false);
            this.ContextMenuStrip.ResumeLayout(false);
            this.ContextMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopStrip;
        private System.Windows.Forms.ToolStrip BottomStrip;
        private System.Windows.Forms.ToolStripProgressBar MainProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel MainStatusLabel;
        private System.Windows.Forms.ToolStripButton CancelationButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton LoadButton;
        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.ImageList MainImageList;
        private System.Windows.Forms.Button HideShowButton;
        private System.Windows.Forms.Button ExpandScriptButton;
        private System.Windows.Forms.RichTextBox ScriptPane;
        private System.Windows.Forms.ToolStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStrip MainContextStrip;
        private System.Windows.Forms.ToolStripButton RunSelectedButton;
        private System.Windows.Forms.ToolStripButton MoveUpButton;
        private System.Windows.Forms.ToolStripButton MoveDownButton;
        private System.Windows.Forms.ToolStripButton ResetScriptButton;
        private System.Windows.Forms.ToolStripButton SelectAllButton;
        private System.Windows.Forms.ToolStripButton UpdateJobButton;
        private System.Windows.Forms.ToolStripButton RunAllButton;
        private System.Windows.Forms.ToolStripButton ClearAllButton;
        private System.Windows.Forms.ToolStripButton SaveAllButton;
        private System.Windows.Forms.ToolStripButton SaveSelectedButton;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.CheckedListBox PCCList;
        private System.Windows.Forms.Label ExpIDLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox ExpIDBox;
        private KFreonLib.Helpers.FlickerFreeSplitContainer DetailsSplitter;
        private KFreonLib.Helpers.FlickerFreeSplitContainer PCCSplitter;
        private System.Windows.Forms.RichTextBox DetailsBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripLabel ThreeLabel;
        private System.Windows.Forms.ToolStripLabel TwoLabel;
        private System.Windows.Forms.ToolStripLabel OneLabel;
        private System.Windows.Forms.ToolStripLabel GameFoundLabel;
        private System.Windows.Forms.ToolStripButton ChangePathsButton;
        private KFreonLib.Helpers.FlickerFreeSplitContainer TopSplitter;
        private System.Windows.Forms.Label label1;
        private KFreonLib.Helpers.FlickerFreeSplitContainer ScriptPaneSplitter;
        private KFreonLib.Helpers.FlickerFreeSplitContainer MiddleSplitter;
        private System.Windows.Forms.ToolStripButton HelpButton;
        private System.Windows.Forms.ToolTip PrimaryToolTip;
        private System.Windows.Forms.ComboBox GameVersionBox;
        private System.Windows.Forms.ToolStripButton ExtractDataButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}