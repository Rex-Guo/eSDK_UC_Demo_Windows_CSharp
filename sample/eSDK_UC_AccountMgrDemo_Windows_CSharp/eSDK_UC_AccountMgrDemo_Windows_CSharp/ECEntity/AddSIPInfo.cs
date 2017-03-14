using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class AddSIPInfo
    {
        public string userId { get; set; }

        public SIPAccount sip { get; set; }
    }

    public class SIPAccount
    {
        public string gwIp { get; set; }

        public string subPbx { get; set; }

        public string localGwIp { get; set; }

        public string joint { get; set; }

        public string sipUe { get; set; }

        public string ueType { get; set; }

        public string number { get; set; }

        public string longNum { get; set; }

        public string rightLevel { get; set; }

        public string addPrefix { get; set; }

        public SIPAuth sipAuth { get; set; }

        public string bOutgoingRights { get; set; }

        public string cOutgoingRights { get; set; }

        public UsmSip usmSip { get; set; }
    }

    public class SIPAuth
    {
        public string type { get; set; }

        public string password { get; set; }

        public string ip { get; set; }
    }

    public class UsmSip
    {
        public string stationGroupName { get; set; }

        public string sipServerId { get; set; }

        public string localGwName { get; set; }

        public string isSyncLocalGw { get; set; }

        public string sourceCode { get; set; }

        public string mrGroupName { get; set; }

        public string crgName { get; set; }

        public string domainName { get; set; }
    }
}
