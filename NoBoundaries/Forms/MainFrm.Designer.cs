namespace NoBoundaries
{
    partial class MainFrm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btn_SysMenu = new CCWin.SkinControl.SkinButton();
            this.btn_SysClose = new CCWin.SkinControl.SkinButton();
            this.panel_Game = new CCWin.SkinControl.SkinPanel();
            this.lbStateText = new System.Windows.Forms.Label();
            this.lbChooseGame = new System.Windows.Forms.Label();
            this.lbPingText = new System.Windows.Forms.Label();
            this.panel_Net = new CCWin.SkinControl.SkinPanel();
            this.panel_State = new CCWin.SkinControl.SkinPanel();
            this.lbCutLine = new System.Windows.Forms.Label();
            this.lbChooseLine = new System.Windows.Forms.Label();
            this.lbCurrentGameName = new System.Windows.Forms.Label();
            this.panel_CurrentGameIco = new CCWin.SkinControl.SkinPanel();
            this.panel_BtnStart = new CCWin.SkinControl.SkinPanel();
            this.lbStart = new System.Windows.Forms.Label();
            this.panel_Logo = new CCWin.SkinControl.SkinPanel();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel_None = new CCWin.SkinControl.SkinPanel();
            this.btnAddGame = new CCWin.SkinControl.SkinButton();
            this.lbMemo = new System.Windows.Forms.Label();
            this.btn_SysMin = new System.Windows.Forms.Label();
            this.panel_Menu = new CCWin.SkinControl.SkinPanel();
            this.lbLoginout = new System.Windows.Forms.Label();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.lbCutLine2 = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbRepair = new System.Windows.Forms.Label();
            this.lbSet = new System.Windows.Forms.Label();
            this.Menu_UpadteIco = new CCWin.SkinControl.SkinPanel();
            this.Menu_AboutIco = new CCWin.SkinControl.SkinPanel();
            this.menu_SetICo = new CCWin.SkinControl.SkinPanel();
            this.Menu_RepairIco = new CCWin.SkinControl.SkinPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_Game.SuspendLayout();
            this.panel_BtnStart.SuspendLayout();
            this.panel_None.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SysMenu
            // 
            this.btn_SysMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_SysMenu.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SysMenu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SysMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SysMenu.DownBack = global::NoBoundaries.Properties.Resources.menu_down;
            this.btn_SysMenu.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_SysMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SysMenu.GlowColor = System.Drawing.Color.Transparent;
            this.btn_SysMenu.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_SysMenu.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_SysMenu.IsDrawBorder = false;
            this.btn_SysMenu.IsDrawGlass = false;
            this.btn_SysMenu.Location = new System.Drawing.Point(281, 11);
            this.btn_SysMenu.MouseBack = global::NoBoundaries.Properties.Resources.menu_enter;
            this.btn_SysMenu.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_SysMenu.Name = "btn_SysMenu";
            this.btn_SysMenu.NormlBack = global::NoBoundaries.Properties.Resources.menu_normal;
            this.btn_SysMenu.Size = new System.Drawing.Size(17, 17);
            this.btn_SysMenu.TabIndex = 7;
            this.btn_SysMenu.UseVisualStyleBackColor = false;
            this.btn_SysMenu.Click += new System.EventHandler(this.btn_SysMenu_Click);
            // 
            // btn_SysClose
            // 
            this.btn_SysClose.BackColor = System.Drawing.Color.Transparent;
            this.btn_SysClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SysClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SysClose.DownBack = global::NoBoundaries.Properties.Resources.close_down;
            this.btn_SysClose.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_SysClose.IsDrawBorder = false;
            this.btn_SysClose.Location = new System.Drawing.Point(328, 14);
            this.btn_SysClose.MouseBack = global::NoBoundaries.Properties.Resources.close_enter;
            this.btn_SysClose.Name = "btn_SysClose";
            this.btn_SysClose.NormlBack = global::NoBoundaries.Properties.Resources.close_normal;
            this.btn_SysClose.Size = new System.Drawing.Size(11, 11);
            this.btn_SysClose.TabIndex = 6;
            this.btn_SysClose.UseVisualStyleBackColor = false;
            this.btn_SysClose.Click += new System.EventHandler(this.btn_SysClose_Click);
            // 
            // panel_Game
            // 
            this.panel_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel_Game.Controls.Add(this.lbStateText);
            this.panel_Game.Controls.Add(this.lbChooseGame);
            this.panel_Game.Controls.Add(this.lbPingText);
            this.panel_Game.Controls.Add(this.panel_Net);
            this.panel_Game.Controls.Add(this.panel_State);
            this.panel_Game.Controls.Add(this.lbCutLine);
            this.panel_Game.Controls.Add(this.lbChooseLine);
            this.panel_Game.Controls.Add(this.lbCurrentGameName);
            this.panel_Game.Controls.Add(this.panel_CurrentGameIco);
            this.panel_Game.Controls.Add(this.panel_BtnStart);
            this.panel_Game.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Game.DownBack = null;
            this.panel_Game.Location = new System.Drawing.Point(4, 516);
            this.panel_Game.MouseBack = null;
            this.panel_Game.Name = "panel_Game";
            this.panel_Game.NormlBack = null;
            this.panel_Game.Size = new System.Drawing.Size(343, 110);
            this.panel_Game.TabIndex = 9;
            // 
            // lbStateText
            // 
            this.lbStateText.AutoSize = true;
            this.lbStateText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStateText.ForeColor = System.Drawing.Color.DimGray;
            this.lbStateText.Location = new System.Drawing.Point(32, 9);
            this.lbStateText.Name = "lbStateText";
            this.lbStateText.Size = new System.Drawing.Size(53, 12);
            this.lbStateText.TabIndex = 11;
            this.lbStateText.Text = "等待加速";
            // 
            // lbChooseGame
            // 
            this.lbChooseGame.AutoSize = true;
            this.lbChooseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbChooseGame.ForeColor = System.Drawing.Color.DimGray;
            this.lbChooseGame.Location = new System.Drawing.Point(271, 9);
            this.lbChooseGame.Name = "lbChooseGame";
            this.lbChooseGame.Size = new System.Drawing.Size(53, 12);
            this.lbChooseGame.TabIndex = 10;
            this.lbChooseGame.Text = "切换游戏";
            this.lbChooseGame.Click += new System.EventHandler(this.lbChooseGame_Click);
            this.lbChooseGame.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbChooseGame.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // lbPingText
            // 
            this.lbPingText.AutoSize = true;
            this.lbPingText.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbPingText.Location = new System.Drawing.Point(194, 9);
            this.lbPingText.Name = "lbPingText";
            this.lbPingText.Size = new System.Drawing.Size(29, 12);
            this.lbPingText.TabIndex = 9;
            this.lbPingText.Text = "0 ms";
            // 
            // panel_Net
            // 
            this.panel_Net.BackColor = System.Drawing.Color.Transparent;
            this.panel_Net.BackgroundImage = global::NoBoundaries.Properties.Resources.net_Green;
            this.panel_Net.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_Net.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Net.DownBack = null;
            this.panel_Net.Location = new System.Drawing.Point(168, 5);
            this.panel_Net.MouseBack = null;
            this.panel_Net.Name = "panel_Net";
            this.panel_Net.NormlBack = null;
            this.panel_Net.Size = new System.Drawing.Size(20, 20);
            this.panel_Net.TabIndex = 8;
            // 
            // panel_State
            // 
            this.panel_State.BackColor = System.Drawing.Color.Transparent;
            this.panel_State.BackgroundImage = global::NoBoundaries.Properties.Resources.bkg_State;
            this.panel_State.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_State.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_State.DownBack = null;
            this.panel_State.Location = new System.Drawing.Point(6, 5);
            this.panel_State.MouseBack = null;
            this.panel_State.Name = "panel_State";
            this.panel_State.NormlBack = null;
            this.panel_State.Size = new System.Drawing.Size(20, 20);
            this.panel_State.TabIndex = 6;
            // 
            // lbCutLine
            // 
            this.lbCutLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCutLine.Location = new System.Drawing.Point(-2, 29);
            this.lbCutLine.Name = "lbCutLine";
            this.lbCutLine.Size = new System.Drawing.Size(350, 1);
            this.lbCutLine.TabIndex = 5;
            this.lbCutLine.Text = "label1";
            // 
            // lbChooseLine
            // 
            this.lbChooseLine.AutoSize = true;
            this.lbChooseLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbChooseLine.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbChooseLine.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbChooseLine.Location = new System.Drawing.Point(61, 75);
            this.lbChooseLine.Name = "lbChooseLine";
            this.lbChooseLine.Size = new System.Drawing.Size(56, 17);
            this.lbChooseLine.TabIndex = 4;
            this.lbChooseLine.Text = "选择节点";
            this.lbChooseLine.Click += new System.EventHandler(this.lbChooseLine_Click);
            this.lbChooseLine.MouseEnter += new System.EventHandler(this.lbUser_MouseEnter);
            this.lbChooseLine.MouseLeave += new System.EventHandler(this.lbUser_MouseLeave);
            // 
            // lbCurrentGameName
            // 
            this.lbCurrentGameName.AutoSize = true;
            this.lbCurrentGameName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbCurrentGameName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCurrentGameName.Location = new System.Drawing.Point(60, 50);
            this.lbCurrentGameName.Name = "lbCurrentGameName";
            this.lbCurrentGameName.Size = new System.Drawing.Size(84, 20);
            this.lbCurrentGameName.TabIndex = 3;
            this.lbCurrentGameName.Text = "未选择游戏";
            // 
            // panel_CurrentGameIco
            // 
            this.panel_CurrentGameIco.BackColor = System.Drawing.Color.Transparent;
            this.panel_CurrentGameIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_CurrentGameIco.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_CurrentGameIco.DownBack = null;
            this.panel_CurrentGameIco.Location = new System.Drawing.Point(6, 48);
            this.panel_CurrentGameIco.MouseBack = null;
            this.panel_CurrentGameIco.Name = "panel_CurrentGameIco";
            this.panel_CurrentGameIco.NormlBack = null;
            this.panel_CurrentGameIco.Size = new System.Drawing.Size(48, 48);
            this.panel_CurrentGameIco.TabIndex = 1;
            // 
            // panel_BtnStart
            // 
            this.panel_BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.panel_BtnStart.BackgroundImage = global::NoBoundaries.Properties.Resources.bkg_btnStart;
            this.panel_BtnStart.Controls.Add(this.lbStart);
            this.panel_BtnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_BtnStart.DownBack = null;
            this.panel_BtnStart.Location = new System.Drawing.Point(229, 29);
            this.panel_BtnStart.MouseBack = null;
            this.panel_BtnStart.Name = "panel_BtnStart";
            this.panel_BtnStart.NormlBack = null;
            this.panel_BtnStart.Size = new System.Drawing.Size(115, 85);
            this.panel_BtnStart.TabIndex = 0;
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStart.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbStart.ForeColor = System.Drawing.Color.DimGray;
            this.lbStart.Location = new System.Drawing.Point(34, 37);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(69, 20);
            this.lbStart.TabIndex = 11;
            this.lbStart.Tag = "0";
            this.lbStart.Text = "一键加速";
            this.lbStart.Click += new System.EventHandler(this.lbStart_Click);
            this.lbStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbStart_MouseDown);
            this.lbStart.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbStart.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Logo.BackgroundImage")));
            this.panel_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Logo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Logo.DownBack = null;
            this.panel_Logo.Location = new System.Drawing.Point(21, 15);
            this.panel_Logo.MouseBack = null;
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.NormlBack = null;
            this.panel_Logo.Radius = 4;
            this.panel_Logo.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.panel_Logo.Size = new System.Drawing.Size(48, 48);
            this.panel_Logo.TabIndex = 10;
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbProgramName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbProgramName.Location = new System.Drawing.Point(82, 15);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(114, 20);
            this.lbProgramName.TabIndex = 11;
            this.lbProgramName.Text = "无界网游加速器";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbUser.Location = new System.Drawing.Point(84, 42);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(53, 12);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "尚未登录";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            this.lbUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbUser_MouseDown);
            this.lbUser.MouseEnter += new System.EventHandler(this.lbUser_MouseEnter);
            this.lbUser.MouseLeave += new System.EventHandler(this.lbUser_MouseLeave);
            // 
            // panel_None
            // 
            this.panel_None.BackColor = System.Drawing.Color.Transparent;
            this.panel_None.Controls.Add(this.btnAddGame);
            this.panel_None.Controls.Add(this.lbMemo);
            this.panel_None.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_None.DownBack = null;
            this.panel_None.Location = new System.Drawing.Point(21, 87);
            this.panel_None.MouseBack = null;
            this.panel_None.Name = "panel_None";
            this.panel_None.NormlBack = null;
            this.panel_None.Size = new System.Drawing.Size(306, 407);
            this.panel_None.TabIndex = 13;
            this.panel_None.Click += new System.EventHandler(this.panel_GameList_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(169)))), ((int)(((byte)(213)))));
            this.btnAddGame.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddGame.DownBack = ((System.Drawing.Image)(resources.GetObject("btnAddGame.DownBack")));
            this.btnAddGame.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnAddGame.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnAddGame.Location = new System.Drawing.Point(109, 177);
            this.btnAddGame.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnAddGame.MouseBack")));
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnAddGame.NormlBack")));
            this.btnAddGame.Palace = true;
            this.btnAddGame.Size = new System.Drawing.Size(88, 34);
            this.btnAddGame.TabIndex = 109;
            this.btnAddGame.Text = "添加游戏";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbMemo.ForeColor = System.Drawing.Color.DimGray;
            this.lbMemo.Location = new System.Drawing.Point(79, 139);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(163, 20);
            this.lbMemo.TabIndex = 0;
            this.lbMemo.Text = "添加游戏 享受极速体验";
            // 
            // btn_SysMin
            // 
            this.btn_SysMin.AutoSize = true;
            this.btn_SysMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SysMin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SysMin.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SysMin.Location = new System.Drawing.Point(303, 14);
            this.btn_SysMin.Name = "btn_SysMin";
            this.btn_SysMin.Size = new System.Drawing.Size(20, 17);
            this.btn_SysMin.TabIndex = 14;
            this.btn_SysMin.Text = "一";
            this.btn_SysMin.Click += new System.EventHandler(this.btn_SysMin_Click);
            this.btn_SysMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_SysMin_MouseDown);
            this.btn_SysMin.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.btn_SysMin.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.lbLoginout);
            this.panel_Menu.Controls.Add(this.skinPanel1);
            this.panel_Menu.Controls.Add(this.lbCutLine2);
            this.panel_Menu.Controls.Add(this.lbAbout);
            this.panel_Menu.Controls.Add(this.lbUpdate);
            this.panel_Menu.Controls.Add(this.lbRepair);
            this.panel_Menu.Controls.Add(this.lbSet);
            this.panel_Menu.Controls.Add(this.Menu_UpadteIco);
            this.panel_Menu.Controls.Add(this.Menu_AboutIco);
            this.panel_Menu.Controls.Add(this.menu_SetICo);
            this.panel_Menu.Controls.Add(this.Menu_RepairIco);
            this.panel_Menu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Menu.DownBack = null;
            this.panel_Menu.Location = new System.Drawing.Point(241, 30);
            this.panel_Menu.MouseBack = null;
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.NormlBack = null;
            this.panel_Menu.Size = new System.Drawing.Size(88, 112);
            this.panel_Menu.TabIndex = 15;
            // 
            // lbLoginout
            // 
            this.lbLoginout.AutoSize = true;
            this.lbLoginout.ForeColor = System.Drawing.Color.DimGray;
            this.lbLoginout.Location = new System.Drawing.Point(27, 91);
            this.lbLoginout.Name = "lbLoginout";
            this.lbLoginout.Size = new System.Drawing.Size(53, 12);
            this.lbLoginout.TabIndex = 12;
            this.lbLoginout.Text = "退出登录";
            this.lbLoginout.Click += new System.EventHandler(this.lbLoginout_Click);
            this.lbLoginout.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbLoginout.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::NoBoundaries.Properties.Resources.panel_menu_loginout;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(7, 90);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(14, 14);
            this.skinPanel1.TabIndex = 11;
            // 
            // lbCutLine2
            // 
            this.lbCutLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCutLine2.ForeColor = System.Drawing.Color.DimGray;
            this.lbCutLine2.Location = new System.Drawing.Point(0, 85);
            this.lbCutLine2.Name = "lbCutLine2";
            this.lbCutLine2.Size = new System.Drawing.Size(102, 1);
            this.lbCutLine2.TabIndex = 10;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.ForeColor = System.Drawing.Color.DimGray;
            this.lbAbout.Location = new System.Drawing.Point(27, 69);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(53, 12);
            this.lbAbout.TabIndex = 9;
            this.lbAbout.Text = "关于我们";
            this.lbAbout.Click += new System.EventHandler(this.lbAbout_Click);
            this.lbAbout.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbAbout.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.lbUpdate.Location = new System.Drawing.Point(27, 49);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(53, 12);
            this.lbUpdate.TabIndex = 8;
            this.lbUpdate.Text = "软件升级";
            this.lbUpdate.Click += new System.EventHandler(this.lbUpdate_Click);
            this.lbUpdate.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbUpdate.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // lbRepair
            // 
            this.lbRepair.AutoSize = true;
            this.lbRepair.ForeColor = System.Drawing.Color.DimGray;
            this.lbRepair.Location = new System.Drawing.Point(27, 29);
            this.lbRepair.Name = "lbRepair";
            this.lbRepair.Size = new System.Drawing.Size(53, 12);
            this.lbRepair.TabIndex = 7;
            this.lbRepair.Text = "网络修复";
            this.lbRepair.Click += new System.EventHandler(this.lbRepair_Click);
            this.lbRepair.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbRepair.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // lbSet
            // 
            this.lbSet.AutoSize = true;
            this.lbSet.ForeColor = System.Drawing.Color.DimGray;
            this.lbSet.Location = new System.Drawing.Point(27, 9);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(53, 12);
            this.lbSet.TabIndex = 6;
            this.lbSet.Text = "系统设置";
            this.lbSet.Click += new System.EventHandler(this.lbSet_Click);
            this.lbSet.MouseEnter += new System.EventHandler(this.btnLabel_MouseEnter);
            this.lbSet.MouseLeave += new System.EventHandler(this.btnLabel_MouseLeave);
            // 
            // Menu_UpadteIco
            // 
            this.Menu_UpadteIco.BackColor = System.Drawing.Color.Transparent;
            this.Menu_UpadteIco.BackgroundImage = global::NoBoundaries.Properties.Resources.panel_menu_update;
            this.Menu_UpadteIco.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Menu_UpadteIco.DownBack = null;
            this.Menu_UpadteIco.Location = new System.Drawing.Point(7, 48);
            this.Menu_UpadteIco.MouseBack = null;
            this.Menu_UpadteIco.Name = "Menu_UpadteIco";
            this.Menu_UpadteIco.NormlBack = null;
            this.Menu_UpadteIco.Size = new System.Drawing.Size(14, 14);
            this.Menu_UpadteIco.TabIndex = 4;
            // 
            // Menu_AboutIco
            // 
            this.Menu_AboutIco.BackColor = System.Drawing.Color.Transparent;
            this.Menu_AboutIco.BackgroundImage = global::NoBoundaries.Properties.Resources.panel_menu_about;
            this.Menu_AboutIco.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Menu_AboutIco.DownBack = null;
            this.Menu_AboutIco.Location = new System.Drawing.Point(7, 68);
            this.Menu_AboutIco.MouseBack = null;
            this.Menu_AboutIco.Name = "Menu_AboutIco";
            this.Menu_AboutIco.NormlBack = null;
            this.Menu_AboutIco.Size = new System.Drawing.Size(14, 14);
            this.Menu_AboutIco.TabIndex = 5;
            // 
            // menu_SetICo
            // 
            this.menu_SetICo.BackColor = System.Drawing.Color.Transparent;
            this.menu_SetICo.BackgroundImage = global::NoBoundaries.Properties.Resources.panel_menu_set;
            this.menu_SetICo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.menu_SetICo.DownBack = null;
            this.menu_SetICo.Location = new System.Drawing.Point(7, 8);
            this.menu_SetICo.MouseBack = null;
            this.menu_SetICo.Name = "menu_SetICo";
            this.menu_SetICo.NormlBack = null;
            this.menu_SetICo.Size = new System.Drawing.Size(14, 14);
            this.menu_SetICo.TabIndex = 2;
            // 
            // Menu_RepairIco
            // 
            this.Menu_RepairIco.BackColor = System.Drawing.Color.Transparent;
            this.Menu_RepairIco.BackgroundImage = global::NoBoundaries.Properties.Resources.panel_menu_repair;
            this.Menu_RepairIco.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Menu_RepairIco.DownBack = null;
            this.Menu_RepairIco.Location = new System.Drawing.Point(7, 28);
            this.Menu_RepairIco.MouseBack = null;
            this.Menu_RepairIco.Name = "Menu_RepairIco";
            this.Menu_RepairIco.NormlBack = null;
            this.Menu_RepairIco.Size = new System.Drawing.Size(14, 14);
            this.Menu_RepairIco.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundImage = global::NoBoundaries.Properties.Resources.bkg;
            this.ClientSize = new System.Drawing.Size(350, 630);
            this.CloseBoxSize = new System.Drawing.Size(11, 11);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.btn_SysMin);
            this.Controls.Add(this.panel_None);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbProgramName);
            this.Controls.Add(this.panel_Logo);
            this.Controls.Add(this.panel_Game);
            this.Controls.Add(this.btn_SysMenu);
            this.Controls.Add(this.btn_SysClose);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MdiBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "MainFrm";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Click += new System.EventHandler(this.panel_GameList_Click);
            this.Move += new System.EventHandler(this.MainFrm_Move);
            this.panel_Game.ResumeLayout(false);
            this.panel_Game.PerformLayout();
            this.panel_BtnStart.ResumeLayout(false);
            this.panel_BtnStart.PerformLayout();
            this.panel_None.ResumeLayout(false);
            this.panel_None.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton btn_SysMenu;
        private CCWin.SkinControl.SkinButton btn_SysClose;
        private CCWin.SkinControl.SkinPanel panel_Game;
        private CCWin.SkinControl.SkinPanel panel_BtnStart;
        private CCWin.SkinControl.SkinPanel panel_CurrentGameIco;
        private System.Windows.Forms.Label lbChooseLine;
        private System.Windows.Forms.Label lbCurrentGameName;
        private System.Windows.Forms.Label lbCutLine;
        private CCWin.SkinControl.SkinPanel panel_State;
        private System.Windows.Forms.Label lbPingText;
        private CCWin.SkinControl.SkinPanel panel_Net;
        private System.Windows.Forms.Label lbChooseGame;
        private System.Windows.Forms.Label lbStart;
        private CCWin.SkinControl.SkinPanel panel_Logo;
        private System.Windows.Forms.Label lbProgramName;
        private System.Windows.Forms.Label lbUser;
        private CCWin.SkinControl.SkinPanel panel_None;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.Label btn_SysMin;
        private CCWin.SkinControl.SkinPanel panel_Menu;
        private System.Windows.Forms.Label lbLoginout;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Label lbCutLine2;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbRepair;
        private System.Windows.Forms.Label lbSet;
        private CCWin.SkinControl.SkinPanel Menu_UpadteIco;
        private CCWin.SkinControl.SkinPanel Menu_AboutIco;
        private CCWin.SkinControl.SkinPanel menu_SetICo;
        private CCWin.SkinControl.SkinPanel Menu_RepairIco;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton btnAddGame;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbStateText;
    }
}

