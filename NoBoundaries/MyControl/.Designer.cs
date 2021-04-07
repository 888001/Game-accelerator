
namespace NoBoundaries.MyControl
{
    partial class IconList
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.panel_border = new CCWin.SkinControl.SkinPanel();
            this.lbGameName = new System.Windows.Forms.Label();
            this.panel_Icon = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1.SuspendLayout();
            this.panel_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.panel_border);
            this.skinPanel1.Controls.Add(this.panel_Icon);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(112, 140);
            this.skinPanel1.TabIndex = 0;
            // 
            // panel_border
            // 
            this.panel_border.BackColor = System.Drawing.Color.Transparent;
            this.panel_border.BorderColor = System.Drawing.Color.DimGray;
            this.panel_border.Controls.Add(this.lbGameName);
            this.panel_border.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_border.DownBack = null;
            this.panel_border.Location = new System.Drawing.Point(6, 110);
            this.panel_border.MouseBack = null;
            this.panel_border.Name = "panel_border";
            this.panel_border.NormlBack = null;
            this.panel_border.Size = new System.Drawing.Size(100, 24);
            this.panel_border.TabIndex = 1;
            // 
            // lbGameName
            // 
            this.lbGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGameName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGameName.ForeColor = System.Drawing.Color.DimGray;
            this.lbGameName.Location = new System.Drawing.Point(0, 0);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(100, 24);
            this.lbGameName.TabIndex = 0;
            this.lbGameName.Text = "unknown";
            this.lbGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Icon
            // 
            this.panel_Icon.BackColor = System.Drawing.Color.Transparent;
            this.panel_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Icon.BorderColor = System.Drawing.Color.DimGray;
            this.panel_Icon.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Icon.DownBack = null;
            this.panel_Icon.Location = new System.Drawing.Point(6, 5);
            this.panel_Icon.MouseBack = null;
            this.panel_Icon.Name = "panel_Icon";
            this.panel_Icon.NormlBack = null;
            this.panel_Icon.Size = new System.Drawing.Size(100, 100);
            this.panel_Icon.TabIndex = 0;
            this.panel_Icon.Click += new System.EventHandler(this.panel_Icon_Click);
            this.panel_Icon.MouseEnter += new System.EventHandler(this.panel_Icon_MouseEnter);
            this.panel_Icon.MouseLeave += new System.EventHandler(this.panel_Icon_MouseLeave);
            // 
            // IconList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.skinPanel1);
            this.Name = "IconList";
            this.Size = new System.Drawing.Size(112, 140);
            this.skinPanel1.ResumeLayout(false);
            this.panel_border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel panel_border;
        private System.Windows.Forms.Label lbGameName;
        private CCWin.SkinControl.SkinPanel panel_Icon;
    }
}
