using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    public class DelConfInfo
    {
        public string userId { get; set; }

        public List<DeleteMeetingBaseParam> deleteItem { get; set; }
    }

    public class DeleteMeetingBaseParam
    {
        public string gwIp { get; set; }

        public string confId { get; set; }
    }
}
