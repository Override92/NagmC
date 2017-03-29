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

        public void writeServicegroupsFile(String filePath, String servicegroupName, String servicegroupAlias, String[] servicegroupMembers) {
            if (!File.Exists(filePath + "\\hostgroups.cfg")) {
                using (FileStream filestream = new FileStream(filePath + "\\hostgroups.cfg", FileMode.Append, FileAccess.Write))
                using (StreamWriter file = new StreamWriter(filestream)) {
                    writeCFGServicegroupDef(servicegroupName, servicegroupAlias, servicegroupMembers);
                }
            }
        }

        private void writeCFGHostgroupDef(String hostgroupName, String hostgroupAlias, String[] hostgroupMembers) {
            String hostgroupDef = "";
            hostgroupDef += writeCfgServiceHostgroupsHeader("Hostgroups");
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

        private void writeCFGServicegroupDef(String servicegroupName, String servicegroupAlias, String[] servicegroupMembers) {
            String servicegroupDef = "";
            servicegroupDef += writeCfgServiceHostgroupsHeader("Servicegroups");
            servicegroupDef += "define hostgroup {\n";
            servicegroupDef += "\thostgroup_name\t\t\t" + servicegroupName + "\t\n";
            servicegroupDef += "\talias\t\t\t" + servicegroupAlias + "\t\n";
            servicegroupDef += "\tmembers\t\t\t";
            foreach (String item in servicegroupMembers) {
                servicegroupDef += item + ",";
            }
            servicegroupDef = servicegroupDef.Remove(servicegroupDef.Length - 1);
            servicegroupDef += "\n\t}\n\n\n";
            Console.WriteLine(servicegroupDef);
        }

        private String writeCfgServiceHostgroupsHeader(String group) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Config File for the Definition of " + group + "\n";
            header += "### This File was created by NagmC and should not be edited.";
            header += "### Created on " + getDateTime();
            header += "###############################################################################\n";
            Console.WriteLine(header);
            return header;
        }

        private String writeCfgHeader(String hostname) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Config File for monitoring: " + hostname + "\n";
            header += "### This File was created by NagmC and should not be edited.";
            header += "### Created on " + getDateTime();
            header += "###############################################################################\n";
            Console.WriteLine(header);
            return header;
        }

        private void writeCfgHostDefHeader(String hostname) {
            String header = ""; 
            header += "###############################################################################\n";
            header += "### Host Definition\n";
            header += "### This File was created by NagmC and should not be edited.";
            header += "### Created on " + getDateTime();
            header += "###############################################################################\n";
            Console.WriteLine(header);
        }

        private void writeCfgServiceDefHeader(String hostname) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Service Definition\n";
            header += "### This File was created by NagmC and should not be edited.";
            header += "### Created on " + getDateTime();
            header += "###############################################################################\n";
            Console.WriteLine(header);
        }

        private void writeCfgHostDef(String hostname, String template, String alias, String address, String parentHost) {
            String hostDef = "";
            hostDef += "define host{\n";
            hostDef += "\tuse\t\t\t" + template + "\t\n";
            hostDef += "\thost_name\t\t\t" + hostname + "\t\n";
            hostDef += "\talias\t\t\t" + alias + "\t\n";
            hostDef += "\taddress\t\t\t" + address + "\t\n";
            hostDef += "\tparents\t\t\t" + parentHost + "\t\n";
            hostDef += "\t}\n\n\n";
            Console.WriteLine(hostDef);
        }

        private void writeCfgServiceDef() {

        }

        private String getDateTime() {
            DateTime localDate = DateTime.Now;
            var locale = "de-DE";
            return localDate.ToString(locale);
        }
    }
}
