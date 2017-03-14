using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class QueryDepartmentResponse
    {
        public string resultCode { get; set; }

        public string resultContext { get; set; }

        public QueryDepartmentInfoList queryDepartmentInfoList { get; set; }
    }

    public class QueryDepartmentInfoList
    {
        public string amount { get; set; }

        public List<QueryDepartmentInfo> departmentInfoList { get; set; }

        public QueryParentDepartmentInfo parentDepartmentInfo { get; set; }
    }

    public class QueryDepartmentInfo
    {
        public string departmentId { get; set; }

        public string departmentNo { get; set; }

        public string departmentName { get; set; }
    }

    public class QueryParentDepartmentInfo
    {
        public string departmentId { get; set; }

        public string departmentNo { get; set; }

        public string departmentName { get; set; }
    }
}
