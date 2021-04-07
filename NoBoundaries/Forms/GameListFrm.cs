using NoBoundaries.Common;
using NoBoundaries.Model;
using NoBoundaries.MyControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries
{
    public partial class GameListFrm : BaseFrm
    {
        
        public GameListFrm()
        {
            InitializeComponent();
            this.panel.MouseWheel += new MouseEventHandler(FormSample_MouseWheel);//为panel添加滑动滚轮事件
        }

        private void GameListFrm_Load(object sender, EventArgs e)
        {
            panel.AutoScroll = true;
            CreatRes();
        }

        private void CreatRes()
        {
            string path = System.Environment.CurrentDirectory;
            string url = EncryptsHelper.Decrypt(ConfigurationManager.ConnectionStrings["GamesURL"].ToString());

            if (!Directory.Exists(path + @"\res"))//如果不存在就创建res文件夹
            {
                Directory.CreateDirectory(path + @"\res");
            }
            var allGame = Game.FindAll();
            for (int i = 0; i < allGame.Count; i++)
            {
                IconList iconList = new IconList();
                iconList.GameName = allGame[i].Name;
                iconList.gameCode = allGame[i].SerialCode;
                panel.Controls.Add(iconList);
            }
            //加载图片放入线程池中
            ThreadPool.QueueUserWorkItem(new WaitCallback(AddGameIcon));
        }

        private void AddGameIcon(object sender)
        {
            string path = System.Environment.CurrentDirectory;
            string url = EncryptsHelper.Decrypt(ConfigurationManager.ConnectionStrings["GamesURL"].ToString());
            foreach (IconList list in panel.Controls)
            {
                string iconpath = string.Format(path + @"\res\{0}.png", list.gameCode);
                if (!File.Exists(iconpath))
                {
                    NetWorkHelper.ImgSave(url + list.gameCode + ".png", iconpath);
                }
                list.Image = Image.FromFile(iconpath);
            }
        }
        private void btn_SysHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 鼠标滑动滚轮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormSample_MouseWheel(object sender, MouseEventArgs e)
        {
            //获取光标位置
            Point mousePoint = new Point(e.X, e.Y);
            //换算成相对本窗体的位置
            mousePoint.Offset(this.Location.X, this.Location.Y);
            //判断是否在panel内
            if (this.panel.RectangleToScreen(
              panel.DisplayRectangle).Contains(mousePoint))
            {
                //滚动
                panel.AutoScrollPosition = new Point(0, panel.VerticalScroll.Value - e.Delta);
            }

        }

        private void panel_Click(object sender, EventArgs e)
        {
            this.panel.Focus();
        }

        private void GameListFrm_MouseEnter(object sender, EventArgs e)
        {
            this.panel.Focus();
        }
    }
}
