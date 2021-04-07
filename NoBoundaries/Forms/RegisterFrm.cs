using NoBoundaries.Common;
using NoBoundaries.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries
{
    public partial class RegisterFrm : BaseFrm
    {
        public RegisterFrm()
        {
            InitializeComponent();
        }

        private void btn_SysClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbUserPwd.Text == "" | tbUserID.Text.Length<6 | tbPwd2.Text == "") 
            {
                CCWin.MessageBoxEx.Show("账号长度不够或输入信息为空,请重新输入!","提示:");
                return;
            }
            if (tbUserPwd.Text.Trim() != tbPwd2.Text.Trim()) 
            {
                CCWin.MessageBoxEx.Show("两次密码输入不一致,请重新输入!", "提示:");
                tbUserPwd.Text = "";
                tbPwd2.Text = "";
                return;
            }
            var user = User.Find(User._.UserId == tbUserID.Text.Trim());
            if (user != null) 
            {
                CCWin.MessageBoxEx.Show("此账号已被注册,请重新输入!", "提示:");
                tbUserID.Text = "";
                return;
            }
            new User
            {
                SerialCode = Guid.NewGuid().ToString("N"),
                UserId = tbUserID.Text.Trim(),
                UserPwd = EncryptsHelper.Encrypt(tbUserPwd.Text.Trim()),
                UserType = 1,
                CreatTime = DBManager.Instance.GetCruTime(),
                LoginCount = 0
            }.Save();
            CCWin.MessageBoxEx.Show("注册成功!", "提示:");
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
