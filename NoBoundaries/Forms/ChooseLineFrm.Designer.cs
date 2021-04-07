
namespace NoBoundaries
{
    partial class ChooseLineFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLineFrm));
            this.btn_SysClose = new CCWin.SkinControl.SkinButton();
            this.skinListBox1 = new CCWin.SkinControl.SkinListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.btn_SysClose.Location = new System.Drawing.Point(391, 14);
            this.btn_SysClose.MouseBack = global::NoBoundaries.Properties.Resources.close_enter;
            this.btn_SysClose.Name = "btn_SysClose";
            this.btn_SysClose.NormlBack = global::NoBoundaries.Properties.Resources.close_normal;
            this.btn_SysClose.Size = new System.Drawing.Size(11, 11);
            this.btn_SysClose.TabIndex = 7;
            this.btn_SysClose.UseVisualStyleBackColor = false;
            this.btn_SysClose.Click += new System.EventHandler(this.btn_SysClose_Click);
            // 
            // skinListBox1
            // 
            this.skinListBox1.Back = null;
            this.skinListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.skinListBox1.BorderColor = System.Drawing.Color.DimGray;
            this.skinListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinListBox1.ForeColor = System.Drawing.Color.DimGray;
            this.skinListBox1.FormattingEnabled = true;
            this.skinListBox1.ItemHeight = 20;
            this.skinListBox1.Location = new System.Drawing.Point(10, 46);
            this.skinListBox1.MouseColor = System.Drawing.Color.Gray;
            this.skinListBox1.Name = "skinListBox1";
            this.skinListBox1.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.skinListBox1.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.skinListBox1.SelectedColor = System.Drawing.Color.Silver;
            this.skinListBox1.Size = new System.Drawing.Size(392, 182);
            this.skinListBox1.TabIndex = 8;
            this.skinListBox1.DoubleClick += new System.EventHandler(this.skinListBox1_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "无界加速器-节点选择";
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
            this.btnOk.Location = new System.Drawing.Point(146, 238);
            this.btnOk.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnOk.MouseBack")));
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnOk.NormlBack")));
            this.btnOk.Palace = true;
            this.btnOk.Size = new System.Drawing.Size(112, 38);
            this.btnOk.TabIndex = 109;
            this.btnOk.Text = "选择";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChooseLineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 289);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skinListBox1);
            this.Controls.Add(this.btn_SysClose);
            this.Name = "ChooseLineFrm";
            this.Load += new System.EventHandler(this.ChooseLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btn_SysClose;
        private CCWin.SkinControl.SkinListBox skinListBox1;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton btnOk;
        private System.Windows.Forms.Timer timer1;
    }
}