using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class AddAccountInfo
    {
        public string userId { get; set; }

        public AddAccount account { get; set; }
    }
    
    public class AddAccount
    {
        //账号类型
        public string accountType { get; set; }
        //登入名
        public string loginName { get; set; }
        //登入密码
        public string password { get; set; }
        //用户姓名
        public string name { get; set; }

        //public string sex { get; set; }

        //public string homePhone { get; set; }

        //public string cellPhone { get; set; }

        //public string officePhone { get; set; }

        //public string shortPhone { get; set; }

        //public string otherPhone { get; set; }

        //public string fax { get; set; }

        //public string email { get; set; }

        //public string addr { get; set; }

        //public string title { get; set; }
        
        //EC账号归属部门ID
        public string departmentId { get; set; }
        //EC账号关联的用户级别ID
        public string userLevel { get; set; }
        //EC账号关联的用户角色ID
        public string roleId { get; set; }

        //public string otherPhone2 { get; set; }

        //public string zip { get; set; }

        //public string staffNum { get; set; }

        //public string foreignName { get; set; }

        public string userState { get; set; }

        //public string notesMail { get; set; }

        //public string birthday { get; set; }

        //public string des { get; set; }

        //public string website { get; set; }
    }
}
