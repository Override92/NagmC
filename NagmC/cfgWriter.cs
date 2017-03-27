using System;

namespace NagmC {
    class cfgWriter {

        private void writeCfgHeader(String hostname) {
            String header = "", headerpart = "";
            headerpart = "###############################################################################\n";
            header += headerpart;
            headerpart = "### Config File for monitoring: " + hostname + "\n";
            header += headerpart;
            headerpart = "################################################################################\n";
            header += headerpart;
            Console.WriteLine(header);
        }

        private void writeCfgHostDefHeader(String hostname) {
            String header = "", headerpart = "";
            headerpart = "###############################################################################\n";
            header += headerpart;
            headerpart = "### Host Definition\n";
            header += headerpart;
            headerpart = "################################################################################\n";
            header += headerpart;
            Console.WriteLine(header);
        }

        private void writeCfgHostGroupsDefHeader(String hostname) {
            String header = "", headerpart = "";
            headerpart = "###############################################################################\n";
            header += headerpart;
            headerpart = "### Hostgroups Definition\n";
            header += headerpart;
            headerpart = "################################################################################\n";
            header += headerpart;
            Console.WriteLine(header);
        }

        private void writeCfgServiceDefHeader(String hostname) {
            String header = "", headerpart = "";
            headerpart = "###############################################################################\n";
            header += headerpart;
            headerpart = "### Service Definition\n";
            header += headerpart;
            headerpart = "################################################################################\n";
            header += headerpart;
            Console.WriteLine(header);
        }

        private void writeCfgHostDef(String hostname, String template, String alias, String address, String hostgroups, String parentHost) {
            String hostDef = "", hostDefpart = "";
            hostDefpart = "define host{\n";
            hostDef += hostDefpart;
            hostDefpart = "\tuse\t\t\t" + template + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "\thost_name\t\t\t" + hostname + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "\talias\t\t\t" + alias + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "\taddress\t\t\t" + address + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "\thostgroups\t\t\t" + hostgroups + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "\tparents\t\t\t" + parentHost + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "\t}\n\n\n";
            hostDef += hostDefpart;
            Console.WriteLine(hostDef);
        }

        private void writeCfgHostGroupsDef(String hostgroupname, String hostgroupalias) {
            String hostDef = "", hostDefpart = "";
            hostDefpart = "define hostgroup {\n";          
            hostDef += hostDefpart;
            hostDefpart = "         hostgroup_name\t\t\t" + hostgroupname + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         alias\t\t\t" + hostgroupalias + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         }\n\n\n";
            hostDef += hostDefpart;
            Console.WriteLine(hostDef);
        }

        private void writeCfgServiceDef() {

        }
    }
}
