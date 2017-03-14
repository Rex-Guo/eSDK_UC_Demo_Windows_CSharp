using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    public class ECBusiness
    {
        /// <summary>
        /// 预约会议
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public AddConfResponse AddConf(AddConfInfo info)
        {
            AddConfResponse result = eSDKServiceHelper.addConf(info);
            return result;
        }

        /// <summary>
        /// 修改会议
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse EditConf(EditConfInfo info)
        {
            CommentResponse result = eSDKServiceHelper.editConf(info);
            return result;
        }

        /// <summary>
        /// 删除会议
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public DelConfResponse DelConf(DelConfInfo info)
        {
            DelConfResponse result = eSDKServiceHelper.delConf(info);
            return result;
        }

        /// <summary>
        /// 查询会议列表
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryConfResponse QueryConfList(QueryConfList info)
        {
            QueryConfResponse result = eSDKServiceHelper.queryConfList(info);
            return result;
        }

        /// <summary>
        /// 添加会议成员
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse AddConfMember(AddConfMemberInfo info)
        {
            CommentResponse result = eSDKServiceHelper.addConfMember(info);
            return result;
        }
    }
}
