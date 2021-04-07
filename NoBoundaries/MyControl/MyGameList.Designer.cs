
namespace NoBoundaries.MyControl
{
    partial class MyGameList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyGameList));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.panel_deleteIco = new CCWin.SkinControl.SkinPanel();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.panel_GameIco = new CCWin.SkinControl.SkinPanel();
            this.lbDelete = new System.Windows.Forms.Label();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.lbDelete);
            this.skinPanel1.Controls.Add(this.panel_deleteIco);
            this.skinPanel1.Controls.Add(this.lbProgramName);
            this.skinPanel1.Controls.Add(this.panel_GameIco);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(260, 75);
            this.skinPanel1.TabIndex = 0;
            // 
            // panel_deleteIco
            // 
            this.panel_deleteIco.BackColor = System.Drawing.Color.Transparent;
            this.panel_deleteIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_deleteIco.BackgroundImage")));
            this.panel_deleteIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_deleteIco.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_deleteIco.DownBack = null;
            this.panel_deleteIco.Location = new System.Drawing.Point(181, 49);
            this.panel_deleteIco.MouseBack = null;
            this.panel_deleteIco.Name = "panel_deleteIco";
            this.panel_deleteIco.NormlBack = null;
            this.panel_deleteIco.Size = new System.Drawing.Size(13, 13);
            this.panel_deleteIco.TabIndex = 13;
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbProgramName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbProgramName.Location = new System.Drawing.Point(76, 14);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(75, 20);
            this.lbProgramName.TabIndex = 12;
            this.lbProgramName.Text = "unknown";
            // 
            // panel_GameIco
            // 
            this.panel_GameIco.BackColor = System.Drawing.Color.Transparent;
            this.panel_GameIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_GameIco.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_GameIco.DownBack = null;
            this.panel_GameIco.Location = new System.Drawing.Point(12, 14);
            this.panel_GameIco.MouseBack = null;
            this.panel_GameIco.Name = "panel_GameIco";
            this.panel_GameIco.NormlBack = null;
            this.panel_GameIco.Size = new System.Drawing.Size(48, 48);
            this.panel_GameIco.TabIndex = 2;
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDelete.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbDelete.ForeColor = System.Drawing.Color.DarkGray;
            this.lbDelete.Location = new System.Drawing.Point(197, 48);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(56, 17);
            this.lbDelete.TabIndex = 14;
            this.lbDelete.Text = "删除此项";
            this.lbDelete.Click += new System.EventHandler(this.lbDelete_Click);
            // 
            // MyGameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.skinPanel1);
            this.Name = "MyGameList";
            this.Size = new System.Drawing.Size(260, 75);
            this.MouseEnter += new System.EventHandler(this.MyGameList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyGameList_MouseLeave);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel panel_GameIco;
        private System.Windows.Forms.Label lbProgramName;
        private CCWin.SkinControl.SkinPanel panel_deleteIco;
        private System.Windows.Forms.Label lbDelete;
    }
}
