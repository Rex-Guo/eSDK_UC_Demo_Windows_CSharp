using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class QueryAccountInfo
    {
        public string userId { get; set; }

        public string exactSearch { get; set; }

        public string condition { get; set; }

        public string pageCount { get; set; }

        public string pageNum { get; set; }
    }
}
