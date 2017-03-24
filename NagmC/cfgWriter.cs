using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagmC {
    class cfgWriter {

        private void writeCfgHeader(String hostname) {
            String header = "", headerpart = "";
            headerpart = "###############################################################################\n";
            header += headerpart;
            headerpart = "### Config File for monitoring: " + hostname + " ###\n";
            header += headerpart;
            headerpart = "################################################################################\n";
            header += headerpart;
            Console.WriteLine(header);
        }

        private void writeCfgHostDef(String hostname, String template, String alias, String address, String hostgroups) {
            String hostDef = "", hostDefpart = "";
            hostDefpart = "define host{\n";
            hostDef += hostDefpart;
            hostDefpart = "         use\t\t\t" + template + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         host_name\t\t\t" + hostname + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         alias\t\t\t" + alias + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         address\t\t\t" + address + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         hostgroups\t\t\t" + hostgroups + "\t\n";
            hostDef += hostDefpart;
            hostDefpart = "         }\n\n\n";
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
    }
}
