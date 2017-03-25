using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace NagmC {
    public partial class NagmC : Form {
        public NagmC() {
            InitializeComponent();                        
        }

        public static String appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public String serverDir = appdata + "\\NagmC\\objects\\server";
        public String routerDir = appdata + "\\NagmC\\objects\\router";
        public String switchDir = appdata + "\\NagmC\\objects\\switch";
        public String printerDir = appdata + "\\NagmC\\objects\\printer";

        private void exitProg_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addHost_Click(object sender, EventArgs e) {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 175;
            prompt.Text = "Hostwizard";
            Label textLabel = new Label() { Left = 48, Top = 20, Width = 100, Text = "Hostname:" };
            TextBox wizHost = new TextBox() { Left = 50, Top = 45, Width = 200 };
            Button confirmation = new Button() { Text = "Continue", Left = 150, Width = 100, Top = 70 };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(wizHost);
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.ShowDialog();                    
        }

        private void wizardStepTwo(Object sender, EventArgs e) {

        }

        private void sshWriteCFG(String hostname, String username, String passwd, String startstoptest)
        {
            try
            {
                using (var sshClient = new SshClient(hostname, username, passwd))
                {
                    if(startstoptest == "start" || startstoptest == "test") {
                        sshClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(10);
                        sshClient.Connect();
                        Console.WriteLine("SSH-Connection - Success");
                        if (startstoptest == "test") {
                            MessageBox.Show("SSH-Connection - Success", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (startstoptest == "stop" || startstoptest == "test") {
                        sshClient.Disconnect();
                        sshClient.Dispose();
                    }                    
                }
            } catch
            {
                //We got disconnected for some other reason
                Console.WriteLine("SSH-Connection - Failed");
                MessageBox.Show("SSH-Connection - Failed", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void testCon_Click(object sender, EventArgs e) {
            String hostname="", username="", passwd="";
            sshWriteCFG(hostname,username,passwd,"test");
        }

        private void serverSplitContainer_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void NagmC_Load(object sender, EventArgs e) {            
            this.writeCFG.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\src\\writecfg.png").GetThumbnailImage(50, 50, null, IntPtr.Zero);            
            this.testCon.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\src\\testconnection.png").GetThumbnailImage(45, 45, null, IntPtr.Zero);
            this.addHost.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\src\\addhost.png").GetThumbnailImage(50, 50, null, IntPtr.Zero);
            ToolTip writeCFGToolTip = new System.Windows.Forms.ToolTip();
            writeCFGToolTip.SetToolTip(writeCFG, "Write CFG-Files to Nagios-Server");
            ToolTip testConToolTip = new System.Windows.Forms.ToolTip();
            writeCFGToolTip.SetToolTip(testCon, "Test SSH-Connection to Nagios-Server");
            ToolTip addHostToolTip = new System.Windows.Forms.ToolTip();
            writeCFGToolTip.SetToolTip(addHost, "Add new Host");

            createDirStructure();
            initScan();
        }

        private void initScan() {
            DirectoryInfo serverPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\server");
            scanObjects(serverPath);
            DirectoryInfo routerPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\router");
            scanObjects(routerPath);
            DirectoryInfo switchPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\switch");
            scanObjects(switchPath);
            DirectoryInfo printerPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\printer");
            scanObjects(printerPath);
        }

        private void createDirStructure() {            
            String nagmcDir = appdata + "\\NagmC";
            String objectDir = appdata + "\\NagmC\\objects";            

            if (!Directory.Exists(nagmcDir)) {
                Directory.CreateDirectory(nagmcDir);
                Console.WriteLine(nagmcDir + " created");
            }
            if (!Directory.Exists(objectDir)) {
                Directory.CreateDirectory(objectDir);
                Console.WriteLine(objectDir + " created");
            }
            if (!Directory.Exists(serverDir)) {
                Directory.CreateDirectory(serverDir);
                Console.WriteLine(serverDir + " created");
            }
            if (!Directory.Exists(routerDir)) {
                Directory.CreateDirectory(routerDir);
                Console.WriteLine(routerDir + " created");
            }
            if (!Directory.Exists(switchDir)) {
                Directory.CreateDirectory(switchDir);
                Console.WriteLine(switchDir + " created");
            }
            if (!Directory.Exists(printerDir)) {
                Directory.CreateDirectory(printerDir);
                Console.WriteLine(printerDir + " created");
            }
        }

        private void scanObjects(DirectoryInfo objectPath) {                        
            FileInfo[] Files = objectPath.GetFiles("*.cfg");
            foreach(FileInfo host in Files) {
                //int counter = 0;
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(objectPath + "\\" + host.ToString());
                while ((line = file.ReadLine()) != null) {
                    Console.WriteLine(line);
                    //counter++;
                }
                file.Close();
            }
        }
        //DirectoryInfo routerPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NagmC\\objects\\router");        

        private void writeCFG_Click(object sender, EventArgs e) {
            String hostname = "", username = "", passwd = "";
            sshWriteCFG(hostname, username, passwd, "start");
            /*  Insert upload to Nagiosserver-function here
             *  Insert copy to libexec folder here
             */
            sshWriteCFG("null","null","null","stop");
        }        
    }
}
