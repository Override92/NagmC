using System.IO;
using System;

/*
 * FileName:    cfgWriter.cs
 * Author:      Carsten Wittebrock
 */

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

        private String writeCfgServiceDef(String hostname, String hostgroupName, String serviceDescr, String displayname,
                                          Boolean isVolatile, String checkCommand, String initState, int maxCheckAttempts,
                                          int checkInterval, int retryInterval, Boolean activeChecksEnabled, Boolean passiveChecksEnabled,
                                          String checkPeriod, Boolean obsessOverService, Boolean checkFreshness, int freshnessThreshold,
                                          String eventHandler, Boolean eventHandlerEnabled, int lowFlapTheshold, int highFlapThreshold,
                                          Boolean flapDetectionEnabled, String flapDetectionOptions, Boolean processPerfData,
                                          Boolean retainStatusInformation, Boolean retainNonStatusInformation, int notificationInterval,
                                          int firstNotificationDelay, String notificationPeriod, String notificationOptions,
                                          Boolean notificationEnabled, String contacts, String contactGroups, String stalkingOptions,
                                          String notes, String notesURL, String actionURL) {
            String serviceDef = "";
            serviceDef += "define service\n";
            serviceDef += "\t\t\t" + hostname + "\n";
            serviceDef += "\t\t\t" + hostgroupName + "\n";
            serviceDef += "\t\t\t" + serviceDescr + "\n";
            serviceDef += "\t\t\t" + displayname + "\n";
            serviceDef += "\t\t\t" + isVolatile.ToString() + "\n";
            serviceDef += "\t\t\t" + checkCommand + "\n";
            serviceDef += "\t\t\t" + initState + "\n";
            serviceDef += "\t\t\t" + maxCheckAttempts.ToString() + "\n";
            serviceDef += "\t\t\t" + checkInterval.ToString() + "\n";
            serviceDef += "\t\t\t" + retryInterval.ToString() + "\n";
            serviceDef += "\t\t\t" + activeChecksEnabled.ToString() + "\n";
            serviceDef += "\t\t\t" + passiveChecksEnabled.ToString() + "\n";
            serviceDef += "\t\t\t" + checkPeriod + "\n";
            serviceDef += "\t\t\t" + obsessOverService.ToString() + "\n";
            serviceDef += "\t\t\t" + checkFreshness.ToString() + "\n";
            serviceDef += "\t\t\t" + freshnessThreshold.ToString() + "\n";
            serviceDef += "\t\t\t" + eventHandler + "\n";
            serviceDef += "\t\t\t" + eventHandlerEnabled.ToString() + "\n";
            serviceDef += "\t\t\t" + lowFlapTheshold.ToString() + "\n";
            serviceDef += "\t\t\t" + highFlapThreshold.ToString() + "\n";
            serviceDef += "\t\t\t" + flapDetectionEnabled.ToString() + "\n";
            serviceDef += "\t\t\t" + flapDetectionOptions + "\n";
            serviceDef += "\t\t\t" + processPerfData.ToString() + "\n";
            serviceDef += "\t\t\t" + retainStatusInformation.ToString() + "\n";
            serviceDef += "\t\t\t" + retainNonStatusInformation.ToString() + "\n";
            serviceDef += "\t\t\t" + notificationInterval.ToString() + "\n";
            serviceDef += "\t\t\t" + firstNotificationDelay.ToString() + "\n";
            serviceDef += "\t\t\t" + notificationPeriod + "\n";
            serviceDef += "\t\t\t" + notificationOptions + "\n";
            serviceDef += "\t\t\t" + notificationEnabled.ToString();
            serviceDef += "\t\t\t" + contacts + "\n";
            serviceDef += "\t\t\t" + contactGroups + "\n";
            serviceDef += "\t\t\t" + stalkingOptions + "\n";
            serviceDef += "\t\t\t" + notes + "\n";
            serviceDef += "\t\t\t" + notesURL + "\n";
            serviceDef += "\t\t\t" + actionURL + "\n";
            serviceDef += "\t}\n\n\n";
            return serviceDef;
        }

        private String getDateTime() {
            DateTime localDate = DateTime.Now;
            var locale = "de-DE";
            return localDate.ToString(locale);
        }
    }
}
