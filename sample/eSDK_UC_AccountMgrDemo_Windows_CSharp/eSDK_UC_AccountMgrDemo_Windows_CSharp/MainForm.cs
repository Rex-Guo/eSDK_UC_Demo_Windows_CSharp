using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eSDK_UC_AccountMgrDemo_Windows_CSharp
{
    public partial class MainForm : Form
    {
        private ECBusiness ecBusiness;
        
        public MainForm()
        {
            InitializeComponent();

            ecBusiness = new ECBusiness();
            //鉴权参数
            eSDKServiceHelper.baseUri = this.txt_Uri.Text.Trim();
            eSDKServiceHelper.passWord = this.txt_pw5.Text.Trim();
            eSDKServiceHelper.userName = this.txt_UserName.Text.Trim();
        }

        private void WriteLog(string message)
        {
            if (this.txt_log.InvokeRequired)
            {
                Action<string> d = new Action<string>(this.WriteLog);
                d.Invoke(message);
            }
            else
            {
                this.txt_log.AppendText(DateTime.Now.ToString() + ": " + message + "\r\n");
            }
        }

        private void txtConfig_TextChanged(object sender, EventArgs e)
        {
            eSDKServiceHelper.baseUri = this.txt_Uri.Text.Trim();
            eSDKServiceHelper.passWord = this.txt_pw5.Text.Trim();
            eSDKServiceHelper.userName = this.txt_UserName.Text.Trim();
        }

        //添加部门
        private void btn_addDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentInfo _info = new DepartmentInfo();
                _info.userId = this.txt_Account.Text.Trim();
                _info.departmentName = this.txt_departmentName.Text.Trim();
                _info.parentId = this.txt_parentId.Text.Trim();
                _info.departmentId = this.txt_departmentId.Text.Trim();

                DepartmentResponse result = ecBusiness.AddDepartment(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call add department success.");
                    }
                    else
                    {
                        this.WriteLog("call add department failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call add department fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call add department fail," + ex.Message);
            }
        }

        //修改部门
        private void btn_editDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentInfo _info = new DepartmentInfo();
                _info.userId = this.txt_Account.Text.Trim();
                _info.departmentName = this.txt_departmentName.Text.Trim();
                _info.parentId = this.txt_parentId.Text.Trim();
                _info.departmentId = this.txt_departmentId.Text.Trim();

                CommentResponse result = ecBusiness.EditDepartment(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call edit department success.");
                    }
                    else
                    {
                        this.WriteLog("call edit department failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call edit department fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call edit department fail," + ex.Message);
            }
        }

        //删除部门
        private void btn_delDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                DelDepartmentInfo _info = new DelDepartmentInfo();
                _info.userId = this.txt_Account.Text.Trim();
                _info.departmentId = this.txt_departmentId.Text.Trim();

                CommentResponse result = ecBusiness.DelDepartment(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call del department success.");
                    }
                    else
                    {
                        this.WriteLog("call del department failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call del department fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call del department fail," + ex.Message);
            }
        }

        //查询部门
        private void btn_queryDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                QyDepartmentInfo _info = new QyDepartmentInfo();
                _info.userId = this.txt_Account.Text.Trim();
                _info.parentId = this.txt_parentId.Text.Trim();
                _info.pageCount = this.txt_dpPageCount.Text.Trim();
                _info.pageNum = this.txt_dpPageNum.Text.Trim();

                QueryDepartmentResponse result = ecBusiness.QueryDepartment(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query department success.");
                    }
                    else
                    {
                        this.WriteLog("call query department failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query department fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query department fail," + ex.Message);
            }
        }

        //添加账户
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                AddAccountInfo _info = new AddAccountInfo();
                _info.userId = this.txt_AccountId.Text.Trim();               
                AddAccount addAccount = new AddAccount();
                addAccount.accountType = this.cbx_accountType.Text.Trim();
                addAccount.loginName = this.txt_loginName.Text.Trim();
                addAccount.password = this.txt_loginPw5.Text.Trim();
                addAccount.name = this.txt_accountName.Text.Trim();
                addAccount.roleId = this.txt_roleId.Text.Trim();
                addAccount.userLevel = this.txt_levelId.Text.Trim();
                addAccount.userState = this.cbx_accountState.Text.Trim();
                addAccount.departmentId = this.txt_dpId.Text.Trim();                
                _info.account = addAccount;

                AddAcountResponse result = ecBusiness.AddAccount(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call add account success.");
                    }
                    else
                    {
                        this.WriteLog("call add account failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call add account fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call add account fail," + ex.Message);
            }
        }

        //修改账户
        private void btn_editAccount_Click(object sender, EventArgs e)
        {
            try
            {
                EditAccountInfo _info = new EditAccountInfo();
                _info.userId = this.txt_AccountId.Text.Trim();
                EditAccount editAccount = new EditAccount();
                editAccount.accountType = this.cbx_accountType.Text.Trim();
                editAccount.accountId = this.txt_accountIdEx.Text.Trim();
                editAccount.name = this.txt_accountName.Text.Trim();
                editAccount.roleId = this.txt_roleId.Text.Trim();
                editAccount.userLevel = this.txt_levelId.Text.Trim();
                editAccount.departmentId = this.txt_dpId.Text.Trim();
                editAccount.addr = "asdfaf";
                editAccount.cellPhone = "13911111111";
                editAccount.email = "asdf@huawei.com";
                editAccount.fax = "33333333";
                editAccount.homePhone = "051211111111";
                editAccount.officePhone = "051266666666";
                editAccount.otherPhone = "123123123";
                editAccount.sex = "1";
                editAccount.shortPhone = "051295552";
                editAccount.title = "software engineer";
                _info.account = editAccount;

                CommentResponse result = ecBusiness.EditAccount(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call edit account success.");
                    }
                    else
                    {
                        this.WriteLog("call edit account failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call edit account fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call edit account fail," + ex.Message);
            }
        }

        //删除账户
        private void btn_delAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DelAccountInfo _info = new DelAccountInfo();
                _info.userId = this.txt_AccountId.Text.Trim();
                _info.accountId = this.txt_accountIdEx.Text.Trim();

                CommentResponse result = ecBusiness.DelAccount(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call del account success.");
                    }
                    else
                    {
                        this.WriteLog("call del account failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call del account fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call del account fail," + ex.Message);
            }
        }

        //查询账户
        private void btn_QueryAccount_Click(object sender, EventArgs e)
        {
            try
            {
                QueryAccountInfo _info = new QueryAccountInfo();
                _info.userId = this.txt_AccountId.Text.Trim();
                _info.exactSearch = this.cbx_IsExact.Text.Trim();
                _info.pageCount = this.txt_dpPageNum.Text.Trim();
                _info.pageNum = this.txt_accountPageNum.Text.Trim();
                _info.condition = this.txt_codition.Text.Trim();

                QueryAccountResponse result = ecBusiness.QueryAccount(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query account success.");
                    }
                    else
                    {
                        this.WriteLog("call query account failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query account fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query account fail," + ex.Message);
            }
        }

        //添加SIP号码
        private void btn_addSipNumber_Click(object sender, EventArgs e)
        {
            try
            {
                AddSIPInfo _info = new AddSIPInfo();
                _info.userId = this.txt_sipUser.Text.Trim();

                SIPAccount _account = new SIPAccount();
                _account.gwIp = this.txt_gwIp.Text.Trim();
                _account.joint = this.cbx_isJoint.Text.Trim();
                _account.number = this.txt_SipNumber.Text.Trim();
                _account.rightLevel = this.cbx_rightLevel.Text.Trim();
                _account.addPrefix = this.cbx_addPrefix.Text.Trim();
                _account.ueType = this.cbx_deviceType.Text.Trim();
                _account.subPbx = "1";
                _account.longNum = "";
                _account.localGwIp = "";
                _account.sipUe = "100018695237";
                _account.bOutgoingRights = "";
                _account.cOutgoingRights = "";

                SIPAuth _auth = new SIPAuth();
                _auth.type = this.cbx_authType.Text.Trim();
                _auth.password = this.txt_authPw5.Text.Trim();
                _auth.ip = this.txt_authIp.Text.Trim();

                UsmSip _usmSip = new UsmSip();
                _usmSip.crgName = "";
                _usmSip.domainName = "";
                _usmSip.sipServerId = "";
                _usmSip.isSyncLocalGw = "";
                _usmSip.localGwName = "";
                _usmSip.mrGroupName = "";
                _usmSip.sourceCode = "";
                _usmSip.stationGroupName = "";

                _account.sipAuth = _auth;
                _account.usmSip = _usmSip;
                _info.sip = _account;

                CommentResponse result = ecBusiness.AddSipNumber(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call add sip number success.");
                    }
                    else
                    {
                        this.WriteLog("call add sip number failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call add sip number fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call add sip number fail," + ex.Message);
            }
        }

        //修改SIP号码
        private void btn_editSipNumber_Click(object sender, EventArgs e)
        {
            try
            {
                AddSIPInfo _info = new AddSIPInfo();
                _info.userId = this.txt_sipUser.Text.Trim();

                SIPAccount _account = new SIPAccount();
                _account.gwIp = this.txt_gwIp.Text.Trim();
                _account.joint = this.cbx_isJoint.Text.Trim();
                _account.number = this.txt_SipNumber.Text.Trim();
                _account.rightLevel = this.cbx_rightLevel.Text.Trim();
                _account.addPrefix = this.cbx_addPrefix.Text.Trim();
                _account.ueType = this.cbx_deviceType.Text.Trim();
                _account.subPbx = "1";
                _account.longNum = "14";
                _account.localGwIp = "";
                _account.sipUe = "100018695237";
                _account.bOutgoingRights = "";
                _account.cOutgoingRights = "";

                SIPAuth _auth = new SIPAuth();
                _auth.type = this.cbx_authType.Text.Trim();
                _auth.password = this.txt_authPw5.Text.Trim();
                _auth.ip = this.txt_authIp.Text.Trim();

                UsmSip _usmSip = new UsmSip();
                _usmSip.crgName = "";
                _usmSip.domainName = "";
                _usmSip.sipServerId = "";
                _usmSip.isSyncLocalGw = "";
                _usmSip.localGwName = "";
                _usmSip.mrGroupName = "";
                _usmSip.sourceCode = "";
                _usmSip.stationGroupName = "";

                _account.sipAuth = _auth;
                _account.usmSip = _usmSip;
                _info.sip = _account;

                CommentResponse result = ecBusiness.EditSipNumber(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call edit sip number success.");
                    }
                    else
                    {
                        this.WriteLog("call edit sip number failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call edit sip number fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call edit sip number fail," + ex.Message);
            }
        }

        //删除SIP号码
        private void btn_delSipNumber_Click(object sender, EventArgs e)
        {
            try
            {
                DelSipNumber _info = new DelSipNumber();
                _info.userId = this.txt_sipUser.Text.Trim();
                
                delSipNumber info = new delSipNumber();
                info.gwIp = this.txt_gwIp.Text.Trim();
                info.number = this.txt_SipNumber.Text.Trim();
                info.deleteSipUe = this.cbx_deleteSipUe.Text.Trim();

                _info.sip = info;

                CommentResponse result = ecBusiness.DelSipNumber(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call del sip number success.");
                    }
                    else
                    {
                        this.WriteLog("call del sip number failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call del sip number fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call del sip number fail," + ex.Message);
            }
        }

        //查询SIP号码
        private void btn_querySipNumber_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySipInfoList _info = new QuerySipInfoList();
                _info.userId = this.txt_sipUser.Text.Trim();
                _info.exactSearch = this.cbx_isExactQuery.Text.Trim();
                _info.value = this.txt_queryConditionValue.Text.Trim();
                _info.type = this.cbx_queryConditionType.Text.Trim();
                _info.pageCount = this.txt_sipPageCount.Text.Trim();
                _info.pageNum = this.txt_sipPageNum.Text.Trim();

                QuerySipResponse result = ecBusiness.QuerySipNumber(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query sip number success.");
                    }
                    else
                    {
                        this.WriteLog("call query sip number failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query sip number fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query sip number fail," + ex.Message);
            }
        }

        //查询个人通讯录
        private void btn_QueryAddress_Click(object sender, EventArgs e)
        {
            try
            {
                QueryAddressInfo _info = new QueryAddressInfo();
                _info.account = this.txt_ECAccount.Text.Trim();
                _info.condition = this.txt_queryCondition.Text.Trim();
                _info.pageCount = this.txt_pageCount.Text.Trim();
                _info.pageNum = this.txt_pageNum.Text.Trim();
                QueryAddressResponse result = ecBusiness.QueryAddress(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query address success.");
                    }
                    else
                    {
                        this.WriteLog("call query address failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query address fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query address fail," + ex.Message);
            }
        }

        //查询个人详情
        private void btn_QueryPersonInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string staffAccount = this.txt_beECAccount.Text.Trim();
                QueryPersonInfoResponse result = ecBusiness.QueryPersonInfo(staffAccount);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query personinfo success.");
                    }
                    else
                    {
                        this.WriteLog("call query personinfo failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query personinfo fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query qpersoninfo fail," + ex.Message);
            }
        }

        //查询企业通讯录
        private void btn_queryEnterprise_Click(object sender, EventArgs e)
        {
            try
            {
                QueryEnterprise _info = new QueryEnterprise();
                _info.departmentId = this.txt_departmentIDEx.Text.Trim();
                _info.pageCount = this.txt_pageCount.Text.Trim();
                _info.pageNum = this.txt_pageNum.Text.Trim();
                QueryEnterpriseResponse result = ecBusiness.QueryEnterprise(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query Enterprise success.");
                    }
                    else
                    {
                        this.WriteLog("call query Enterprise failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query Enterprise fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query Enterprise fail," + ex.Message);
            }
        }

        //查询个人信息
        private void btn_queryEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                QueryEmployee _info = new QueryEmployee();
                _info.account = txt_ECAccount.Text.Trim();
                _info.condition = this.txt_queryCondition.Text.Trim();
                _info.pageCount = this.txt_pageCount.Text.Trim();
                _info.pageNum = this.txt_pageNum.Text.Trim();
                QueryEmployeeResponse result = ecBusiness.QueryEmployee(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query Employee success.");
                    }
                    else
                    {
                        this.WriteLog("call query Employee failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query Employee fail,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query Employee fail," + ex.Message);
            }
        }
       
    }
}
