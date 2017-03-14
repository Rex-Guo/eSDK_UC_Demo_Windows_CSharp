using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_CTDDemo_Windows_CSharp
{
    public class ECBusiness
    {
        /// <summary>
        /// 发送公告
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse affiche(afficheInfo info)
        {
            CommentResponse result = eSDKServiceHelper.affiche(info);
            return result;
        }
        
        /// <summary>
        /// 点击呼叫
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse ctdCall(CTDCallInfo info)
        {
            CommentResponse result = eSDKServiceHelper.ctdCall(info);
            return result;
        }
    }
}
