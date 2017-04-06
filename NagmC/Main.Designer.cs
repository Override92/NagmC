namespace NagmC {
    partial class NagmC {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NagmC));
            this.objectControlTabs = new System.Windows.Forms.TabControl();
            this.hostTab = new System.Windows.Forms.TabPage();
            this.serverSplitContainer = new System.Windows.Forms.SplitContainer();
            this.hostList = new System.Windows.Forms.ListView();
            this.hostPane = new System.Windows.Forms.Panel();
            this.templateBox = new System.Windows.Forms.ComboBox();
            this.hostAddressBox = new System.Windows.Forms.MaskedTextBox();
            this.parentHostBox = new System.Windows.Forms.TextBox();
            this.parentHostLbl = new System.Windows.Forms.Label();
            this.hostAddressLbl = new System.Windows.Forms.Label();
            this.aliasBox = new System.Windows.Forms.TextBox();
            this.aliasLbl = new System.Windows.Forms.Label();
            this.hostnameBox = new System.Windows.Forms.TextBox();
            this.hostnameLbl = new System.Windows.Forms.Label();
            this.templateLbl = new System.Windows.Forms.Label();
            this.saveServerBtn = new System.Windows.Forms.Button();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.hostServiceGroupsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.writeCFG = new System.Windows.Forms.Button();
            this.testCon = new System.Windows.Forms.Button();
            this.exitProg = new System.Windows.Forms.Button();
            this.addHost = new System.Windows.Forms.Button();
            this.scanProgress = new System.Windows.Forms.ProgressBar();
            this.hostnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastChangedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hostTypeLbl = new System.Windows.Forms.Label();
            this.hostTypeCBox = new System.Windows.Forms.ComboBox();
            this.objectControlTabs.SuspendLayout();
            this.hostTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverSplitContainer)).BeginInit();
            this.serverSplitContainer.Panel1.SuspendLayout();
            this.serverSplitContainer.Panel2.SuspendLayout();
            this.serverSplitContainer.SuspendLayout();
            this.hostPane.SuspendLayout();
            this.groupsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostServiceGroupsSplitContainer)).BeginInit();
            this.hostServiceGroupsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectControlTabs
            // 
            this.objectControlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectControlTabs.Controls.Add(this.hostTab);
            this.objectControlTabs.Controls.Add(this.groupsTab);
            this.objectControlTabs.Location = new System.Drawing.Point(0, 71);
            this.objectControlTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectControlTabs.Multiline = true;
            this.objectControlTabs.Name = "objectControlTabs";
            this.objectControlTabs.SelectedIndex = 0;
            this.objectControlTabs.Size = new System.Drawing.Size(1293, 501);
            this.objectControlTabs.TabIndex = 0;
            // 
            // hostTab
            // 
            this.hostTab.Controls.Add(this.serverSplitContainer);
            this.hostTab.Location = new System.Drawing.Point(4, 25);
            this.hostTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hostTab.Name = "hostTab";
            this.hostTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hostTab.Size = new System.Drawing.Size(1285, 472);
            this.hostTab.TabIndex = 0;
            this.hostTab.Text = "Hosts";
            this.hostTab.UseVisualStyleBackColor = true;
            // 
            // serverSplitContainer
            // 
            this.serverSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverSplitContainer.Location = new System.Drawing.Point(3, 2);
            this.serverSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverSplitContainer.Name = "serverSplitContainer";
            // 
            // serverSplitContainer.Panel1
            // 
            this.serverSplitContainer.Panel1.Controls.Add(this.hostList);
            this.serverSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.serverSplitContainer_Panel1_Paint);
            // 
            // serverSplitContainer.Panel2
            // 
            this.serverSplitContainer.Panel2.Controls.Add(this.hostPane);
            this.serverSplitContainer.Size = new System.Drawing.Size(1279, 468);
            this.serverSplitContainer.SplitterDistance = 267;
            this.serverSplitContainer.SplitterWidth = 1;
            this.serverSplitContainer.TabIndex = 0;
            // 
            // hostList
            // 
            this.hostList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hostnameHeader,
            this.lastChangedHeader});
            this.hostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostList.Location = new System.Drawing.Point(0, 0);
            this.hostList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostList.Name = "hostList";
            this.hostList.Size = new System.Drawing.Size(263, 464);
            this.hostList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.hostList.TabIndex = 0;
            this.hostList.UseCompatibleStateImageBehavior = false;
            this.hostList.View = System.Windows.Forms.View.Details;
            // 
            // hostPane
            // 
            this.hostPane.BackColor = System.Drawing.Color.LightGray;
            this.hostPane.Controls.Add(this.hostTypeCBox);
            this.hostPane.Controls.Add(this.hostTypeLbl);
            this.hostPane.Controls.Add(this.templateBox);
            this.hostPane.Controls.Add(this.hostAddressBox);
            this.hostPane.Controls.Add(this.parentHostBox);
            this.hostPane.Controls.Add(this.parentHostLbl);
            this.hostPane.Controls.Add(this.hostAddressLbl);
            this.hostPane.Controls.Add(this.aliasBox);
            this.hostPane.Controls.Add(this.aliasLbl);
            this.hostPane.Controls.Add(this.hostnameBox);
            this.hostPane.Controls.Add(this.hostnameLbl);
            this.hostPane.Controls.Add(this.templateLbl);
            this.hostPane.Controls.Add(this.saveServerBtn);
            this.hostPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPane.Location = new System.Drawing.Point(0, 0);
            this.hostPane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostPane.Name = "hostPane";
            this.hostPane.Size = new System.Drawing.Size(1007, 464);
            this.hostPane.TabIndex = 0;
            // 
            // templateBox
            // 
            this.templateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateBox.FormattingEnabled = true;
            this.templateBox.Location = new System.Drawing.Point(104, 4);
            this.templateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(259, 24);
            this.templateBox.TabIndex = 23;
            // 
            // hostAddressBox
            // 
            this.hostAddressBox.Location = new System.Drawing.Point(104, 177);
            this.hostAddressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostAddressBox.Mask = "###.###.###.###";
            this.hostAddressBox.Name = "hostAddressBox";
            this.hostAddressBox.Size = new System.Drawing.Size(259, 22);
            this.hostAddressBox.TabIndex = 22;
            // 
            // parentHostBox
            // 
            this.parentHostBox.Location = new System.Drawing.Point(104, 217);
            this.parentHostBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parentHostBox.Name = "parentHostBox";
            this.parentHostBox.Size = new System.Drawing.Size(259, 22);
            this.parentHostBox.TabIndex = 21;
            // 
            // parentHostLbl
            // 
            this.parentHostLbl.AutoSize = true;
            this.parentHostLbl.Location = new System.Drawing.Point(4, 221);
            this.parentHostLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parentHostLbl.Name = "parentHostLbl";
            this.parentHostLbl.Size = new System.Drawing.Size(87, 17);
            this.parentHostLbl.TabIndex = 20;
            this.parentHostLbl.Text = "Parent Host:";
            // 
            // hostAddressLbl
            // 
            this.hostAddressLbl.AutoSize = true;
            this.hostAddressLbl.Location = new System.Drawing.Point(4, 180);
            this.hostAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostAddressLbl.Name = "hostAddressLbl";
            this.hostAddressLbl.Size = new System.Drawing.Size(92, 17);
            this.hostAddressLbl.TabIndex = 18;
            this.hostAddressLbl.Text = "Hostaddress:";
            // 
            // aliasBox
            // 
            this.aliasBox.Location = new System.Drawing.Point(104, 134);
            this.aliasBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aliasBox.Name = "aliasBox";
            this.aliasBox.Size = new System.Drawing.Size(259, 22);
            this.aliasBox.TabIndex = 17;
            // 
            // aliasLbl
            // 
            this.aliasLbl.AutoSize = true;
            this.aliasLbl.Location = new System.Drawing.Point(4, 137);
            this.aliasLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aliasLbl.Name = "aliasLbl";
            this.aliasLbl.Size = new System.Drawing.Size(42, 17);
            this.aliasLbl.TabIndex = 16;
            this.aliasLbl.Text = "Alias:";
            // 
            // hostnameBox
            // 
            this.hostnameBox.Location = new System.Drawing.Point(104, 91);
            this.hostnameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostnameBox.Name = "hostnameBox";
            this.hostnameBox.Size = new System.Drawing.Size(259, 22);
            this.hostnameBox.TabIndex = 15;
            // 
            // hostnameLbl
            // 
            this.hostnameLbl.AutoSize = true;
            this.hostnameLbl.Location = new System.Drawing.Point(4, 94);
            this.hostnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostnameLbl.Name = "hostnameLbl";
            this.hostnameLbl.Size = new System.Drawing.Size(76, 17);
            this.hostnameLbl.TabIndex = 14;
            this.hostnameLbl.Text = "Hostname:";
            // 
            // templateLbl
            // 
            this.templateLbl.AutoSize = true;
            this.templateLbl.Location = new System.Drawing.Point(4, 7);
            this.templateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.templateLbl.Name = "templateLbl";
            this.templateLbl.Size = new System.Drawing.Size(71, 17);
            this.templateLbl.TabIndex = 12;
            this.templateLbl.Text = "Template:";
            // 
            // saveServerBtn
            // 
            this.saveServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveServerBtn.Location = new System.Drawing.Point(902, 432);
            this.saveServerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveServerBtn.Name = "saveServerBtn";
            this.saveServerBtn.Size = new System.Drawing.Size(100, 28);
            this.saveServerBtn.TabIndex = 0;
            this.saveServerBtn.Text = "Save";
            this.saveServerBtn.UseVisualStyleBackColor = true;
            // 
            // groupsTab
            // 
            this.groupsTab.Controls.Add(this.hostServiceGroupsSplitContainer);
            this.groupsTab.Location = new System.Drawing.Point(4, 25);
            this.groupsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Size = new System.Drawing.Size(1285, 472);
            this.groupsTab.TabIndex = 4;
            this.groupsTab.Text = "Hostgroups & Servicegroups";
            this.groupsTab.UseVisualStyleBackColor = true;
            // 
            // hostServiceGroupsSplitContainer
            // 
            this.hostServiceGroupsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hostServiceGroupsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostServiceGroupsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.hostServiceGroupsSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostServiceGroupsSplitContainer.Name = "hostServiceGroupsSplitContainer";
            this.hostServiceGroupsSplitContainer.Panel1MinSize = 475;
            this.hostServiceGroupsSplitContainer.Panel2MinSize = 475;
            this.hostServiceGroupsSplitContainer.Size = new System.Drawing.Size(1285, 472);
            this.hostServiceGroupsSplitContainer.SplitterDistance = 639;
            this.hostServiceGroupsSplitContainer.SplitterWidth = 1;
            this.hostServiceGroupsSplitContainer.TabIndex = 0;
            // 
            // writeCFG
            // 
            this.writeCFG.Location = new System.Drawing.Point(12, 14);
            this.writeCFG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writeCFG.Name = "writeCFG";
            this.writeCFG.Size = new System.Drawing.Size(75, 53);
            this.writeCFG.TabIndex = 1;
            this.writeCFG.UseVisualStyleBackColor = true;
            this.writeCFG.Click += new System.EventHandler(this.writeCFG_Click);
            // 
            // testCon
            // 
            this.testCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCon.Location = new System.Drawing.Point(92, 14);
            this.testCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testCon.Name = "testCon";
            this.testCon.Size = new System.Drawing.Size(75, 53);
            this.testCon.TabIndex = 2;
            this.testCon.UseVisualStyleBackColor = true;
            this.testCon.Click += new System.EventHandler(this.testCon_Click);
            // 
            // exitProg
            // 
            this.exitProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitProg.Location = new System.Drawing.Point(1205, 14);
            this.exitProg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitProg.Name = "exitProg";
            this.exitProg.Size = new System.Drawing.Size(75, 53);
            this.exitProg.TabIndex = 3;
            this.exitProg.Text = "Exit";
            this.exitProg.UseVisualStyleBackColor = true;
            this.exitProg.Click += new System.EventHandler(this.exitProg_Click);
            // 
            // addHost
            // 
            this.addHost.Location = new System.Drawing.Point(172, 14);
            this.addHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addHost.Name = "addHost";
            this.addHost.Size = new System.Drawing.Size(75, 53);
            this.addHost.TabIndex = 4;
            this.addHost.UseVisualStyleBackColor = true;
            this.addHost.Click += new System.EventHandler(this.addHost_Click);
            // 
            // scanProgress
            // 
            this.scanProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanProgress.Location = new System.Drawing.Point(5, 570);
            this.scanProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(1283, 11);
            this.scanProgress.Step = 1;
            this.scanProgress.TabIndex = 5;
            // 
            // hostnameHeader
            // 
            this.hostnameHeader.Text = "Hostname";
            this.hostnameHeader.Width = 150;
            // 
            // lastChangedHeader
            // 
            this.lastChangedHeader.Text = "Last Changed";
            this.lastChangedHeader.Width = 120;
            // 
            // hostTypeLbl
            // 
            this.hostTypeLbl.AutoSize = true;
            this.hostTypeLbl.Location = new System.Drawing.Point(4, 49);
            this.hostTypeLbl.Name = "hostTypeLbl";
            this.hostTypeLbl.Size = new System.Drawing.Size(64, 17);
            this.hostTypeLbl.TabIndex = 24;
            this.hostTypeLbl.Text = "Hosttype";
            // 
            // hostTypeCBox
            // 
            this.hostTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostTypeCBox.FormattingEnabled = true;
            this.hostTypeCBox.Items.AddRange(new object[] {
            "Server",
            "Switch",
            "Router",
            "Printer"});
            this.hostTypeCBox.Location = new System.Drawing.Point(104, 46);
            this.hostTypeCBox.Name = "hostTypeCBox";
            this.hostTypeCBox.Size = new System.Drawing.Size(259, 24);
            this.hostTypeCBox.TabIndex = 25;
            // 
            // NagmC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 586);
            this.Controls.Add(this.scanProgress);
            this.Controls.Add(this.addHost);
            this.Controls.Add(this.exitProg);
            this.Controls.Add(this.testCon);
            this.Controls.Add(this.writeCFG);
            this.Controls.Add(this.objectControlTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NagmC";
            this.Text = "NagmC";
            this.Load += new System.EventHandler(this.NagmC_Load);
            this.Shown += new System.EventHandler(this.NagmC_Shown);
            this.objectControlTabs.ResumeLayout(false);
            this.hostTab.ResumeLayout(false);
            this.serverSplitContainer.Panel1.ResumeLayout(false);
            this.serverSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverSplitContainer)).EndInit();
            this.serverSplitContainer.ResumeLayout(false);
            this.hostPane.ResumeLayout(false);
            this.hostPane.PerformLayout();
            this.groupsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hostServiceGroupsSplitContainer)).EndInit();
            this.hostServiceGroupsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage hostTab;
        private System.Windows.Forms.Button writeCFG;
        private System.Windows.Forms.Button testCon;
        private System.Windows.Forms.TabControl objectControlTabs;
        private System.Windows.Forms.SplitContainer serverSplitContainer;
        private System.Windows.Forms.Button exitProg;
        private System.Windows.Forms.Button addHost;
        private System.Windows.Forms.ListView hostList;
        private System.Windows.Forms.Panel hostPane;
        private System.Windows.Forms.ProgressBar scanProgress;
        private System.Windows.Forms.TabPage groupsTab;
        private System.Windows.Forms.SplitContainer hostServiceGroupsSplitContainer;
        private System.Windows.Forms.Button saveServerBtn;
        private System.Windows.Forms.TextBox parentHostBox;
        private System.Windows.Forms.Label parentHostLbl;
        private System.Windows.Forms.Label hostAddressLbl;
        private System.Windows.Forms.TextBox aliasBox;
        private System.Windows.Forms.Label aliasLbl;
        private System.Windows.Forms.TextBox hostnameBox;
        private System.Windows.Forms.Label hostnameLbl;
        private System.Windows.Forms.Label templateLbl;
        private System.Windows.Forms.MaskedTextBox hostAddressBox;
        private System.Windows.Forms.ComboBox templateBox;
        private System.Windows.Forms.ColumnHeader hostnameHeader;
        private System.Windows.Forms.ColumnHeader lastChangedHeader;
        private System.Windows.Forms.ComboBox hostTypeCBox;
        private System.Windows.Forms.Label hostTypeLbl;
    }
}

