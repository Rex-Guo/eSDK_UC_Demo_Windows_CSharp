using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    public class EcConstUri
    {
        //预约会议（修改）
        public static string ctc_uri = @"/esdk/rest/ec/bmu/ctc";

        //删除会议
        public static string delete_ctc_uri = @"/esdk/rest/ec/bmu/batch_delete_ctc";

        //查询会议列表
        public static string query_ctc_uri = @"/esdk/rest/ec/bmu/batch_query_ctc";

        //添加与会人数
        public static string attendee_uri = @"/esdk/rest/ec/bmu/attendee";
    }
}
