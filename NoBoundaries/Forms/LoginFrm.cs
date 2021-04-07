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
    public partial class LoginFrm : BaseFrm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btn_SysClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new RegisterFrm().ShowDialog();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            skinCheckBox1.Checked=MySetting.Default.RemmberUser;
            skinCheckBox2.Checked = MySetting.Default.AutoLogin;
            if (MySetting.Default.RemmberUser) 
            {
                if (MySetting.Default.UserID!=string.Empty||MySetting.Default.UserPwd!=string.Empty)
                {
                    tbUserID.Text = MySetting.Default.UserID;
                    tbUserPwd.Text = EncryptsHelper.Decrypt(MySetting.Default.UserPwd);
                }
                else
                {
                    tbUserID.Text = string.Empty;
                    tbUserPwd.Text = string.Empty;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = tbUserID.Text.Trim();
                string userpwd = tbUserPwd.Text.Trim();
                User user = User.Find(User._.UserId == userid & User._.UserPwd == EncryptsHelper.Encrypt(userpwd));
                if (user == null)
                {
                    CCWin.MessageBoxEx.Show("用户名或密码错误,请重新输入!", "提示;");
                    this.DialogResult = DialogResult.No;
                    return;
                }

                user.LoginCount++;
                user.Update();
                MainFrm.user = user;
                this.DialogResult = DialogResult.OK;
                if (MySetting.Default.RemmberUser) 
                {
                    MySetting.Default.UserID = user.UserId;
                    MySetting.Default.UserPwd = user.UserPwd;
                }
                MySetting.Default.RemmberUser = skinCheckBox1.Checked;
                MySetting.Default.AutoLogin = skinCheckBox2.Checked;
                MySetting.Default.Save();
            }
            catch (Exception ex)
            {
                CCWin.MessageBoxEx.Show("登录出现异常,请稍后重试!", "提示;");
            }
        }
    }
}
