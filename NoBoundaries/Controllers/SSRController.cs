using NoBoundaries.Common;
using NoBoundaries.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoBoundaries.Controllers
{
    public class SSRController
    {
        public Process Utils;
        public ShadowsocksR ssr;
        public SSRController(ShadowsocksR ssrr)
        {
            ssr = ssrr;
        }
        public bool Start()
        {
            string HostName = EncryptsHelper.Decrypt(ssr.HostName);
            string Port = EncryptsHelper.Decrypt(ssr.Port);
            string Password = EncryptsHelper.Decrypt(ssr.Password);
            string Method = EncryptsHelper.Decrypt(ssr.Method);
            string Protocol = EncryptsHelper.Decrypt(ssr.Protocol);
            string ProtocolParam = EncryptsHelper.Decrypt(ssr.ProtocolParam);
            string Obfs = EncryptsHelper.Decrypt(ssr.Obfs);
            string OBFSParam = EncryptsHelper.Decrypt(ssr.OBFSParam);

            string arguments = $"-s {HostName} -p {Port} -k \"{Password}\" -m {Method} -t 120 -b 127.0.0.1 -l 2801 -u";
            if(!string.IsNullOrEmpty(Protocol))
            {
                arguments += $" -O {Protocol}";
                if(!string.IsNullOrEmpty(ProtocolParam)) arguments += $" -G \"{ProtocolParam}\"";
            }
            if (!string.IsNullOrEmpty(Obfs))
            {
                arguments += $" -o {Obfs}";
                if (!string.IsNullOrEmpty(OBFSParam)) arguments += $" -g \"{OBFSParam}\"";
            }
            Console.WriteLine(arguments);
            string path = System.Environment.CurrentDirectory;
            if (!File.Exists(path + @"\bin\Utils.exe"))//判断SSR是否存在
            {
                CCWin.MessageBoxEx.Show("驱动文件不存在,请重新安装解决此问题!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Utils = new Process();
            Utils.StartInfo.FileName = path + @"\bin\Utils.exe";
            Utils.StartInfo.Arguments = arguments.ToString();
            Utils.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            Utils.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            Utils.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            Utils.StartInfo.CreateNoWindow = true;//不显示程序窗口
            Utils.Start();
            return true;
        }
    }
}
