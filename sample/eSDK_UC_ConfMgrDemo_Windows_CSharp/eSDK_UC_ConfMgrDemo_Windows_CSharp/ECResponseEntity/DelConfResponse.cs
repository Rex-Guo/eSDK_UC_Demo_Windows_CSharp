using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    public class DelConfResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public List<DeleteMeetingParam> result { get; set; }
    }

    public class DeleteMeetingParam
    {
        public string gwIp { get; set; }

        public string confId { get; set; }

        public string subPbx { get; set; }
    }
}
