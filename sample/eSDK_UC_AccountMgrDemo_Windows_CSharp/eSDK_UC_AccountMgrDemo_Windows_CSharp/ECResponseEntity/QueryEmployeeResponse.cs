using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class QueryEmployeeResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public EmployeeList employeeList { get; set; }
    }

    public class EmployeeList
    {
        public string total { get; set; }

        public string sum { get; set; }

        public List<PersonInfoEx2> employees { get; set; }
    }

    public class PersonInfoEx2
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
        public string bindNum { get; set; }
        public string shortPhone { get; set; }
        public string officePhone { get; set; }
        public string credit { get; set; }
        public string signature { get; set; }
        public string voip { get; set; }
        public string otherPhone { get; set; }
        public string addr { get; set; }
        public string zip { get; set; }
        public string seat { get; set; }
    }
}
