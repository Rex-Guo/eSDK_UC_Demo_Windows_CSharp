using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public class ECBusiness
    {
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public DepartmentResponse AddDepartment(DepartmentInfo info)
        {
            DepartmentResponse result = eSDKServiceHelper.addDepartment(info);
            return result;
        }
        
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse EditDepartment(DepartmentInfo info)
        {
            CommentResponse result = eSDKServiceHelper.editDepartment(info);
            return result;
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse DelDepartment(DelDepartmentInfo info)
        {
            CommentResponse result = eSDKServiceHelper.delDepartment(info);
            return result;
        }

        /// <summary>
        /// 查询部门
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryDepartmentResponse QueryDepartment(QyDepartmentInfo info)
        {
            QueryDepartmentResponse result = eSDKServiceHelper.queryDepartment(info);
            return result;
        }

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public AddAcountResponse AddAccount(AddAccountInfo info)
        {
            AddAcountResponse result = eSDKServiceHelper.addAccount(info);
            return result;
        }

        /// <summary>
        /// 修改账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse EditAccount(EditAccountInfo info)
        {
            CommentResponse result = eSDKServiceHelper.editAccount(info);
            return result;
        }

        /// <summary>
        /// 删除账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse DelAccount(DelAccountInfo info)
        {
            CommentResponse result = eSDKServiceHelper.delAccount(info);
            return result;
        }

        /// <summary>
        /// 查询账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryAccountResponse QueryAccount(QueryAccountInfo info)
        {
            QueryAccountResponse result = eSDKServiceHelper.queryAccount(info);
            return result;
        }

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse AddSipNumber(AddSIPInfo info)
        {
            CommentResponse result = eSDKServiceHelper.addSipNumber(info);
            return result;
        }

        /// <summary>
        /// 修改账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse EditSipNumber(AddSIPInfo info)
        {
            CommentResponse result = eSDKServiceHelper.editSipNumber(info);
            return result;
        }

        /// <summary>
        /// 删除账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommentResponse DelSipNumber(DelSipNumber info)
        {
            CommentResponse result = eSDKServiceHelper.delSipNumber(info);
            return result;
        }

        /// <summary>
        /// 查询账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QuerySipResponse QuerySipNumber(QuerySipInfoList info)
        {
            QuerySipResponse result = eSDKServiceHelper.querySipNumber(info);
            return result;
        }

        /// <summary>
        /// 查询个人通讯录户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryAddressResponse QueryAddress(QueryAddressInfo info)
        {
            QueryAddressResponse result = eSDKServiceHelper.queryAddress(info);
            return result;
        }

        /// <summary>
        /// 查询个人详情
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryPersonInfoResponse QueryPersonInfo(string staffAccount)
        {
            QueryPersonInfoResponse result = eSDKServiceHelper.queryPersonInfo(staffAccount);
            return result;
        }

        /// <summary>
        /// 查询企业通讯录
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryEnterpriseResponse QueryEnterprise(QueryEnterprise info)
        {
            QueryEnterpriseResponse result = eSDKServiceHelper.queryEnterprise(info);
            return result;
        }

        /// <summary>
        /// 查询账户
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public QueryEmployeeResponse QueryEmployee(QueryEmployee info)
        {
            QueryEmployeeResponse result = eSDKServiceHelper.queryEmployee(info);
            return result;
        }
    }
}
