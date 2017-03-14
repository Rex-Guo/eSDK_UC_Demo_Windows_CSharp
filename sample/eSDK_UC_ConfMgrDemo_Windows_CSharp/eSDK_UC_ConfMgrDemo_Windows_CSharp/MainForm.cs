using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
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

            this.txt_confStartTime.Text = DateTime.Now.AddMinutes(30).ToString().Replace("/","-");
            this.txt_confEndTime.Text = DateTime.Now.AddMinutes(90).ToString().Replace("/", "-");
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

        private void btn_addConf_Click(object sender, EventArgs e)
        {
            try
            {
                AddConfInfo _confInfo = new AddConfInfo();
                _confInfo.userId = this.txt_AccountId.Text.Trim();
                _confInfo.gwIp = this.txt_gwIp.Text.Trim();
                _confInfo.subPbx = this.txt_PBXid.Text.Trim();
                _confInfo.guestPwd = this.txt_guestPw5.Text.Trim();
                _confInfo.chairmanPwd = this.txt_masterPw5.Text.Trim();
                _confInfo.amount = this.txt_confNumber.Text.Trim();
                _confInfo.recordFlag = this.cbx_isRecord.Text.Trim();
                _confInfo.srtpMode = this.cbx_isEncrype.Text.Trim();
                _confInfo.startTime = this.txt_confStartTime.Text.Trim();
                _confInfo.endTime = this.txt_confEndTime.Text.Trim();
                _confInfo.confMode = this.cbx_confType.Text.Trim();
                _confInfo.confName = this.txt_confTitle.Text.Trim();
                _confInfo.leavePrompt = this.cbx_leavePrompt.Text.Trim();
                _confInfo.enterPrompt = this.cbx_enterPrompt.Text.Trim();

                AddConfResponse result = ecBusiness.AddConf(_confInfo);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call schedule conference success.");
                    } 
                    else
                    {
                        this.WriteLog("call schedule conference failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call schedule conference failed,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call schedule conference failed," + ex.Message);
            }
        }

        private void btn_editConf_Click(object sender, EventArgs e)
        {
            try
            {
                EditConfInfo _confInfo = new EditConfInfo();
                _confInfo.userId = this.txt_AccountId.Text.Trim();
                _confInfo.gwIp = this.txt_gwIp.Text.Trim();
                _confInfo.subPbx = this.txt_PBXid.Text.Trim();
                _confInfo.confId = this.txt_confId.Text.Trim();
                _confInfo.guestPwd = this.txt_guestPw5.Text.Trim();
                _confInfo.chairmanPwd = this.txt_masterPw5.Text.Trim();
                _confInfo.amount = this.txt_confNumber.Text.Trim();
                _confInfo.recordFlag = this.cbx_isRecord.Text.Trim();
                _confInfo.srtpMode = this.cbx_isEncrype.Text.Trim();
                _confInfo.startTime = this.txt_confStartTime.Text.Trim();
                _confInfo.endTime = this.txt_confEndTime.Text.Trim();
                _confInfo.confMode = this.cbx_confType.Text.Trim();
                _confInfo.confName = this.txt_confTitle.Text.Trim();
                _confInfo.leavePrompt = this.cbx_leavePrompt.Text.Trim();
                _confInfo.enterPrompt = this.cbx_enterPrompt.Text.Trim();

                CommentResponse result = ecBusiness.EditConf(_confInfo);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call edit conference success.");
                    }
                    else
                    {
                        this.WriteLog("call edit conference failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call edit conference failed,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call edit conference failed," + ex.Message);
            }
        }

        private void btn_delConf_Click(object sender, EventArgs e)
        {
            try
            {
                DelConfInfo _delConfInfo = new DelConfInfo();
                _delConfInfo.userId = this.txt_AccountId.Text.Trim();

                List<DeleteMeetingBaseParam> list = new List<DeleteMeetingBaseParam>();
                DeleteMeetingBaseParam param = new DeleteMeetingBaseParam();
                param.confId = this.txt_confId.Text.Trim();
                param.gwIp = this.txt_gwIp.Text.Trim();
                list.Add(param);

                _delConfInfo.deleteItem = list;

                DelConfResponse result = ecBusiness.DelConf(_delConfInfo);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call delete conference success.");
                    }
                    else
                    {
                        this.WriteLog("call delete conference failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call delete conference failed,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call delete conference failed," + ex.Message);
            }       
        }

        private void btn_queryConfList_Click(object sender, EventArgs e)
        {
            try
            {
                QueryConfList _queryConfList = new QueryConfList();
                _queryConfList.confId = this.txt_confId.Text.Trim();
                _queryConfList.confName = this.txt_confTitle.Text.Trim();
                _queryConfList.endTime = this.txt_confEndTime.Text.Trim();
                _queryConfList.startTime = this.txt_confStartTime.Text.Trim();
                _queryConfList.pageCount = this.txt_PageCount.Text.Trim();
                _queryConfList.pageNum = this.txt_PageNum.Text.Trim();
                _queryConfList.phone = "";
                _queryConfList.userId = this.txt_AccountId.Text.Trim();

                QueryConfResponse result = ecBusiness.QueryConfList(_queryConfList);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call query conference list success.");
                    }
                    else
                    {
                        this.WriteLog("call query conference list failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call query conference list failed,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call query conference list failed," + ex.Message);
            }
        }

        private void btn_addConfNumber_Click(object sender, EventArgs e)
        {
            try
            {
                AddConfMemberInfo _addConfMemberInfo = new AddConfMemberInfo();
                _addConfMemberInfo.userId = this.txt_AccountId.Text.Trim();
                _addConfMemberInfo.gwIp = this.txt_gwIp.Text.Trim();
                _addConfMemberInfo.confId = this.txt_confId.Text.Trim();
                _addConfMemberInfo.subPbx = this.txt_PBXid.Text.Trim();
                _addConfMemberInfo.account = "1205007";
                _addConfMemberInfo.attNumber = "1205007";
                _addConfMemberInfo.attType = "0";
                _addConfMemberInfo.email = "";

                CommentResponse result = ecBusiness.AddConfMember(_addConfMemberInfo);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    this.txt_ResultInfo.Text = eSDKServiceHelper.GetJsonString(result);
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call schedule conference success.");
                    }
                    else
                    {
                        this.WriteLog("call schedule conference failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call schedule conference failed,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call schedule conference failed," + ex.Message);
            }
        }

    }
}
