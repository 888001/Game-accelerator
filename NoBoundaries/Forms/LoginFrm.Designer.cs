namespace NoBoundaries
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.btn_SysClose = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserID = new CCWin.SkinControl.SkinTextBox();
            this.tbUserPwd = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Logo = new CCWin.SkinControl.SkinPanel();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox2 = new CCWin.SkinControl.SkinCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btn_SysClose
            // 
            this.btn_SysClose.BackColor = System.Drawing.Color.Transparent;
            this.btn_SysClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SysClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SysClose.DownBack = global::NoBoundaries.Properties.Resources.close_down;
            this.btn_SysClose.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_SysClose.IsDrawBorder = false;
            this.btn_SysClose.Location = new System.Drawing.Point(333, 14);
            this.btn_SysClose.MouseBack = global::NoBoundaries.Properties.Resources.close_enter;
            this.btn_SysClose.Name = "btn_SysClose";
            this.btn_SysClose.NormlBack = global::NoBoundaries.Properties.Resources.close_normal;
            this.btn_SysClose.Size = new System.Drawing.Size(11, 11);
            this.btn_SysClose.TabIndex = 17;
            this.btn_SysClose.UseVisualStyleBackColor = false;
            this.btn_SysClose.Click += new System.EventHandler(this.btn_SysClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(56, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "密码:";
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.Color.Transparent;
            this.tbUserID.DownBack = null;
            this.tbUserID.Icon = null;
            this.tbUserID.IconIsButton = false;
            this.tbUserID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbUserID.IsPasswordChat = '\0';
            this.tbUserID.IsSystemPasswordChar = false;
            this.tbUserID.Lines = new string[0];
            this.tbUserID.Location = new System.Drawing.Point(104, 106);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(0);
            this.tbUserID.MaxLength = 32767;
            this.tbUserID.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbUserID.MouseBack = null;
            this.tbUserID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbUserID.Multiline = false;
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.NormlBack = null;
            this.tbUserID.Padding = new System.Windows.Forms.Padding(5);
            this.tbUserID.ReadOnly = false;
            this.tbUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserID.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.tbUserID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbUserID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbUserID.SkinTxt.Name = "BaseText";
            this.tbUserID.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.tbUserID.SkinTxt.TabIndex = 0;
            this.tbUserID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUserID.SkinTxt.WaterText = "";
            this.tbUserID.TabIndex = 21;
            this.tbUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUserID.WaterText = "";
            this.tbUserID.WordWrap = true;
            // 
            // tbUserPwd
            // 
            this.tbUserPwd.BackColor = System.Drawing.Color.Transparent;
            this.tbUserPwd.DownBack = null;
            this.tbUserPwd.Icon = null;
            this.tbUserPwd.IconIsButton = false;
            this.tbUserPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbUserPwd.IsPasswordChat = '●';
            this.tbUserPwd.IsSystemPasswordChar = false;
            this.tbUserPwd.Lines = new string[0];
            this.tbUserPwd.Location = new System.Drawing.Point(104, 146);
            this.tbUserPwd.Margin = new System.Windows.Forms.Padding(0);
            this.tbUserPwd.MaxLength = 32767;
            this.tbUserPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbUserPwd.MouseBack = null;
            this.tbUserPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbUserPwd.Multiline = false;
            this.tbUserPwd.Name = "tbUserPwd";
            this.tbUserPwd.NormlBack = null;
            this.tbUserPwd.Padding = new System.Windows.Forms.Padding(5);
            this.tbUserPwd.ReadOnly = false;
            this.tbUserPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserPwd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.tbUserPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbUserPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbUserPwd.SkinTxt.Name = "BaseText";
            this.tbUserPwd.SkinTxt.PasswordChar = '●';
            this.tbUserPwd.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.tbUserPwd.SkinTxt.TabIndex = 0;
            this.tbUserPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUserPwd.SkinTxt.WaterText = "";
            this.tbUserPwd.TabIndex = 22;
            this.tbUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUserPwd.WaterText = "";
            this.tbUserPwd.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(220, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "点击注册";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(88, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "无界加速器登陆界面";
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Logo.BackgroundImage")));
            this.panel_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Logo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Logo.DownBack = null;
            this.panel_Logo.Location = new System.Drawing.Point(18, 14);
            this.panel_Logo.MouseBack = null;
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.NormlBack = null;
            this.panel_Logo.Radius = 4;
            this.panel_Logo.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.panel_Logo.Size = new System.Drawing.Size(48, 48);
            this.panel_Logo.TabIndex = 27;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(60, 213);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.skinCheckBox1.TabIndex = 28;
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox2
            // 
            this.skinCheckBox2.AutoSize = true;
            this.skinCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox2.DownBack = null;
            this.skinCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox2.Location = new System.Drawing.Point(172, 213);
            this.skinCheckBox2.MouseBack = null;
            this.skinCheckBox2.Name = "skinCheckBox2";
            this.skinCheckBox2.NormlBack = null;
            this.skinCheckBox2.SelectedDownBack = null;
            this.skinCheckBox2.SelectedMouseBack = null;
            this.skinCheckBox2.SelectedNormlBack = null;
            this.skinCheckBox2.Size = new System.Drawing.Size(15, 14);
            this.skinCheckBox2.TabIndex = 29;
            this.skinCheckBox2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(81, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "记住密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(193, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "自动登录";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(169)))), ((int)(((byte)(213)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.DownBack")));
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.skinButton1.Location = new System.Drawing.Point(178, 245);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Palace = true;
            this.skinButton1.Size = new System.Drawing.Size(112, 38);
            this.skinButton1.TabIndex = 109;
            this.skinButton1.Text = "取消";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(169)))), ((int)(((byte)(213)))));
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DownBack = ((System.Drawing.Image)(resources.GetObject("btnOk.DownBack")));
            this.btnOk.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnOk.Location = new System.Drawing.Point(47, 245);
            this.btnOk.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnOk.MouseBack")));
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnOk.NormlBack")));
            this.btnOk.Palace = true;
            this.btnOk.Size = new System.Drawing.Size(112, 38);
            this.btnOk.TabIndex = 108;
            this.btnOk.Text = "登录";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 300);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skinCheckBox2);
            this.Controls.Add(this.skinCheckBox1);
            this.Controls.Add(this.panel_Logo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserPwd);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SysClose);
            this.Name = "LoginFrm";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton btn_SysClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinTextBox tbUserID;
        private CCWin.SkinControl.SkinTextBox tbUserPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinPanel panel_Logo;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton btnOk;
    }
}