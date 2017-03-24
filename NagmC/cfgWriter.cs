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
            hostDefpart = "         use                 " + template + "\n";
            hostDef += hostDefpart;
            hostDefpart = "         host_name           " + hostname + "\n";
            hostDef += hostDefpart;
            hostDefpart = "         alias               " + alias + "\n";
            hostDef += hostDefpart;
            hostDefpart = "         address             " + address + "\n";
            hostDef += hostDefpart;
            hostDefpart = "         hostgroups          " + hostgroups + "\n";
            hostDef += hostDefpart;
            hostDefpart = "         }\n\n\n";
            hostDef += hostDefpart;
            Console.WriteLine(hostDef);
        }
    }
}
