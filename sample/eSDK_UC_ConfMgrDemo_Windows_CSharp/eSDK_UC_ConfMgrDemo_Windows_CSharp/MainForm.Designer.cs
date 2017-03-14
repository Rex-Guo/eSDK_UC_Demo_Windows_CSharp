namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_pw5 = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Uri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_AccountId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ResultInfo = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ResultCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_confId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gwIp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_confNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_guestPw5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_masterPw5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_confEndTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_confStartTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_confTitle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbx_isRecord = new System.Windows.Forms.ComboBox();
            this.cbx_isEncrype = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbx_confType = new System.Windows.Forms.ComboBox();
            this.btn_addConf = new System.Windows.Forms.Button();
            this.btn_editConf = new System.Windows.Forms.Button();
            this.btn_delConf = new System.Windows.Forms.Button();
            this.btn_queryConfList = new System.Windows.Forms.Button();
            this.btn_addConfNumber = new System.Windows.Forms.Button();
            this.txt_PBXid = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbx_enterPrompt = new System.Windows.Forms.ComboBox();
            this.cbx_leavePrompt = new System.Windows.Forms.ComboBox();
            this.txt_PageNum = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_PageCount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pw5
            // 
            this.txt_pw5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pw5.Location = new System.Drawing.Point(269, 35);
            this.txt_pw5.Name = "txt_pw5";
            this.txt_pw5.Size = new System.Drawing.Size(135, 21);
            this.txt_pw5.TabIndex = 12;
            this.txt_pw5.Text = "Huawei@123";
            this.txt_pw5.UseSystemPasswordChar = true;
            this.txt_pw5.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UserName.Location = new System.Drawing.Point(86, 35);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(117, 21);
            this.txt_UserName.TabIndex = 11;
            this.txt_UserName.Text = "esdk_user";
            this.txt_UserName.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(222, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "用户名：";
            // 
            // txt_Uri
            // 
            this.txt_Uri.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Uri.Location = new System.Drawing.Point(86, 5);
            this.txt_Uri.Name = "txt_Uri";
            this.txt_Uri.Size = new System.Drawing.Size(320, 21);
            this.txt_Uri.TabIndex = 8;
            this.txt_Uri.Text = "http://172.22.9.42:8086";
            this.txt_Uri.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "eSDK URI:";
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_log.Location = new System.Drawing.Point(12, 447);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(829, 126);
            this.txt_log.TabIndex = 13;
            this.txt_log.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_PageNum);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txt_PageCount);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.cbx_leavePrompt);
            this.groupBox1.Controls.Add(this.cbx_enterPrompt);
            this.groupBox1.Controls.Add(this.txt_PBXid);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.btn_addConfNumber);
            this.groupBox1.Controls.Add(this.btn_queryConfList);
            this.groupBox1.Controls.Add(this.btn_delConf);
            this.groupBox1.Controls.Add(this.btn_editConf);
            this.groupBox1.Controls.Add(this.btn_addConf);
            this.groupBox1.Controls.Add(this.cbx_confType);
            this.groupBox1.Controls.Add(this.cbx_isEncrype);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cbx_isRecord);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_confTitle);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_confEndTime);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_confStartTime);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_masterPw5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_guestPw5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_confNumber);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_gwIp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_confId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_AccountId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 379);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入参数";
            // 
            // txt_AccountId
            // 
            this.txt_AccountId.Location = new System.Drawing.Point(92, 22);
            this.txt_AccountId.Name = "txt_AccountId";
            this.txt_AccountId.Size = new System.Drawing.Size(71, 21);
            this.txt_AccountId.TabIndex = 1;
            this.txt_AccountId.Text = "12345";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "操作用户ID：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Content);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_ResultInfo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_ResultCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(506, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 379);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "返回参数";
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(78, 59);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(243, 21);
            this.txt_Content.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "返回内容：";
            // 
            // txt_ResultInfo
            // 
            this.txt_ResultInfo.Location = new System.Drawing.Point(17, 106);
            this.txt_ResultInfo.Name = "txt_ResultInfo";
            this.txt_ResultInfo.Size = new System.Drawing.Size(304, 267);
            this.txt_ResultInfo.TabIndex = 11;
            this.txt_ResultInfo.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "返回信息：";
            // 
            // txt_ResultCode
            // 
            this.txt_ResultCode.Location = new System.Drawing.Point(78, 32);
            this.txt_ResultCode.Name = "txt_ResultCode";
            this.txt_ResultCode.Size = new System.Drawing.Size(128, 21);
            this.txt_ResultCode.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "返回码：";
            // 
            // txt_confId
            // 
            this.txt_confId.Location = new System.Drawing.Point(92, 59);
            this.txt_confId.Name = "txt_confId";
            this.txt_confId.Size = new System.Drawing.Size(71, 21);
            this.txt_confId.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "会议ID：";
            // 
            // txt_gwIp
            // 
            this.txt_gwIp.Location = new System.Drawing.Point(250, 20);
            this.txt_gwIp.Name = "txt_gwIp";
            this.txt_gwIp.Size = new System.Drawing.Size(142, 21);
            this.txt_gwIp.TabIndex = 5;
            this.txt_gwIp.Text = "172.22.9.44";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "统一网关IP：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "离会提示：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "入会提示：";
            // 
            // txt_confNumber
            // 
            this.txt_confNumber.Location = new System.Drawing.Point(92, 132);
            this.txt_confNumber.Name = "txt_confNumber";
            this.txt_confNumber.Size = new System.Drawing.Size(71, 21);
            this.txt_confNumber.TabIndex = 11;
            this.txt_confNumber.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "与会人数：";
            // 
            // txt_guestPw5
            // 
            this.txt_guestPw5.Location = new System.Drawing.Point(250, 135);
            this.txt_guestPw5.Name = "txt_guestPw5";
            this.txt_guestPw5.Size = new System.Drawing.Size(71, 21);
            this.txt_guestPw5.TabIndex = 13;
            this.txt_guestPw5.Text = "123456";
            this.txt_guestPw5.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "来宾密码：";
            // 
            // txt_masterPw5
            // 
            this.txt_masterPw5.Location = new System.Drawing.Point(400, 132);
            this.txt_masterPw5.Name = "txt_masterPw5";
            this.txt_masterPw5.Size = new System.Drawing.Size(71, 21);
            this.txt_masterPw5.TabIndex = 15;
            this.txt_masterPw5.Text = "654321";
            this.txt_masterPw5.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "主席密码：";
            // 
            // txt_confEndTime
            // 
            this.txt_confEndTime.Location = new System.Drawing.Point(114, 206);
            this.txt_confEndTime.Name = "txt_confEndTime";
            this.txt_confEndTime.Size = new System.Drawing.Size(128, 21);
            this.txt_confEndTime.TabIndex = 21;
            this.txt_confEndTime.Text = "1990-01-01 00:00:01";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "会议结束时间：";
            // 
            // txt_confStartTime
            // 
            this.txt_confStartTime.Location = new System.Drawing.Point(114, 172);
            this.txt_confStartTime.Name = "txt_confStartTime";
            this.txt_confStartTime.Size = new System.Drawing.Size(128, 21);
            this.txt_confStartTime.TabIndex = 19;
            this.txt_confStartTime.Text = "1990-01-01 00:00:00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "会议开始时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(177, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "会议类型：";
            // 
            // txt_confTitle
            // 
            this.txt_confTitle.Location = new System.Drawing.Point(92, 94);
            this.txt_confTitle.Name = "txt_confTitle";
            this.txt_confTitle.Size = new System.Drawing.Size(71, 21);
            this.txt_confTitle.TabIndex = 23;
            this.txt_confTitle.Text = "testconf";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 22;
            this.label18.Text = "会议主题：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(177, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 24;
            this.label19.Text = "是否录音：";
            // 
            // cbx_isRecord
            // 
            this.cbx_isRecord.FormattingEnabled = true;
            this.cbx_isRecord.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbx_isRecord.Location = new System.Drawing.Point(248, 94);
            this.cbx_isRecord.Name = "cbx_isRecord";
            this.cbx_isRecord.Size = new System.Drawing.Size(73, 20);
            this.cbx_isRecord.TabIndex = 25;
            this.cbx_isRecord.Text = "0";
            // 
            // cbx_isEncrype
            // 
            this.cbx_isEncrype.FormattingEnabled = true;
            this.cbx_isEncrype.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbx_isEncrype.Location = new System.Drawing.Point(400, 94);
            this.cbx_isEncrype.Name = "cbx_isEncrype";
            this.cbx_isEncrype.Size = new System.Drawing.Size(73, 20);
            this.cbx_isEncrype.TabIndex = 27;
            this.cbx_isEncrype.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(329, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 26;
            this.label20.Text = "是否加密：";
            // 
            // cbx_confType
            // 
            this.cbx_confType.FormattingEnabled = true;
            this.cbx_confType.Items.AddRange(new object[] {
            "1",
            "3"});
            this.cbx_confType.Location = new System.Drawing.Point(250, 59);
            this.cbx_confType.Name = "cbx_confType";
            this.cbx_confType.Size = new System.Drawing.Size(73, 20);
            this.cbx_confType.TabIndex = 28;
            this.cbx_confType.Text = "1";
            // 
            // btn_addConf
            // 
            this.btn_addConf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addConf.Location = new System.Drawing.Point(47, 273);
            this.btn_addConf.Name = "btn_addConf";
            this.btn_addConf.Size = new System.Drawing.Size(116, 41);
            this.btn_addConf.TabIndex = 29;
            this.btn_addConf.Text = "预约会议";
            this.btn_addConf.UseVisualStyleBackColor = true;
            this.btn_addConf.Click += new System.EventHandler(this.btn_addConf_Click);
            // 
            // btn_editConf
            // 
            this.btn_editConf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_editConf.Location = new System.Drawing.Point(190, 273);
            this.btn_editConf.Name = "btn_editConf";
            this.btn_editConf.Size = new System.Drawing.Size(116, 41);
            this.btn_editConf.TabIndex = 30;
            this.btn_editConf.Text = "修改会议";
            this.btn_editConf.UseVisualStyleBackColor = true;
            this.btn_editConf.Click += new System.EventHandler(this.btn_editConf_Click);
            // 
            // btn_delConf
            // 
            this.btn_delConf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delConf.Location = new System.Drawing.Point(331, 273);
            this.btn_delConf.Name = "btn_delConf";
            this.btn_delConf.Size = new System.Drawing.Size(116, 41);
            this.btn_delConf.TabIndex = 31;
            this.btn_delConf.Text = "删除会议";
            this.btn_delConf.UseVisualStyleBackColor = true;
            this.btn_delConf.Click += new System.EventHandler(this.btn_delConf_Click);
            // 
            // btn_queryConfList
            // 
            this.btn_queryConfList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_queryConfList.Location = new System.Drawing.Point(47, 330);
            this.btn_queryConfList.Name = "btn_queryConfList";
            this.btn_queryConfList.Size = new System.Drawing.Size(116, 41);
            this.btn_queryConfList.TabIndex = 32;
            this.btn_queryConfList.Text = "查询会议列表";
            this.btn_queryConfList.UseVisualStyleBackColor = true;
            this.btn_queryConfList.Click += new System.EventHandler(this.btn_queryConfList_Click);
            // 
            // btn_addConfNumber
            // 
            this.btn_addConfNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addConfNumber.Location = new System.Drawing.Point(190, 330);
            this.btn_addConfNumber.Name = "btn_addConfNumber";
            this.btn_addConfNumber.Size = new System.Drawing.Size(116, 41);
            this.btn_addConfNumber.TabIndex = 33;
            this.btn_addConfNumber.Text = "添加与会人数";
            this.btn_addConfNumber.UseVisualStyleBackColor = true;
            this.btn_addConfNumber.Click += new System.EventHandler(this.btn_addConfNumber_Click);
            // 
            // txt_PBXid
            // 
            this.txt_PBXid.Location = new System.Drawing.Point(402, 61);
            this.txt_PBXid.Name = "txt_PBXid";
            this.txt_PBXid.Size = new System.Drawing.Size(71, 21);
            this.txt_PBXid.TabIndex = 35;
            this.txt_PBXid.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(329, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 34;
            this.label21.Text = "虚拟PBXID：";
            // 
            // cbx_enterPrompt
            // 
            this.cbx_enterPrompt.FormattingEnabled = true;
            this.cbx_enterPrompt.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbx_enterPrompt.Location = new System.Drawing.Point(339, 172);
            this.cbx_enterPrompt.Name = "cbx_enterPrompt";
            this.cbx_enterPrompt.Size = new System.Drawing.Size(73, 20);
            this.cbx_enterPrompt.TabIndex = 36;
            this.cbx_enterPrompt.Text = "0";
            // 
            // cbx_leavePrompt
            // 
            this.cbx_leavePrompt.FormattingEnabled = true;
            this.cbx_leavePrompt.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbx_leavePrompt.Location = new System.Drawing.Point(339, 206);
            this.cbx_leavePrompt.Name = "cbx_leavePrompt";
            this.cbx_leavePrompt.Size = new System.Drawing.Size(73, 20);
            this.cbx_leavePrompt.TabIndex = 37;
            this.cbx_leavePrompt.Text = "0";
            // 
            // txt_PageNum
            // 
            this.txt_PageNum.Location = new System.Drawing.Point(339, 239);
            this.txt_PageNum.Name = "txt_PageNum";
            this.txt_PageNum.Size = new System.Drawing.Size(73, 21);
            this.txt_PageNum.TabIndex = 41;
            this.txt_PageNum.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(268, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 40;
            this.label22.Text = "当前页数：";
            // 
            // txt_PageCount
            // 
            this.txt_PageCount.Location = new System.Drawing.Point(114, 239);
            this.txt_PageCount.Name = "txt_PageCount";
            this.txt_PageCount.Size = new System.Drawing.Size(128, 21);
            this.txt_PageCount.TabIndex = 39;
            this.txt_PageCount.Text = "10";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 242);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 38;
            this.label23.Text = "每页显示数：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_pw5);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Uri);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "会议管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pw5;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Uri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txt_ResultInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ResultCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_AccountId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_confEndTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_confStartTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_masterPw5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_guestPw5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_confNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_gwIp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_confId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_isEncrype;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbx_isRecord;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_confTitle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbx_confType;
        private System.Windows.Forms.Button btn_addConfNumber;
        private System.Windows.Forms.Button btn_queryConfList;
        private System.Windows.Forms.Button btn_delConf;
        private System.Windows.Forms.Button btn_editConf;
        private System.Windows.Forms.Button btn_addConf;
        private System.Windows.Forms.TextBox txt_PBXid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbx_leavePrompt;
        private System.Windows.Forms.ComboBox cbx_enterPrompt;
        private System.Windows.Forms.TextBox txt_PageNum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_PageCount;
        private System.Windows.Forms.Label label23;
    }
}

