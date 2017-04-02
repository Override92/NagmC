using System;
using System.Windows.Forms;
using Renci.SshNet;

/*
 * FileName:    sshConnect.cs
 * Author:      Carsten Wittebrock
 */

namespace NagmC {
    class sshConnect {

        public void initConnection(String hostname, String username, String passwd, String startstoptest) {
            sshWriteCFG(hostname, username, passwd, startstoptest);
        }

        private void sshWriteCFG(String hostname, String username, String passwd, String startstoptest) {
            try {
                using (var sshClient = new SshClient(hostname, username, passwd)) {
                    if (startstoptest == "start" || startstoptest == "test") {
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
            } catch {
                //We got disconnected for some other reason
                Console.WriteLine("SSH-Connection - Failed");
                MessageBox.Show("SSH-Connection - Failed", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
