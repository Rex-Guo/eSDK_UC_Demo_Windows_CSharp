using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class QueryAddressResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public AddressList addressList { get; set; }
    }

    public class AddressList
    {
        public string total { get; set; }

        public string sum { get; set; }

        public List<Address> addresses  { get; set; }
    }

    public class Address
    {
        public string memberid { get; set; }
        public string name { get; set; }
        public string staffAccount { get; set; }
        public string sex { get; set; }
        public string mobile { get; set; }
        public string homephone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string bindno { get; set; }
        public string shortphone { get; set; }
        public string officephone { get; set; }

    }
}
