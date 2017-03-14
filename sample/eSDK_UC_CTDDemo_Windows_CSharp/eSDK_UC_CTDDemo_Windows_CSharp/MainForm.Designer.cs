namespace eSDK_UC_CTDDemo_Windows_CSharp
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
            this.btn_SendAffiche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Uri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_pw5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CTD = new System.Windows.Forms.Button();
            this.txt_Callee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Caller = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ECAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ResultInfo = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ResultCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SendAffiche
            // 
            this.btn_SendAffiche.Location = new System.Drawing.Point(513, 43);
            this.btn_SendAffiche.Name = "btn_SendAffiche";
            this.btn_SendAffiche.Size = new System.Drawing.Size(87, 25);
            this.btn_SendAffiche.TabIndex = 0;
            this.btn_SendAffiche.Text = "发送公告";
            this.btn_SendAffiche.UseVisualStyleBackColor = true;
            this.btn_SendAffiche.Click += new System.EventHandler(this.btn_SendAffiche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "eSDK URI:";
            // 
            // txt_Uri
            // 
            this.txt_Uri.Location = new System.Drawing.Point(88, 9);
            this.txt_Uri.Name = "txt_Uri";
            this.txt_Uri.Size = new System.Drawing.Size(320, 21);
            this.txt_Uri.TabIndex = 2;
            this.txt_Uri.Text = "http://172.22.9.42:8086";
            this.txt_Uri.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(88, 45);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(117, 21);
            this.txt_UserName.TabIndex = 5;
            this.txt_UserName.Text = "esdk_user";
            this.txt_UserName.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
            // 
            // txt_pw5
            // 
            this.txt_pw5.Location = new System.Drawing.Point(271, 45);
            this.txt_pw5.Name = "txt_pw5";
            this.txt_pw5.Size = new System.Drawing.Size(135, 21);
            this.txt_pw5.TabIndex = 6;
            this.txt_pw5.Text = "Huawei@123";
            this.txt_pw5.UseSystemPasswordChar = true;
            this.txt_pw5.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CTD);
            this.groupBox1.Controls.Add(this.txt_Callee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Caller);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ECAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 222);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入参数";
            // 
            // btn_CTD
            // 
            this.btn_CTD.Location = new System.Drawing.Point(81, 161);
            this.btn_CTD.Name = "btn_CTD";
            this.btn_CTD.Size = new System.Drawing.Size(100, 38);
            this.btn_CTD.TabIndex = 9;
            this.btn_CTD.Text = "点击呼叫";
            this.btn_CTD.UseVisualStyleBackColor = true;
            this.btn_CTD.Click += new System.EventHandler(this.btn_CTD_Click);
            // 
            // txt_Callee
            // 
            this.txt_Callee.Location = new System.Drawing.Point(113, 123);
            this.txt_Callee.Name = "txt_Callee";
            this.txt_Callee.Size = new System.Drawing.Size(113, 21);
            this.txt_Callee.TabIndex = 11;
            this.txt_Callee.Text = "486100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "被叫者号码：";
            // 
            // txt_Caller
            // 
            this.txt_Caller.Location = new System.Drawing.Point(113, 76);
            this.txt_Caller.Name = "txt_Caller";
            this.txt_Caller.Size = new System.Drawing.Size(113, 21);
            this.txt_Caller.TabIndex = 9;
            this.txt_Caller.Text = "486107";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "主叫者号码：";
            // 
            // txt_ECAccount
            // 
            this.txt_ECAccount.Location = new System.Drawing.Point(113, 32);
            this.txt_ECAccount.Name = "txt_ECAccount";
            this.txt_ECAccount.Size = new System.Drawing.Size(113, 21);
            this.txt_ECAccount.TabIndex = 7;
            this.txt_ECAccount.Text = "123645";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "操作者EC账号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Content);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_ResultInfo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_ResultCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(274, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 222);
            this.groupBox2.TabIndex = 8;
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
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "返回内容：";
            // 
            // txt_ResultInfo
            // 
            this.txt_ResultInfo.Location = new System.Drawing.Point(78, 91);
            this.txt_ResultInfo.Name = "txt_ResultInfo";
            this.txt_ResultInfo.Size = new System.Drawing.Size(243, 126);
            this.txt_ResultInfo.TabIndex = 11;
            this.txt_ResultInfo.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 12);
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
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "返回码：";
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_log.Location = new System.Drawing.Point(10, 319);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(591, 118);
            this.txt_log.TabIndex = 9;
            this.txt_log.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 449);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_pw5);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SendAffiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Uri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.Text = "Demo_CTD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendAffiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Uri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_pw5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CTD;
        private System.Windows.Forms.TextBox txt_Callee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Caller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ECAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt_ResultInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ResultCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Label label9;
    }
}

