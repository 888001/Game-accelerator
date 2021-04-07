using NoBoundaries.Common;
using NoBoundaries.Model;
using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NoBoundaries
{
    public partial class ChooseLineFrm : BaseFrm
    {
        /// <summary>
        /// 节点名称,节点地址
        /// </summary>
        Dictionary<string, string> ssList;
        public ChooseLineFrm()
        {
            InitializeComponent();
        }

        private void btn_SysClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChooseLine_Load(object sender, EventArgs e)
        {
            ssList = new Dictionary<string, string>();//字典需要初始化才能赋值
            var listAll = ShadowsocksR.FindAll(Shadowsocks._.State,"启用");
            foreach (var list in listAll) 
            {
                ssList.Add(EncryptsHelper.Decrypt(list.HostName), list.Remark);
            }
            if (ssList.Count > 0) 
            {
                for (int i = 0; i < ssList.Count; i++)
                {
                    SkinListBoxItem item = new SkinListBoxItem(ssList.ElementAt(i).Value);
                    item.Tag = ssList.ElementAt(i).Key;
                    skinListBox1.Items.Add(item);
                }
            }
            TestIP();
            timer1.Enabled = true;
        }

        #region 每10秒测一次延迟
        /// <summary>
        /// 测试延迟
        /// </summary>
        private void TestIP() 
        {
            Task.Run(new Action(() =>
            {
                foreach (SkinListBoxItem item in skinListBox1.Items)
                {
                    string hostname = item.Tag.ToString();
                    string remark = ssList[hostname];
                    string result = NetWorkHelper.GetIPPing(hostname);
                    item.Text = remark + "    " + result + " ms";
                }
            }));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TestIP();
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (skinListBox1.SelectedItem == null)
            {
                Close();
            }
            else 
            {
                SkinListBoxItem item = skinListBox1.SelectedItem as SkinListBoxItem;
                string hostname = EncryptsHelper.Encrypt(item.Tag.ToString());
                ShadowsocksR ss= ShadowsocksR.Find(ShadowsocksR._.HostName==hostname);
                if (ss != null)
                {
                    MainFrm.shadowsocksR = ss;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else 
                {
                    CCWin.MessageBoxEx.Show("节点选择异常,请稍后重试!", "提示");
                    Close();
                }
            }
        }

        private void skinListBox1_DoubleClick(object sender, EventArgs e)
        {
            if(skinListBox1.SelectedItem != null)
            {
                SkinListBoxItem item = skinListBox1.SelectedItem as SkinListBoxItem;
                string hostname = EncryptsHelper.Encrypt(item.Tag.ToString());
                ShadowsocksR ssR = ShadowsocksR.Find(ShadowsocksR._.HostName == hostname);
                if (ssR != null)
                {
                    MainFrm.shadowsocksR = ssR;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    CCWin.MessageBoxEx.Show("节点选择异常,请稍后重试!", "提示");
                    Close();
                }
            }
        }
    }
}
