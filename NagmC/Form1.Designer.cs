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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("router1");
            this.objectControlTabs = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.serverSplitContainer = new System.Windows.Forms.SplitContainer();
            this.serverList = new System.Windows.Forms.ListView();
            this.serverPane = new System.Windows.Forms.Panel();
            this.routerTab = new System.Windows.Forms.TabPage();
            this.routerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.routerList = new System.Windows.Forms.ListView();
            this.routerPane = new System.Windows.Forms.Panel();
            this.switchTab = new System.Windows.Forms.TabPage();
            this.switchSplitContainer = new System.Windows.Forms.SplitContainer();
            this.switchList = new System.Windows.Forms.ListView();
            this.switchPane = new System.Windows.Forms.Panel();
            this.printerTab = new System.Windows.Forms.TabPage();
            this.printerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.printerList = new System.Windows.Forms.ListView();
            this.printerPane = new System.Windows.Forms.Panel();
            this.writeCFG = new System.Windows.Forms.Button();
            this.testCon = new System.Windows.Forms.Button();
            this.exitProg = new System.Windows.Forms.Button();
            this.addHost = new System.Windows.Forms.Button();
            this.objectControlTabs.SuspendLayout();
            this.serverTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverSplitContainer)).BeginInit();
            this.serverSplitContainer.Panel1.SuspendLayout();
            this.serverSplitContainer.Panel2.SuspendLayout();
            this.serverSplitContainer.SuspendLayout();
            this.routerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routerSplitContainer)).BeginInit();
            this.routerSplitContainer.Panel1.SuspendLayout();
            this.routerSplitContainer.Panel2.SuspendLayout();
            this.routerSplitContainer.SuspendLayout();
            this.switchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchSplitContainer)).BeginInit();
            this.switchSplitContainer.Panel1.SuspendLayout();
            this.switchSplitContainer.Panel2.SuspendLayout();
            this.switchSplitContainer.SuspendLayout();
            this.printerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printerSplitContainer)).BeginInit();
            this.printerSplitContainer.Panel1.SuspendLayout();
            this.printerSplitContainer.Panel2.SuspendLayout();
            this.printerSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectControlTabs
            // 
            this.objectControlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectControlTabs.Controls.Add(this.serverTab);
            this.objectControlTabs.Controls.Add(this.routerTab);
            this.objectControlTabs.Controls.Add(this.switchTab);
            this.objectControlTabs.Controls.Add(this.printerTab);
            this.objectControlTabs.Location = new System.Drawing.Point(0, 50);
            this.objectControlTabs.Margin = new System.Windows.Forms.Padding(2);
            this.objectControlTabs.Multiline = true;
            this.objectControlTabs.Name = "objectControlTabs";
            this.objectControlTabs.SelectedIndex = 0;
            this.objectControlTabs.Size = new System.Drawing.Size(970, 481);
            this.objectControlTabs.TabIndex = 0;
            // 
            // serverTab
            // 
            this.serverTab.Controls.Add(this.serverSplitContainer);
            this.serverTab.Location = new System.Drawing.Point(4, 22);
            this.serverTab.Margin = new System.Windows.Forms.Padding(2);
            this.serverTab.Name = "serverTab";
            this.serverTab.Padding = new System.Windows.Forms.Padding(2);
            this.serverTab.Size = new System.Drawing.Size(962, 455);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Servers";
            this.serverTab.UseVisualStyleBackColor = true;
            // 
            // serverSplitContainer
            // 
            this.serverSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverSplitContainer.Location = new System.Drawing.Point(2, 2);
            this.serverSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.serverSplitContainer.Name = "serverSplitContainer";
            // 
            // serverSplitContainer.Panel1
            // 
            this.serverSplitContainer.Panel1.Controls.Add(this.serverList);
            this.serverSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.serverSplitContainer_Panel1_Paint);
            // 
            // serverSplitContainer.Panel2
            // 
            this.serverSplitContainer.Panel2.Controls.Add(this.serverPane);
            this.serverSplitContainer.Size = new System.Drawing.Size(958, 451);
            this.serverSplitContainer.SplitterDistance = 200;
            this.serverSplitContainer.SplitterWidth = 1;
            this.serverSplitContainer.TabIndex = 0;
            // 
            // serverList
            // 
            this.serverList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverList.Location = new System.Drawing.Point(0, 0);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(196, 447);
            this.serverList.TabIndex = 0;
            this.serverList.UseCompatibleStateImageBehavior = false;
            // 
            // serverPane
            // 
            this.serverPane.BackColor = System.Drawing.Color.LightGray;
            this.serverPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverPane.Location = new System.Drawing.Point(0, 0);
            this.serverPane.Name = "serverPane";
            this.serverPane.Size = new System.Drawing.Size(753, 447);
            this.serverPane.TabIndex = 0;
            // 
            // routerTab
            // 
            this.routerTab.Controls.Add(this.routerSplitContainer);
            this.routerTab.Location = new System.Drawing.Point(4, 22);
            this.routerTab.Margin = new System.Windows.Forms.Padding(2);
            this.routerTab.Name = "routerTab";
            this.routerTab.Padding = new System.Windows.Forms.Padding(2);
            this.routerTab.Size = new System.Drawing.Size(962, 455);
            this.routerTab.TabIndex = 1;
            this.routerTab.Text = "Routers";
            this.routerTab.UseVisualStyleBackColor = true;
            // 
            // routerSplitContainer
            // 
            this.routerSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.routerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routerSplitContainer.Location = new System.Drawing.Point(2, 2);
            this.routerSplitContainer.Name = "routerSplitContainer";
            // 
            // routerSplitContainer.Panel1
            // 
            this.routerSplitContainer.Panel1.Controls.Add(this.routerList);
            // 
            // routerSplitContainer.Panel2
            // 
            this.routerSplitContainer.Panel2.Controls.Add(this.routerPane);
            this.routerSplitContainer.Size = new System.Drawing.Size(958, 451);
            this.routerSplitContainer.SplitterDistance = 200;
            this.routerSplitContainer.SplitterWidth = 1;
            this.routerSplitContainer.TabIndex = 0;
            // 
            // routerList
            // 
            this.routerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.routerList.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewItem5.StateImageIndex = 0;
            this.routerList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.routerList.Location = new System.Drawing.Point(0, 0);
            this.routerList.Name = "routerList";
            this.routerList.Size = new System.Drawing.Size(196, 447);
            this.routerList.TabIndex = 0;
            this.routerList.UseCompatibleStateImageBehavior = false;
            // 
            // routerPane
            // 
            this.routerPane.BackColor = System.Drawing.Color.LightGray;
            this.routerPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routerPane.Location = new System.Drawing.Point(0, 0);
            this.routerPane.Name = "routerPane";
            this.routerPane.Size = new System.Drawing.Size(753, 447);
            this.routerPane.TabIndex = 0;
            // 
            // switchTab
            // 
            this.switchTab.Controls.Add(this.switchSplitContainer);
            this.switchTab.Location = new System.Drawing.Point(4, 22);
            this.switchTab.Margin = new System.Windows.Forms.Padding(2);
            this.switchTab.Name = "switchTab";
            this.switchTab.Padding = new System.Windows.Forms.Padding(2);
            this.switchTab.Size = new System.Drawing.Size(962, 455);
            this.switchTab.TabIndex = 2;
            this.switchTab.Text = "Switches";
            this.switchTab.UseVisualStyleBackColor = true;
            // 
            // switchSplitContainer
            // 
            this.switchSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.switchSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchSplitContainer.Location = new System.Drawing.Point(2, 2);
            this.switchSplitContainer.Name = "switchSplitContainer";
            // 
            // switchSplitContainer.Panel1
            // 
            this.switchSplitContainer.Panel1.Controls.Add(this.switchList);
            // 
            // switchSplitContainer.Panel2
            // 
            this.switchSplitContainer.Panel2.Controls.Add(this.switchPane);
            this.switchSplitContainer.Size = new System.Drawing.Size(958, 451);
            this.switchSplitContainer.SplitterDistance = 200;
            this.switchSplitContainer.SplitterWidth = 1;
            this.switchSplitContainer.TabIndex = 0;
            // 
            // switchList
            // 
            this.switchList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.switchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchList.Location = new System.Drawing.Point(0, 0);
            this.switchList.Name = "switchList";
            this.switchList.Size = new System.Drawing.Size(196, 447);
            this.switchList.TabIndex = 0;
            this.switchList.UseCompatibleStateImageBehavior = false;
            // 
            // switchPane
            // 
            this.switchPane.BackColor = System.Drawing.Color.LightGray;
            this.switchPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchPane.Location = new System.Drawing.Point(0, 0);
            this.switchPane.Name = "switchPane";
            this.switchPane.Size = new System.Drawing.Size(753, 447);
            this.switchPane.TabIndex = 0;
            // 
            // printerTab
            // 
            this.printerTab.Controls.Add(this.printerSplitContainer);
            this.printerTab.Location = new System.Drawing.Point(4, 22);
            this.printerTab.Margin = new System.Windows.Forms.Padding(2);
            this.printerTab.Name = "printerTab";
            this.printerTab.Padding = new System.Windows.Forms.Padding(2);
            this.printerTab.Size = new System.Drawing.Size(962, 455);
            this.printerTab.TabIndex = 3;
            this.printerTab.Text = "Printers";
            this.printerTab.UseVisualStyleBackColor = true;
            // 
            // printerSplitContainer
            // 
            this.printerSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerSplitContainer.Location = new System.Drawing.Point(2, 2);
            this.printerSplitContainer.Name = "printerSplitContainer";
            // 
            // printerSplitContainer.Panel1
            // 
            this.printerSplitContainer.Panel1.Controls.Add(this.printerList);
            // 
            // printerSplitContainer.Panel2
            // 
            this.printerSplitContainer.Panel2.Controls.Add(this.printerPane);
            this.printerSplitContainer.Size = new System.Drawing.Size(958, 451);
            this.printerSplitContainer.SplitterDistance = 200;
            this.printerSplitContainer.SplitterWidth = 1;
            this.printerSplitContainer.TabIndex = 0;
            // 
            // printerList
            // 
            this.printerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.printerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerList.Location = new System.Drawing.Point(0, 0);
            this.printerList.Name = "printerList";
            this.printerList.Size = new System.Drawing.Size(196, 447);
            this.printerList.TabIndex = 0;
            this.printerList.UseCompatibleStateImageBehavior = false;
            // 
            // printerPane
            // 
            this.printerPane.BackColor = System.Drawing.Color.LightGray;
            this.printerPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerPane.Location = new System.Drawing.Point(0, 0);
            this.printerPane.Name = "printerPane";
            this.printerPane.Size = new System.Drawing.Size(753, 447);
            this.printerPane.TabIndex = 0;
            // 
            // writeCFG
            // 
            this.writeCFG.Location = new System.Drawing.Point(9, 11);
            this.writeCFG.Margin = new System.Windows.Forms.Padding(2);
            this.writeCFG.Name = "writeCFG";
            this.writeCFG.Size = new System.Drawing.Size(56, 34);
            this.writeCFG.TabIndex = 1;
            this.writeCFG.UseVisualStyleBackColor = true;
            this.writeCFG.Click += new System.EventHandler(this.writeCFG_Click);
            // 
            // testCon
            // 
            this.testCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCon.Location = new System.Drawing.Point(69, 11);
            this.testCon.Margin = new System.Windows.Forms.Padding(2);
            this.testCon.Name = "testCon";
            this.testCon.Size = new System.Drawing.Size(34, 34);
            this.testCon.TabIndex = 2;
            this.testCon.UseVisualStyleBackColor = true;
            this.testCon.Click += new System.EventHandler(this.testCon_Click);
            // 
            // exitProg
            // 
            this.exitProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitProg.Location = new System.Drawing.Point(904, 11);
            this.exitProg.Margin = new System.Windows.Forms.Padding(2);
            this.exitProg.Name = "exitProg";
            this.exitProg.Size = new System.Drawing.Size(56, 34);
            this.exitProg.TabIndex = 3;
            this.exitProg.Text = "Exit";
            this.exitProg.UseVisualStyleBackColor = true;
            this.exitProg.Click += new System.EventHandler(this.exitProg_Click);
            // 
            // addHost
            // 
            this.addHost.Location = new System.Drawing.Point(107, 11);
            this.addHost.Margin = new System.Windows.Forms.Padding(2);
            this.addHost.Name = "addHost";
            this.addHost.Size = new System.Drawing.Size(50, 34);
            this.addHost.TabIndex = 4;
            this.addHost.UseVisualStyleBackColor = true;
            this.addHost.Click += new System.EventHandler(this.addHost_Click);
            // 
            // NagmC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 531);
            this.Controls.Add(this.addHost);
            this.Controls.Add(this.exitProg);
            this.Controls.Add(this.testCon);
            this.Controls.Add(this.writeCFG);
            this.Controls.Add(this.objectControlTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NagmC";
            this.Text = "NagmC";
            this.Load += new System.EventHandler(this.NagmC_Load);
            this.objectControlTabs.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.serverSplitContainer.Panel1.ResumeLayout(false);
            this.serverSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverSplitContainer)).EndInit();
            this.serverSplitContainer.ResumeLayout(false);
            this.routerTab.ResumeLayout(false);
            this.routerSplitContainer.Panel1.ResumeLayout(false);
            this.routerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routerSplitContainer)).EndInit();
            this.routerSplitContainer.ResumeLayout(false);
            this.switchTab.ResumeLayout(false);
            this.switchSplitContainer.Panel1.ResumeLayout(false);
            this.switchSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.switchSplitContainer)).EndInit();
            this.switchSplitContainer.ResumeLayout(false);
            this.printerTab.ResumeLayout(false);
            this.printerSplitContainer.Panel1.ResumeLayout(false);
            this.printerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printerSplitContainer)).EndInit();
            this.printerSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage serverTab;
        private System.Windows.Forms.TabPage routerTab;
        private System.Windows.Forms.TabPage switchTab;
        private System.Windows.Forms.TabPage printerTab;
        private System.Windows.Forms.Button writeCFG;
        private System.Windows.Forms.Button testCon;
        private System.Windows.Forms.TabControl objectControlTabs;
        private System.Windows.Forms.SplitContainer serverSplitContainer;
        private System.Windows.Forms.Button exitProg;
        private System.Windows.Forms.Button addHost;
        private System.Windows.Forms.Panel routerPane;
        private System.Windows.Forms.SplitContainer routerSplitContainer;
        private System.Windows.Forms.ListView routerList;
        private System.Windows.Forms.ListView serverList;
        private System.Windows.Forms.Panel serverPane;
        private System.Windows.Forms.SplitContainer switchSplitContainer;
        private System.Windows.Forms.ListView switchList;
        private System.Windows.Forms.Panel switchPane;
        private System.Windows.Forms.SplitContainer printerSplitContainer;
        private System.Windows.Forms.ListView printerList;
        private System.Windows.Forms.Panel printerPane;
    }
}

