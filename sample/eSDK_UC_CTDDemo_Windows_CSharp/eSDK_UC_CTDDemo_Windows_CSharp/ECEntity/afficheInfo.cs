using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_CTDDemo_Windows_CSharp
{
    public class afficheInfo
    {
        //公告主题
        public string afficheTitle { get; set; }

        //公告内容
        public string afficheContent { get; set; }

        //公告发送方式
        public string receiverType { get; set; }

        //EC账号
        public List<string> staffAccounts { get; set; }

        //部门ID
        public List<string> departmentIds { get; set; }
    }

}
