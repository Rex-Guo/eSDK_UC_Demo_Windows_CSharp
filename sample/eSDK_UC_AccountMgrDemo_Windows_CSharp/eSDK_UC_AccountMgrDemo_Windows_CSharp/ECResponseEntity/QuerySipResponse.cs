using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class QuerySipResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public SIPList siplist { get; set; }
    }

    public class SIPList
    {
        public string amount { get; set; }

        public List<SIPAccount> sips { get; set; }
    }
}
