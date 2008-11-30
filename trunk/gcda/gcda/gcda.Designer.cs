namespace gcda
{
    partial class gcda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gcda));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Seperator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSplitter = new System.Windows.Forms.SplitContainer();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.InformationSplitter = new System.Windows.Forms.SplitContainer();
            this.AttributesTabControl = new System.Windows.Forms.TabControl();
            this.EmailTab = new System.Windows.Forms.TabPage();
            this.IMTab = new System.Windows.Forms.TabPage();
            this.OrganizationTab = new System.Windows.Forms.TabPage();
            this.PhoneTab = new System.Windows.Forms.TabPage();
            this.AddressesTab = new System.Windows.Forms.TabPage();
            this.UserInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.MainStatusStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.Panel2.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            this.InformationSplitter.Panel1.SuspendLayout();
            this.InformationSplitter.Panel2.SuspendLayout();
            this.InformationSplitter.SuspendLayout();
            this.AttributesTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatusLabel,
            this.Seperator1,
            this.UserNameStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 542);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.MainStatusLabel.Text = "Ready";
            // 
            // Seperator1
            // 
            this.Seperator1.Name = "Seperator1";
            this.Seperator1.Size = new System.Drawing.Size(10, 17);
            this.Seperator1.Text = "|";
            // 
            // UserNameStatusLabel
            // 
            this.UserNameStatusLabel.Name = "UserNameStatusLabel";
            this.UserNameStatusLabel.Size = new System.Drawing.Size(92, 17);
            this.UserNameStatusLabel.Text = "Not Logged In...";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.connectToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.connectToolStripMenuItem.Text = "Connect...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter.IsSplitterFixed = true;
            this.MainSplitter.Location = new System.Drawing.Point(0, 24);
            this.MainSplitter.Name = "MainSplitter";
            // 
            // MainSplitter.Panel1
            // 
            this.MainSplitter.Panel1.Controls.Add(this.ContactListBox);
            // 
            // MainSplitter.Panel2
            // 
            this.MainSplitter.Panel2.Controls.Add(this.InformationSplitter);
            this.MainSplitter.Size = new System.Drawing.Size(784, 518);
            this.MainSplitter.SplitterDistance = 200;
            this.MainSplitter.TabIndex = 2;
            // 
            // ContactListBox
            // 
            this.ContactListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.Location = new System.Drawing.Point(0, 0);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(200, 511);
            this.ContactListBox.TabIndex = 0;
            this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
            // 
            // InformationSplitter
            // 
            this.InformationSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSplitter.Location = new System.Drawing.Point(0, 0);
            this.InformationSplitter.Name = "InformationSplitter";
            this.InformationSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // InformationSplitter.Panel1
            // 
            this.InformationSplitter.Panel1.Controls.Add(this.UserInfoGroupBox);
            // 
            // InformationSplitter.Panel2
            // 
            this.InformationSplitter.Panel2.Controls.Add(this.AttributesTabControl);
            this.InformationSplitter.Size = new System.Drawing.Size(580, 518);
            this.InformationSplitter.SplitterDistance = 200;
            this.InformationSplitter.TabIndex = 0;
            // 
            // AttributesTabControl
            // 
            this.AttributesTabControl.Controls.Add(this.PhoneTab);
            this.AttributesTabControl.Controls.Add(this.AddressesTab);
            this.AttributesTabControl.Controls.Add(this.OrganizationTab);
            this.AttributesTabControl.Controls.Add(this.EmailTab);
            this.AttributesTabControl.Controls.Add(this.IMTab);
            this.AttributesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesTabControl.Location = new System.Drawing.Point(0, 0);
            this.AttributesTabControl.Name = "AttributesTabControl";
            this.AttributesTabControl.SelectedIndex = 0;
            this.AttributesTabControl.Size = new System.Drawing.Size(580, 314);
            this.AttributesTabControl.TabIndex = 0;
            // 
            // EmailTab
            // 
            this.EmailTab.Location = new System.Drawing.Point(4, 22);
            this.EmailTab.Name = "EmailTab";
            this.EmailTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmailTab.Size = new System.Drawing.Size(572, 288);
            this.EmailTab.TabIndex = 0;
            this.EmailTab.Text = "Email Addresses";
            this.EmailTab.UseVisualStyleBackColor = true;
            // 
            // IMTab
            // 
            this.IMTab.Location = new System.Drawing.Point(4, 22);
            this.IMTab.Name = "IMTab";
            this.IMTab.Size = new System.Drawing.Size(572, 288);
            this.IMTab.TabIndex = 1;
            this.IMTab.Text = "IM Clients";
            this.IMTab.UseVisualStyleBackColor = true;
            // 
            // OrganizationTab
            // 
            this.OrganizationTab.Location = new System.Drawing.Point(4, 22);
            this.OrganizationTab.Name = "OrganizationTab";
            this.OrganizationTab.Size = new System.Drawing.Size(572, 288);
            this.OrganizationTab.TabIndex = 2;
            this.OrganizationTab.Text = "Organizations";
            this.OrganizationTab.UseVisualStyleBackColor = true;
            // 
            // PhoneTab
            // 
            this.PhoneTab.Location = new System.Drawing.Point(4, 22);
            this.PhoneTab.Name = "PhoneTab";
            this.PhoneTab.Size = new System.Drawing.Size(572, 288);
            this.PhoneTab.TabIndex = 3;
            this.PhoneTab.Text = "Phone Numbers";
            this.PhoneTab.UseVisualStyleBackColor = true;
            // 
            // AddressesTab
            // 
            this.AddressesTab.Location = new System.Drawing.Point(4, 22);
            this.AddressesTab.Name = "AddressesTab";
            this.AddressesTab.Size = new System.Drawing.Size(572, 288);
            this.AddressesTab.TabIndex = 4;
            this.AddressesTab.Text = "Postal Addresses";
            this.AddressesTab.UseVisualStyleBackColor = true;
            // 
            // UserInfoGroupBox
            // 
            this.UserInfoGroupBox.Location = new System.Drawing.Point(4, 3);
            this.UserInfoGroupBox.Name = "UserInfoGroupBox";
            this.UserInfoGroupBox.Size = new System.Drawing.Size(572, 183);
            this.UserInfoGroupBox.TabIndex = 0;
            this.UserInfoGroupBox.TabStop = false;
            this.UserInfoGroupBox.Text = "User Information";
            // 
            // gcda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.MainSplitter);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "gcda";
            this.Text = "Google Contacts Desktop Application";
            this.Load += new System.EventHandler(this.gcda_Load);
            this.Shown += new System.EventHandler(this.gcda_Shown);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainSplitter.Panel1.ResumeLayout(false);
            this.MainSplitter.Panel2.ResumeLayout(false);
            this.MainSplitter.ResumeLayout(false);
            this.InformationSplitter.Panel1.ResumeLayout(false);
            this.InformationSplitter.Panel2.ResumeLayout(false);
            this.InformationSplitter.ResumeLayout(false);
            this.AttributesTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Seperator1;
        private System.Windows.Forms.ToolStripStatusLabel UserNameStatusLabel;
        private System.Windows.Forms.SplitContainer InformationSplitter;
        private System.Windows.Forms.TabControl AttributesTabControl;
        private System.Windows.Forms.TabPage EmailTab;
        private System.Windows.Forms.TabPage IMTab;
        private System.Windows.Forms.TabPage OrganizationTab;
        private System.Windows.Forms.GroupBox UserInfoGroupBox;
        private System.Windows.Forms.TabPage PhoneTab;
        private System.Windows.Forms.TabPage AddressesTab;
    }
}

