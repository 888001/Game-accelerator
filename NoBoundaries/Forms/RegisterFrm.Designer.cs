
namespace NoBoundaries
{
    partial class RegisterFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterFrm));
            this.btn_SysClose = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserPwd = new CCWin.SkinControl.SkinTextBox();
            this.tbUserID = new CCWin.SkinControl.SkinTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPwd2 = new CCWin.SkinControl.SkinTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
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
            this.btn_SysClose.Location = new System.Drawing.Point(247, 11);
            this.btn_SysClose.MouseBack = global::NoBoundaries.Properties.Resources.close_enter;
            this.btn_SysClose.Name = "btn_SysClose";
            this.btn_SysClose.NormlBack = global::NoBoundaries.Properties.Resources.close_normal;
            this.btn_SysClose.Size = new System.Drawing.Size(11, 11);
            this.btn_SysClose.TabIndex = 18;
            this.btn_SysClose.UseVisualStyleBackColor = false;
            this.btn_SysClose.Click += new System.EventHandler(this.btn_SysClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "无界加速器-注册";
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
            this.tbUserPwd.Location = new System.Drawing.Point(68, 102);
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
            this.tbUserPwd.TabIndex = 26;
            this.tbUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUserPwd.WaterText = "";
            this.tbUserPwd.WordWrap = true;
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
            this.tbUserID.Location = new System.Drawing.Point(68, 62);
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
            this.tbUserID.TabIndex = 25;
            this.tbUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUserID.WaterText = "";
            this.tbUserID.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "账号:";
            // 
            // tbPwd2
            // 
            this.tbPwd2.BackColor = System.Drawing.Color.Transparent;
            this.tbPwd2.DownBack = null;
            this.tbPwd2.Icon = null;
            this.tbPwd2.IconIsButton = false;
            this.tbPwd2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbPwd2.IsPasswordChat = '●';
            this.tbPwd2.IsSystemPasswordChar = false;
            this.tbPwd2.Lines = new string[0];
            this.tbPwd2.Location = new System.Drawing.Point(68, 143);
            this.tbPwd2.Margin = new System.Windows.Forms.Padding(0);
            this.tbPwd2.MaxLength = 32767;
            this.tbPwd2.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbPwd2.MouseBack = null;
            this.tbPwd2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbPwd2.Multiline = false;
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.NormlBack = null;
            this.tbPwd2.Padding = new System.Windows.Forms.Padding(5);
            this.tbPwd2.ReadOnly = false;
            this.tbPwd2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPwd2.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.tbPwd2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPwd2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbPwd2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbPwd2.SkinTxt.Name = "BaseText";
            this.tbPwd2.SkinTxt.PasswordChar = '●';
            this.tbPwd2.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.tbPwd2.SkinTxt.TabIndex = 0;
            this.tbPwd2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbPwd2.SkinTxt.WaterText = "";
            this.tbPwd2.TabIndex = 28;
            this.tbPwd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPwd2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbPwd2.WaterText = "";
            this.tbPwd2.WordWrap = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "确认:";
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
            this.btnOk.Location = new System.Drawing.Point(10, 215);
            this.btnOk.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnOk.MouseBack")));
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnOk.NormlBack")));
            this.btnOk.Palace = true;
            this.btnOk.Size = new System.Drawing.Size(112, 38);
            this.btnOk.TabIndex = 106;
            this.btnOk.Text = "注册";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.skinButton1.Location = new System.Drawing.Point(141, 215);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Palace = true;
            this.skinButton1.Size = new System.Drawing.Size(112, 38);
            this.skinButton1.TabIndex = 107;
            this.skinButton1.Text = "取消";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 282);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbPwd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUserPwd);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SysClose);
            this.Name = "RegisterFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btn_SysClose;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinTextBox tbUserPwd;
        private CCWin.SkinControl.SkinTextBox tbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinTextBox tbPwd2;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton btnOk;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}