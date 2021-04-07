using NoBoundaries.Common;
using NoBoundaries.Controllers;
using NoBoundaries.Model;
using CCWin.SkinClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoBoundaries.Utils;

namespace NoBoundaries
{
    public partial class MainFrm : BaseFrm
    {
        public  delegate void CurrentGameChange(Game game);
        public static event CurrentGameChange onCurrentGameChange;

        public static User user;//当前登录账户

        public static ShadowsocksR shadowsocksR;//当前选中节点

        public static Game currentGame;//当前游戏
        public static Game CurrentGame 
        {
            get { return currentGame; }
            set 
            {
                //if (currentGame != value || currentGame != null)
                //{
                //    currentGame = value;
                //    MainFrm.onCurrentGameChange(currentGame);
                //}
                ////currentGame = value;
                currentGame = value;
                MainFrm.onCurrentGameChange(currentGame);
            }
        }

        public SSRController ssrController { get; set; }
        public TUNTAPController TUNTAPController { get; set; }

        public static List<string> mygames=new List<string>();

        public GameListFrm gameListFrm =new GameListFrm();

        public MainFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当当前选定游戏被改变触发事件
        /// </summary>
        /// <param name="game"></param>
        public void CurretGameChanged(Game game) 
        {
            string path = System.Environment.CurrentDirectory;
            try
            {
                if (game == null) 
                {
                    return;
                }
                Image image = Image.FromFile(path + @"\res\" + CurrentGame.SerialCode + ".png");
                panel_CurrentGameIco.BackgroundImage = image;
                lbCurrentGameName.Text = game.Name;
                gameListFrm.Hide();
            }
            catch (Exception ex)
            {
            }
        }
        private void btn_SysClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SysMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbStart_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            if (label.Tag.ToInt32() == 1)
            {
                label.ForeColor = Color.IndianRed;
            }
            else
            {
                label.ForeColor = Color.DarkGray;
            }
        }

        private void lbUser_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.LightGreen;
        }

        private void lbUser_MouseDown(object sender, MouseEventArgs e)
        {
            lbUser.ForeColor = Color.ForestGreen;
        }

        private void lbUser_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.LimeGreen;
        }

        private void btn_SysMin_MouseDown(object sender, MouseEventArgs e)
        {
            btn_SysMin.ForeColor = Color.Gray;
        }

        private void btn_SysMenu_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Visible)
            {
                panel_Menu.Visible = false;
            }
            else
            {
                panel_Menu.Visible = true;
            }
        }

        private void btnLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Tag.ToInt32() == 1)
            {
                label.ForeColor = Color.Red;
            }
            else 
            {
                label.ForeColor = Color.DimGray;
            }
            
        }

        private void btnLabel_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Tag.ToInt32() == 1)
            {
                label.ForeColor = Color.DarkRed;
            }
            else
            {
                label.ForeColor = Color.LightGray;
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Guid.NewGuid().ToString("N"));
            LoadingData();
            onCurrentGameChange += CurretGameChanged;
            Console.WriteLine(IsWin10());

            panel_Menu.Visible = false;//菜单隐藏

            //放在 LoadingData() 方法里就抛异常
            if (MySetting.Default.MyGamesRecord == null || MySetting.Default.MyGamesRecord == "")
            {
                CurrentGame = null;
            }
            else
            {
                CurrentGame = Game.Find(Game._.SerialCode == MySetting.Default.MyGamesRecord);
            }
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadingData() 
        {
            try
            {    //自动登录账号
                if (MySetting.Default.AutoLogin)
                {
                    if (MySetting.Default.UserID != string.Empty || MySetting.Default.UserID != "" && MySetting.Default.UserPwd != string.Empty || MySetting.Default.UserPwd != "")
                    {
                        var login = User.Find(User._.UserId == MySetting.Default.UserID & User._.UserPwd == MySetting.Default.UserPwd);
                        if (login != null)
                        {
                            user = login;
                            lbUser.Text = $"尊敬的用户 {login.UserId}";
                            lbUser.Click -= null;
                            login.LoginCount++;
                            login.Update();
                        }

                    }
                }
                panel_None.Visible = true;
               
            }
            catch (Exception ex) 
            {
            }
        }

        /// <summary>
        /// 登录账号按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUser_Click(object sender, EventArgs e)
        {
            try
            {
                panel_Menu.Visible = false;
                LoginFrm loginFrm = new LoginFrm();
                var result = loginFrm.ShowDialog();
                if (result == DialogResult.No) 
                {
                    user = null;
                    lbUser.Text = "尚未登陆";
                }
                if (result == DialogResult.OK)
                {
                    string username= user.UserId;
                    lbUser.Text = $"尊敬的用户 {username}";
                    lbUser.Click -= null;
                }
            }
            catch (Exception ex)
            {
                CCWin.MessageBoxEx.Show("登录出错,请稍后重试!","错误:",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbSet_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            Console.WriteLine(lbSet.Text);
        }

        private void lbRepair_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            Console.WriteLine(lbRepair.Text);
        }

        private void lbUpdate_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            Console.WriteLine(lbUpdate.Text);
        }

        private void lbAbout_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            System.Diagnostics.Process.Start("https://www.zsyf.link/");
        }

        private void lbLoginout_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            if (user != null) 
            {
                user = null;
                lbUser.Text = "尚未登录";
            }
        }

        private void lbStart_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            if (lbStart.Tag.ToInt32() == 0)//未加速状态
            {
                if (user == null)
                {
                    CCWin.MessageBoxEx.Show("请先登录账号!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (CurrentGame == null)
                {
                    CCWin.MessageBoxEx.Show("请先选择需要加速的游戏!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (shadowsocksR == null)
                {
                    new ChooseLineFrm().ShowDialog();
                    if (shadowsocksR == null)
                    {
                        return;
                    }
                    lbChooseLine.Text = shadowsocksR.Remark;
                    timer1.Enabled = true;
                    TestLine();
                }
                KillController();
                lbStart.Text = "请稍等...";
                lbChooseLine.Enabled = false;
                ssrController = new SSRController(shadowsocksR);
                if (ssrController.Start())
                {
                    TUNTAPController = new TUNTAPController(); 
                    lbStateText.ForeColor = Color.LimeGreen;
                    lbStateText.Text = "正在初始化环境...";
                    Application.DoEvents();
                }
                else
                {
                    CCWin.MessageBoxEx.Show("加速失败,请重新启动!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbStateText.ForeColor = Color.Red;
                    lbStateText.Text = "初始化程序错误...";
                    lbStart.ForeColor = Color.DimGray;
                    lbStart.Text = "一键加速";
                    lbStart.Tag = 0;
                    AddRouteList();
                    lbStateText.ForeColor = Color.Red;
                    lbStateText.Text = "初始化程序错误...";
                    btnAddGame.Enabled = true;
                    lbChooseGame.Enabled = true;
                    lbChooseLine.Enabled = true;
                    return;
                }

                if (TUNTAPController.Start())
                {
                    AddRouteList();
                    lbStart.ForeColor = Color.Red;
                    lbStart.Text = "断开连接";
                    lbStart.Tag = 1;
                    timer2.Enabled = true;
                    lbStateText.Text = "已成功连接线路";
                    btnAddGame.Enabled = false;
                    lbChooseGame.Enabled = false;

                }
                else
                {
                    lbStart.ForeColor = Color.DimGray;
                    lbStart.Text = "一键加速";
                    lbStart.Tag = 0;
                    AddRouteList();
                    lbStateText.ForeColor = Color.Red;
                    lbStateText.Text = "初始化程序错误...";
                    btnAddGame.Enabled = true;
                    lbChooseGame.Enabled = true;
                    lbChooseLine.Enabled = true;
                }
            }
            else if (lbStart.Tag.ToInt32() == 1)
            {
                timer2.Enabled = false;
                KillController();
                TUNTAPController.CreatDelRoute();

                lbStart.ForeColor = Color.DimGray;
                lbStart.Text = "一键加速";
                lbStart.Tag = 0;
                lbStateText.Text = "断开连接成功";
                AddRouteList();
                btnAddGame.Enabled = true;
                lbChooseGame.Enabled = true;
                lbChooseLine.Enabled = true;
            }
        }
        /// <summary>
        /// 关闭tun2socks进程
        /// </summary>
        private void KillController() 
        {
            try
            {
                Process[] processList = Process.GetProcessesByName("Accelerator");
                foreach (Process p in processList)
                {
                    p.Kill();
                }
                Process[] processList2 = Process.GetProcessesByName("Utils");
                foreach (Process p in processList2)
                {
                    p.Kill();
                }
            }
            catch (Exception ex)
            {
            }

        }
      
        /// <summary>
        /// 更换线路按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbChooseLine_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            var resault=new ChooseLineFrm().ShowDialog();
            if (resault == DialogResult.OK) 
            {
                lbChooseLine.Text = shadowsocksR.Remark;
                timer1.Enabled = true;
                TestLine();
            }
        }
        /// <summary>
        /// 当选择节点后,每10秒测试一次节点延迟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            TestLine();
            timer1.Enabled = true;
        }
        /// <summary>
        /// 测试节点延迟
        /// </summary>
        private void TestLine() 
        {
            Task.Run(new Action(() =>
            {
                string hostname = EncryptsHelper.Decrypt(shadowsocksR.HostName);
                int result = int.Parse(NetWorkHelper.GetIPPing(hostname));
                if (result > 0 && result < 100)
                {
                    lbPingText.ForeColor = Color.LimeGreen;
                }
                else if (result > 90 && result < 200)
                {
                    lbPingText.ForeColor = Color.Yellow;
                }
                else if (result == 0 || result >= 200)
                {
                    lbPingText.ForeColor = Color.Red;
                }
                if (lbPingText.InvokeRequired)
                {
                    lbPingText.BeginInvoke(new Action(() => 
                    {
                        lbPingText.Text = result.ToString() + " ms";
                    }));
                }
            }));
            
        }

        private void panel_GameList_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            gameListFrm.StartPosition = FormStartPosition.Manual;
            gameListFrm.Left = this.Left + this.Width;
            gameListFrm.Top = this.Top;
            if (gameListFrm.Visible == false) gameListFrm.Show();
            else gameListFrm.Hide();

        }

        /// <summary>
        /// 游戏列表窗体始终跟随主窗体移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Move(object sender, EventArgs e)
        {
            gameListFrm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            Process[] processList = Process.GetProcessesByName("Accelerator");
            Process[] processList2 = Process.GetProcessesByName("Utils");
            if (processList.Length == 0| processList2.Length==0)
            {
                timer2.Enabled = false;
                lbStateText.ForeColor = Color.Red;
                lbStateText.Text = "加速异常";
                lbStart.Tag = 0;
                lbStart.ForeColor = Color.DimGray;
                btnAddGame.Enabled = true;
                lbChooseGame.Enabled = true;
                lbStart.Text = "一键加速";
                lbChooseLine.Enabled = true;
                CCWin.MessageBoxEx.Show("加速出现异常,请重新加速!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            timer2.Enabled = true;
        }

        private void lbChooseGame_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            gameListFrm.StartPosition = FormStartPosition.Manual;
            gameListFrm.Left = this.Left + this.Width;
            gameListFrm.Top = this.Top;
            if (gameListFrm.Visible == false) gameListFrm.Show();
            else gameListFrm.Hide();
        }

        /// <summary>
        /// 添加删除路由表
        /// </summary>
        private void AddRouteList() 
        {
            string tempParh = Path.GetTempPath();
            //string path = System.Environment.CurrentDirectory;
            if (!File.Exists(tempParh + "cmroute.dll"))
            {
                byte[] bytes = new byte[Properties.Resources.cmroute.Length];
                Properties.Resources.cmroute.CopyTo(bytes, 0);
                FileStream fileStream = new FileStream(tempParh + "cmroute.dll", FileMode.Create, FileAccess.Write);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
            }
            if (!File.Exists(tempParh + "Execute.bat"))
            {
                string fileContent = Properties.Resources.Execute;
                FileStream fs1 = new FileStream(tempParh + "Execute.bat", FileMode.Create, FileAccess.Write);//创建写入文件
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(fileContent);//开始写入值
                sw.Close();
                fs1.Close();
            }
            //if (!File.Exists(path + "/res/Elevation.cmd"))
            //{
            //    string fileContent = Properties.Resources.Elevation;
            //    FileStream fs1 = new FileStream(path + "/res/Elevation.cmd", FileMode.Create, FileAccess.Write);//创建写入文件
            //    StreamWriter sw = new StreamWriter(fs1);
            //    sw.WriteLine(fileContent);//开始写入值
            //    sw.Close();
            //    fs1.Close();
            //}
            //Process p = new Process();
            //p.StartInfo.FileName = path + "/res/Elevation.cmd";//win7无效
            ////p.StartInfo.Verb = "runas";
            //p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            //p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            //p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            //p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            //p.StartInfo.CreateNoWindow = true;//不显示程序窗口

            Process p2 = new Process();
            p2.StartInfo.FileName = tempParh + "Execute.bat";

            p2.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p2.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p2.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p2.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p2.StartInfo.CreateNoWindow = true;//不显示程序窗口

            //if (IsWin10()) p.Start();//启动程序
            //else 
            //{
            //    p2.Start();//win10运行这个会报错
            //    p.Start();//启动程序
            //}
            p2.Start();
            Thread.Sleep(2000);
            //File.Delete(path + "/res/Elevation.cmd");
            File.Delete(tempParh + "cmroute.dll");
            File.Delete(tempParh + "/Execute.bat");
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lbStart.Tag.ToInt() == 1)
            {
                KillController();
                AddRouteList();
            }
        }
        /// <summary>
        /// 判断是否是win10
        /// </summary>
        /// <returns></returns>
        private bool IsWin10() 
        {
            //获取操作系统平台的PlatformID枚举值
            PlatformID _PlatformID = Environment.OSVersion.Platform;
            //获取系统版本号
            int Version = Environment.OSVersion.Version.Major;
            if (_PlatformID == PlatformID.Win32NT && Version == 10) return true;
            else return false;
        }
    }
}
