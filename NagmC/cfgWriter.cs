using System.IO;
using System;

namespace NagmC {
    class cfgWriter {

        public void writeHostFile(String hostname, String filePath) {
            if (!File.Exists(filePath + "\\" + hostname + ".cfg")) {
                using (FileStream filestream = new FileStream(filePath + "\\" + hostname + ".cfg",FileMode.Append, FileAccess.Write))
                using (StreamWriter file = new StreamWriter(filestream)) {
                    file.Write(writeCfgHeader(hostname));
                }
            }            
        }

        public void writeHostgroupsFile(String filePath, String hostgroupName, String hostgroupAlias, String[] hostgroupMembers) {
            if (!File.Exists(filePath + "\\hostgroups.cfg")) {
                using (FileStream filestream = new FileStream(filePath + "\\hostgroups.cfg", FileMode.Append, FileAccess.Write))
                using (StreamWriter file = new StreamWriter(filestream)) {
                    writeCFGHostgroupDef(hostgroupName, hostgroupAlias, hostgroupMembers);
                }
            }
        }

        private void writeCFGHostgroupDef(String hostgroupName, String hostgroupAlias, String[] hostgroupMembers) {
            String hostgroupDef = "";
            hostgroupDef += "define hostgroup {\n";
            hostgroupDef += "\thostgroup_name\t\t\t" + hostgroupName + "\t\n";
            hostgroupDef += "\talias\t\t\t" + hostgroupAlias + "\t\n";
            hostgroupDef += "\tmembers\t\t\t";
            foreach (String item in hostgroupMembers) {
                hostgroupDef += item + ",";
            }
            hostgroupDef = hostgroupDef.Remove(hostgroupDef.Length - 1);
            hostgroupDef += "\n\t}\n\n\n";
            Console.WriteLine(hostgroupDef);
        }

        private String writeCfgHeader(String hostname) {
            String header = "";
            header += "###############################################################################\n"; ;           
            header += "### Config File for monitoring: " + hostname + "\n";
            header += "###############################################################################\n";
            Console.WriteLine(header);
            return header;
        }

        private void writeCfgHostDefHeader(String hostname) {
            String header = ""; 
            header += "###############################################################################\n";
            header += "### Host Definition\n";
            header += "###############################################################################\n";
            Console.WriteLine(header);
        }

        private void writeCfgServiceDefHeader(String hostname) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Service Definition\n";
            header += "###############################################################################\n";
            Console.WriteLine(header);
        }

        private void writeCfgHostDef(String hostname, String template, String alias, String address, String hostgroups, String parentHost) {
            String hostDef = "";
            hostDef += "define host{\n";
            hostDef += "\tuse\t\t\t" + template + "\t\n";
            hostDef += "\thost_name\t\t\t" + hostname + "\t\n";
            hostDef += "\talias\t\t\t" + alias + "\t\n";
            hostDef += "\taddress\t\t\t" + address + "\t\n";
            hostDef += "\thostgroups\t\t\t" + hostgroups + "\t\n";
            hostDef += "\tparents\t\t\t" + parentHost + "\t\n";
            hostDef += "\t}\n\n\n";
            Console.WriteLine(hostDef);
        }

        private void writeCfgServiceDef() {

        }
    }
}
