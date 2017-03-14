using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eSDK_UC_CTDDemo_Windows_CSharp
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

        private void btn_SendAffiche_Click(object sender, EventArgs e)
        {
            try
            {
                afficheInfo _afficheinfo = new afficheInfo();

                _afficheinfo.afficheTitle = "Title";
                _afficheinfo.afficheContent = "Content";
                _afficheinfo.receiverType = "1";

                List<string> listAccounts = new List<string>();
                listAccounts.Add("uctest01");
                listAccounts.Add("uctest02");
                _afficheinfo.staffAccounts = listAccounts;

                List<string> listDepartmentIds = new List<string>();
                listDepartmentIds.Add("ucpart01");
                listDepartmentIds.Add("ucpart02");
                _afficheinfo.departmentIds = listDepartmentIds;

                CommentResponse result = ecBusiness.affiche(_afficheinfo);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    if (result.resultCode == "0")
                    {                       
                        this.WriteLog("call affiche success.");
                    }
                    else
                    {
                        this.WriteLog("call affiche failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call affiche failed,response is null.");
                }
            }
            catch (Exception ex)
            {
                this.WriteLog("call affiche failed,"+ex.Message);
            }
        }

        private void btn_CTD_Click(object sender, EventArgs e)
        {
            try
            {
                CTDCallInfo _info = new CTDCallInfo();
                _info.account = this.txt_ECAccount.Text.Trim();
                _info.caller = this.txt_Caller.Text.Trim();
                _info.callee = this.txt_Callee.Text.Trim();

                CommentResponse result = ecBusiness.ctdCall(_info);
                if (result != null)
                {
                    this.txt_ResultCode.Text = result.resultCode;
                    this.txt_Content.Text = result.resultContext;
                    if (result.resultCode == "0")
                    {
                        this.WriteLog("call ctd success.");
                    }
                    else
                    {
                        this.WriteLog("call ctd failed," + result.resultContext);
                    }
                }
                else
                {
                    this.WriteLog("call ctd fail,response is null.");
                }
            }
            catch(Exception ex)
            {
                this.WriteLog("call ctd fail," + ex.Message);
            }
        }               
    }
}
