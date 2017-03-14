using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class ECConstUri
    {
        //部门管理
        public static string department_uri = @"/esdk/rest/ec/bmu/department";

        //账号管理
        public static string account_uri = @"/esdk/rest/ec/bmu/account";

        //SIP号码管理
        public static string sip_uri = @"/esdk/rest/ec/bmu/sip";

        public static string delSip_uri = @"/esdk/rest/ec/bmu/sipcondition/delete_sip";

        public static string querySip_uri = @"/esdk/rest/ec/bmu/sipcondition/query_sip";

        //查询个人通讯录
        public static string address_uri = @"/esdk/rest/ec/appserver/address";
        
        //查询个人详情
        public static string person_info_uri = @"/esdk/rest/ec/appserver/person_info";
        
        //查询企业通讯录
        public static string enterprise_uri = @"/esdk/rest/ec/appserver/enterprise";
        
        //查询个人信息
        public static string employee_uri = @"/esdk/rest/ec/appserver/employee";
    }
}
