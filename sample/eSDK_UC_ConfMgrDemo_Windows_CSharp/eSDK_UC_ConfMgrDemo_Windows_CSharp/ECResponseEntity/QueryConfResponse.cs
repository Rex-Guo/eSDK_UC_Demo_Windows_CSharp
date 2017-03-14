using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    public class QueryConfResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public QueryMeetingInfoList queryMeetingInfoList { get; set; }
    }

    public class QueryMeetingInfoList
    {
        public string amount { get; set; }

        public List<MeetingInfo> meetingInfoList { get; set; }
    }

    public class MeetingInfo
    {
        public string gwIp { get; set; }
        public string confId { get; set; }
        public string enterPrompt { get; set; }
        public string leavePrompt { get; set; }
        public string amount { get; set; }
        public string guestPwd { get; set; }
        public string chairmanPwd { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string confMode { get; set; }
        public string recordFlag { get; set; }
        public string confName { get; set; }
        public string srtpMode { get; set; }
        public string confPrefix { get; set; }
    }
}
