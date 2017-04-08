using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

/*
 * FileName:    Main.cs
 * Author:      Carsten Wittebrock
 * Credits to:  David Dähne for AppLogo
 */

namespace NagmC {
    public partial class NagmC : Form {
        public NagmC() {
            InitializeComponent();                        
        }

        public static String appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public String serverDir = appdata + "\\NagmC\\objects\\servers";
        public String routerDir = appdata + "\\NagmC\\objects\\routers";
        public String switchDir = appdata + "\\NagmC\\objects\\switches";
        public String printerDir = appdata + "\\NagmC\\objects\\printers";
        cfgWriter cfgwriter = new cfgWriter();
        sshConnect sshconnect = new sshConnect();

        private void exitProg_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addHost_Click(object sender, EventArgs e) {
            String hosttype = promptDialogHostType();
            String hostname = promptDialogHostName();
            if(hostname != "") { //TODO: Do not add when already exist
                createHostItem(hosttype, hostname);
            }            
        }
        
        private void createHostItem(String hosttype, String hostname) {
            switch (hosttype) {
                case "":
                case "Server":
                    addToList("servers",hostname);
                    cfgwriter.writeHostFile(hostname, serverDir);
                    break;
                case "Switch":
                    addToList("switches",hostname);
                    cfgwriter.writeHostFile(hostname, switchDir);
                    break;
                case "Router":
                    addToList("routers",hostname);
                    cfgwriter.writeHostFile(hostname, routerDir);
                    break;
                case "Printer":
                    addToList("printers",hostname);
                    cfgwriter.writeHostFile(hostname, printerDir);
                    break;
            }
        }

        private static String promptDialogHostName() {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 175;
            prompt.Text = "Hostwizard";
            Label hostLabel = new Label() { Left = 48, Top = 20, Width = 100, Text = "Hostname:" };
            TextBox hostnameBox = new TextBox() { Left = 50, Top = 45, Width = 200 };
            Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 70 };
            //confirmation.Enabled = false; add function for text in textbox != null
            confirmation.Click += (sender, e) => {prompt.Close();};
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(hostLabel);
            prompt.Controls.Add(hostnameBox);
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.ShowDialog();
            return hostnameBox.Text;
        }

        private static String promptDialogHostType() {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 175;
            prompt.Text = "Hostwizard";
            Label objectLabel = new Label() { Left = 48, Top = 20, Width = 100, Text = "Hosttyp:" };
            ComboBox hostObject = new ComboBox() { Left = 50, Top = 45, Width = 200 };
            hostObject.Items.Add("Printer");
            hostObject.Items.Add("Router");
            hostObject.Items.Add("Server");
            hostObject.Items.Add("Switch");
            hostObject.SelectedItem = "Server";
            hostObject.DropDownStyle = ComboBoxStyle.DropDownList;
            Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => {prompt.Close();};
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(objectLabel);            
            prompt.Controls.Add(hostObject);
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.ShowDialog();            
            return hostObject.SelectedItem.ToString();
        }                

        private void testCon_Click(object sender, EventArgs e) {
            String hostname="", username="", passwd="";
            sshconnect.initConnection(hostname,username,passwd,"test");
        }

        private void writeCFG_Click(object sender, EventArgs e) {
            String hostname = "", username = "", passwd = "";
            sshconnect.initConnection(hostname, username, passwd, "start");            
            sshconnect.initConnection("null", "null", "null", "stop");
            hostname = ""; username = ""; passwd = "";
        }

        private void serverSplitContainer_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void NagmC_Load(object sender, EventArgs e) {                        
            ToolTip writeCFGToolTip = new System.Windows.Forms.ToolTip();
            writeCFGToolTip.SetToolTip(writeCFG, "Write CFG-Files to Nagios-Server");
            ToolTip testConToolTip = new System.Windows.Forms.ToolTip();
            writeCFGToolTip.SetToolTip(testCon, "Test SSH-Connection to Nagios-Server");
            ToolTip addHostToolTip = new System.Windows.Forms.ToolTip();
            writeCFGToolTip.SetToolTip(addHost, "Add new Host");
            //hostTypeCBox.SelectedIndex = 0;

            String nagmcDir = appdata + "\\NagmC";
            String objectDir = appdata + "\\NagmC\\objects";
            String hostsDir = appdata + "\\NagmC\\objects\\hosts";
            createDirStructure(nagmcDir);
            createDirStructure(objectDir);
            createDirStructure(hostsDir);
            createDirStructure(serverDir);
            createDirStructure(routerDir);
            createDirStructure(switchDir);
            createDirStructure(printerDir);
        }

        private void createDirStructure(String dirToCreate) {
            if (!Directory.Exists(dirToCreate)) {
                Directory.CreateDirectory(dirToCreate);
                Console.WriteLine(dirToCreate + " created");
            }            
        }

        private void initScan() {
            Int32 fileCount = 0;            
            DirectoryInfo serverPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\servers");
            fileCount = countFiles(serverPath);
            scanObjects(serverPath, fileCount);
            DirectoryInfo routerPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\routers");
            fileCount = countFiles(routerPath);
            scanObjects(routerPath, fileCount);
            DirectoryInfo switchPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\switches");
            fileCount = countFiles(switchPath);
            scanObjects(switchPath, fileCount);
            DirectoryInfo printerPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\printers");
            fileCount = countFiles(printerPath);
            scanObjects(printerPath, fileCount);
        }

        private Int32 countFiles(DirectoryInfo pathToCount) {
            Int32 fileCount = 0;
            FileInfo[] Files = pathToCount.GetFiles("*.cfg");
            foreach (FileInfo cfg in Files) {
                fileCount++;                
            }
            return fileCount;
        }

        private void scanObjects(DirectoryInfo objectPath, Int32 fileCount) {
            //serverList.Enabled = false; routerList.Enabled = false; switchList.Enabled = false; printerList.Enabled = false;
            FileInfo[] Files = objectPath.GetFiles("*.cfg");
            if (fileCount == 0) {
                scanProgress.Step = 100;
            } else {
                scanProgress.Maximum = fileCount;
                scanProgress.Step = 1;
            }
            
            foreach (FileInfo host in Files) {
                string line;
                addToList(objectPath.ToString(), host.ToString());
                
                StreamReader file = new StreamReader(objectPath + "\\" + host.ToString());
                while ((line = file.ReadLine()) != null) {
                    //Nothing to do yet
                }
                file.Close();
                Console.WriteLine(host + " scanned");
                scanProgress.PerformStep();
            }
            scanProgress.Value = 0;
            //serverList.Enabled = true; routerList.Enabled = true; switchList.Enabled = true; printerList.Enabled = true;
        }     
        
        private void addToList(String objectPath, String hostname) {
            if (objectPath.Contains("printers")) {
                    hostList.Items.Add(new ListViewItem(new string[] { hostname.Replace(".cfg", ""), File.GetLastWriteTime(objectPath + "\\" + hostname).ToString()}));
                    hostList.Sorting = SortOrder.Ascending;
            } else if (objectPath.Contains("routers")) {
                    hostList.Items.Add(new ListViewItem(new string[] { hostname.Replace(".cfg", ""), File.GetLastWriteTime(objectPath + "\\" + hostname).ToString() }));
                    hostList.Sorting = SortOrder.Ascending;
            } else if (objectPath.Contains("switches")) {
                    hostList.Items.Add(new ListViewItem(new string[] { hostname.Replace(".cfg", ""), File.GetLastWriteTime(objectPath + "\\" + hostname).ToString() }));
                    hostList.Sorting = SortOrder.Ascending;
            } else if (objectPath.Contains("servers")) {
                    hostList.Items.Add(new ListViewItem(new string[] { hostname.Replace(".cfg", ""), File.GetLastWriteTime(objectPath + "\\" + hostname).ToString() }));
                    hostList.Sorting = SortOrder.Ascending;              
            } else {
                Console.WriteLine("Cannot place object from " + objectPath);
            }
        }       

        private void NagmC_Shown(object sender, EventArgs e) {
            this.writeCFG.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\src\\writecfg.png").GetThumbnailImage(50, 50, null, IntPtr.Zero);
            this.testCon.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\src\\testconnection.png").GetThumbnailImage(45, 45, null, IntPtr.Zero);
            this.addHost.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\src\\addhost.png").GetThumbnailImage(50, 50, null, IntPtr.Zero);
            this.Refresh();
            initScan();           
        }
    }
}
