
using NoBoundaries.Common;
using NoBoundaries.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isRuned;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "OnlyRunOneInstance", out isRuned);
            if (!isRuned)
            {
                CCWin.MessageBoxEx.Show("另一个风雪加速器客户端已经在运行了哦,请勿重复开启！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            #region 配置数据库连接字符串
            string NoBoundaries = ConfigurationManager.ConnectionStrings["NoBoundaries"].ToString();
            XCode.DataAccessLayer.DAL.AddConnStr("NoBoundaries", EncryptsHelper.Decrypt(NoBoundaries),null, "SqlServer");
            NewLife.Setting.Current.LogLevel = NewLife.Log.LogLevel.Error;
            XCode.Setting.Current.Debug = false;
            XCode.Setting.Current.ShowSQL = false;
            #endregion

            string path = System.Environment.CurrentDirectory;
            if (!Directory.Exists(path + @"\bin"))//如果不存在就创建bin文件夹
            {
                Directory.CreateDirectory(path + @"\bin");
            }
            if (!Directory.Exists(path + @"\res"))//如果不存在就创建res文件夹
            {
                Directory.CreateDirectory(path + @"\res");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
            mutex.ReleaseMutex();
        }

       
        
    }
}
