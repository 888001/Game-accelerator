using NoBoundaries.Common;
using NoBoundaries.Model;
using NoBoundaries.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries.Controllers
{
    public class TUNTAPController
    {
        public Process NoBoundaries;
        public TUNTAPController()
        {
            
        }
        public bool Start()
        {
            string TUNTAPaddress = "10.0.0.2";
            string TUNTAPgw = "10.0.0.1";
            string hostName = "127.0.0.1";
            string port = "2801";

            // 查找并安装 TAP 适配器
            if (string.IsNullOrEmpty(TUNTAP.GetComponentID()))
            {
                //CCWin.MessageBoxEx.Show("未检测到虚拟网卡驱动,驱动即将自动安装,请在弹出的窗口内点击'始终安装此驱动程序软件',并重新加速!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TUNTAP.addtap();
            }
            string path = System.Environment.CurrentDirectory;
            if (!Directory.Exists(path + @"\bin"))//如果不存在就创建bin文件夹
            {
                Directory.CreateDirectory(path + @"\bin");
            }
            if (!File.Exists(path + @"\bin\Accelerator.exe"))//tun2socks.exe不存在就从资源导出
            {
                CCWin.MessageBoxEx.Show("驱动文件丢失,请重新安装本软件!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string url = EncryptsHelper.Decrypt(ConfigurationManager.ConnectionStrings["GamesURL"].ToString());
            string tempParh = Path.GetTempPath();
            string routepath = tempParh + "routetmp.txt";
            if (File.Exists(tempParh + "routetmp.txt")) File.Delete(tempParh + "routetmp.txt");
            NetWorkHelper.RoutetxtSave(url + MainFrm.CurrentGame.SerialCode + ".txt", routepath);
            if (!File.Exists(tempParh + "routetmp.txt"))
            {
                CCWin.MessageBoxEx.Show("获取路由表文件失败,请联系开发者!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Task.Run(() =>
            {
                //修改路由表文件
                string routeif = TUNTAPController.GetIF().ToString();
                //防止文本字符中有特殊字符。必须用Encoding.Default
                StreamReader reader = new StreamReader(tempParh + "routetmp.txt", Encoding.Default);
                String a = reader.ReadToEnd();
                a = a.Replace("IFZ", $"{routeif}");//替换IF值
                StreamWriter readTxt = new StreamWriter(tempParh + "routetmp1.txt", false, Encoding.Default);
                readTxt.Write(a);
                readTxt.Flush();
                readTxt.Close();
                reader.Close();
                File.Copy(tempParh + "routetmp1.txt", tempParh + "routetmp.txt", true);
                File.Delete(tempParh + "routetmp1.txt");
            });
            var argument = new StringBuilder();
            //argument.Append(
            //    $"-tunAddr {TUNTAPaddress} -tunGw {TUNTAPgw} -dnsServer 8.8.8.8,8.8.4.4 -proxyType shadowsocks -proxyServer {hostName}:{port} " +
            //    $"-proxyCipher {method} -proxyPassword {pwd}");
            argument.Append(
    $"-tunAddr {TUNTAPaddress} -tunGw {TUNTAPgw} -dnsServer 8.8.8.8,8.8.4.4 -proxyServer {hostName}:{port} " );

            NoBoundaries = new Process();
            NoBoundaries.StartInfo.FileName = path + @"\bin\Accelerator.exe";
            NoBoundaries.StartInfo.Arguments = argument.ToString();
            NoBoundaries.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            NoBoundaries.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            NoBoundaries.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            NoBoundaries.StartInfo.CreateNoWindow = true;//不显示程序窗口
            NoBoundaries.Start();
            return true;

        }

        public static int GetIF() 
        {
            var list = NetworkInterface.GetAllNetworkInterfaces().First(_ => _.Id == TUNTAP.GetComponentID());
            return(list.GetIPProperties().GetIPv4Properties().Index);
        }
        /// <summary>
        /// 生成删除路由表文件
        /// </summary>
        public static void CreatDelRoute() 
        {
            Task.Run(()=> 
            {
                string tempParh = Path.GetTempPath();
                //生成删除路由的文件
                File.Copy(tempParh + "routetmp.txt", tempParh + "routetmp1.txt", true);
                //防止文本字符中有特殊字符。必须用Encoding.Default
                StreamReader dereader = new StreamReader(tempParh + "routetmp1.txt", Encoding.Default);
                String b = dereader.ReadToEnd();
                b = b.Replace("add", "delete");
                StreamWriter dereadTxt = new StreamWriter(tempParh + "routetmp.txt", false, Encoding.Default);
                dereadTxt.Write(b);
                dereadTxt.Flush();
                dereadTxt.Close();
                dereader.Close();
                File.Delete(tempParh + "routetmp1.txt");
            });

        }
    }
}
