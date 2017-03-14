using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_CTDDemo_Windows_CSharp
{
    public class CTDCallInfo
    {
        //操作者EC账号
        public string account { get; set; }
        
        //主叫号码
        public string caller { get; set; }
        
        //被叫号码
        public string callee { get; set; }
    }
}
