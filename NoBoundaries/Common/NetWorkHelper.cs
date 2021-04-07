using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoBoundaries.Common
{
    public static class NetWorkHelper
    {
        public static string GetIPPing(string ip) 
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            //测试数据
            string data = "";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            //设置超时时间
            int timeout = 120;
            //调用同步 send 方法发送数据,将返回结果保存至PingReply实例
            PingReply reply = pingSender.Send(ip, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                return reply.RoundtripTime.ToString();
            }
            else
            {
                return GetIPPing(ip);
            }
        }

        /// <summary>
        /// 从url下载图片
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path">保存的路径</param>
        public static void ImgSave(string url,string path) 
        {
            try
            {
                WebClient webClient = new WebClient();
                Byte[] imgData = webClient.DownloadData(url);
                Stream ms = new MemoryStream(imgData);
                ms.Position = 0;
                Image img = Image.FromStream(ms);
                img.Save(path, ImageFormat.Png);
            }
            catch (Exception ex) 
            {
                CCWin.MessageBoxEx.Show(ex.Message);
            }

        }

        /// <summary>
        /// 下载路由表txt文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public static void RoutetxtSave(string url,string path)
        {
            try
            {
                HttpWebRequest oHttp_Web_Req = (HttpWebRequest)WebRequest.Create(url);
                Stream oStream = oHttp_Web_Req.GetResponse().GetResponseStream();
                using (StreamReader respStreamReader = new StreamReader(oStream, Encoding.UTF8))
                {
                    string line = string.Empty;
                    while ((line = respStreamReader.ReadLine()) != null)
                    {

                        UTF8Encoding utf8 = new UTF8Encoding(false);
                        //写txt文件
                        using (StreamWriter sw = new StreamWriter(path, true, utf8))
                        {
                            if(!File.Exists(path))
                            {
                                File.Delete(path);
                            }
                            sw.WriteLine(line);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
