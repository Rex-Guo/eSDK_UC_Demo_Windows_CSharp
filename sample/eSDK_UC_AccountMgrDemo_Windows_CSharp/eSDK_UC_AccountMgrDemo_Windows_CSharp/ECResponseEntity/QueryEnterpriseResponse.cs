using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class QueryEnterpriseResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public EnterpriseList enterpriseList { get; set; }
    }

    public class EnterpriseList
    {
        public string total { get; set; }
        public string deptSum { get; set; }
        public string employeeSum { get; set; }
        public string parentDept { get; set; }
        public List<DepartmentInfoEx> departments { get; set; }
        public List<PersonInfoEx> employees { get; set; }
    }

    public class DepartmentInfoEx
    {
        public string deptId { get; set; }
        public string deptName { get; set; }
        public string subDeptCount { get; set; }
        public string subEmployeeCount { get; set; }
    }

    public class PersonInfoEx
    {
        public string staffId { get; set; }
        public string name { get; set; }
        public string staffAccount { get; set; }
        public string staffNO { get; set; }
        public string sex { get; set; }
        public string mobile { get; set; }
        public string homePhone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string bindNo { get; set; }
        public string shortPhone { get; set; }
        public string officePhone { get; set; }                   
    }
}
