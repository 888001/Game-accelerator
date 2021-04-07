
namespace NoBoundaries
{
    partial class GameListFrm
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
            this.btn_SysHide = new CCWin.SkinControl.SkinButton();
            this.panel = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SysHide
            // 
            this.btn_SysHide.BackColor = System.Drawing.Color.Transparent;
            this.btn_SysHide.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SysHide.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SysHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SysHide.DownBack = global::NoBoundaries.Properties.Resources.hide_down;
            this.btn_SysHide.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_SysHide.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SysHide.GlowColor = System.Drawing.Color.Transparent;
            this.btn_SysHide.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_SysHide.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_SysHide.IsDrawBorder = false;
            this.btn_SysHide.IsDrawGlass = false;
            this.btn_SysHide.Location = new System.Drawing.Point(487, 13);
            this.btn_SysHide.MouseBack = global::NoBoundaries.Properties.Resources.hide_enter;
            this.btn_SysHide.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_SysHide.Name = "btn_SysHide";
            this.btn_SysHide.NormlBack = global::NoBoundaries.Properties.Resources.hide_normal;
            this.btn_SysHide.Size = new System.Drawing.Size(17, 17);
            this.btn_SysHide.TabIndex = 8;
            this.btn_SysHide.UseVisualStyleBackColor = false;
            this.btn_SysHide.Click += new System.EventHandler(this.btn_SysHide_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel.DownBack = null;
            this.panel.Location = new System.Drawing.Point(10, 36);
            this.panel.MouseBack = null;
            this.panel.Name = "panel";
            this.panel.NormlBack = null;
            this.panel.Palace = true;
            this.panel.Size = new System.Drawing.Size(494, 579);
            this.panel.TabIndex = 9;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "添加游戏";
            // 
            // GameListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_SysHide);
            this.Name = "GameListFrm";
            this.Load += new System.EventHandler(this.GameListFrm_Load);
            this.MouseEnter += new System.EventHandler(this.GameListFrm_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btn_SysHide;
        private CCWin.SkinControl.SkinFlowLayoutPanel panel;
        private System.Windows.Forms.Label label1;
    }
}