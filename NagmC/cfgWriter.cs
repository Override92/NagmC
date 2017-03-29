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

        public void writeHostOrServicegroupsFile(String filePath, String groupType, String groupName, String groupAlias, String[] groupMembers) {
            String cfgfile = "\\" + groupType.ToLower() + ".cfg";
            if (!File.Exists(filePath + cfgfile)) {
                using (FileStream filestream = new FileStream(filePath + cfgfile, FileMode.Append, FileAccess.Write))
                using (StreamWriter file = new StreamWriter(filestream)) {
                    writeCFGHostOrServicegroupDef(groupType, groupName, groupAlias, groupMembers);
                }
            }
        }

        private void writeCFGHostOrServicegroupDef(String groupType, String groupName, String groupAlias, String[] groupMembers) {
            String groupDef = "";
            groupDef += writeCfgServiceHostgroupsHeader(groupType);
            groupDef += "define " + groupType + "{\n";
            groupDef += "\thostgroup_name\t\t\t" + groupName + "\t\n";
            groupDef += "\talias\t\t\t" + groupAlias + "\t\n";
            groupDef += "\tmembers\t\t\t";
            foreach (String item in groupMembers) {
                groupDef += item + ",";
            }
            groupDef = groupDef.Remove(groupDef.Length - 1);
            groupDef += "\n\t}\n\n\n";
            Console.WriteLine(groupDef);
        }

        private String writeCfgServiceHostgroupsHeader(String group) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Config File for the Definition of " + group + "\n";
            header += "### This File was created by NagmC and should not be edited.\n";
            header += "### Created on " + getDateTime() + "\n";
            header += "###############################################################################\n";
            Console.WriteLine(header);
            return header;
        }

        private String writeCfgHeader(String hostname) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Config File for monitoring: " + hostname + "\n";
            header += "### This File was created by NagmC and should not be edited.\n";
            header += "### Created on " + getDateTime() + "\n";
            header += "###############################################################################\n";
            Console.WriteLine(header);
            return header;
        }

        private String writeCfgServiceDefHeader(String hostname) {
            String header = "";
            header += "###############################################################################\n";
            header += "### Service Definition\n";
            header += "### This File was created by NagmC and should not be edited.";
            header += "### Created on " + getDateTime() + "\n";
            header += "###############################################################################\n";
            Console.WriteLine(header);
            return header;
        }

        private String writeCfgHostDef(String hostname, String template, String alias, String address, String parentHost) {
            String hostDef = "";
            hostDef += "define host{\n";
            hostDef += "\tuse\t\t\t" + template + "\t\n";
            hostDef += "\thost_name\t\t\t" + hostname + "\t\n";
            hostDef += "\talias\t\t\t" + alias + "\t\n";
            hostDef += "\taddress\t\t\t" + address + "\t\n";
            hostDef += "\tparents\t\t\t" + parentHost + "\t\n";
            hostDef += "\t}\n\n\n";
            Console.WriteLine(hostDef);
            return hostDef;
        }

        private String writeCfgServiceDef() {
            String serviceDef = "";
            //TODO: create String
            return serviceDef;
        }

        private String getDateTime() {
            DateTime localDate = DateTime.Now;
            var locale = "de-DE";
            return localDate.ToString(locale);
        }
    }
}
