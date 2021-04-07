using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NoBoundaries.Common
{
    public static class EncryptsHelper
    {
        private static string IV_641 = "Nj89ngXinSoftWare";
        private static string KEY_642 = "N23ingXinSoftWare";//注意了，是8个字符，64位
        private static string IV_643 = "NjQingXinSoftWare";
        private static string KEY_644 = "Nj67ngXinSoftWare";//注意了，是8个字符，64位
        private static string IV_645 = "NjOingXinSoitWar0";
        private static string KEY_064 = "NjO1n_XinSoftWare";//注意了，是8个字符，64位

        /// <summary> 
        /// 使用缺省密钥字符串加密 
        /// </summary> 
        /// <param name="original">明文</param> 
        /// <returns>密文</returns> 
        public static string Encrypt(string original)
        {
            return Encrypt(original, KEY_064);
        }
        /// <summary> 
        /// 使用缺省密钥解密 
        /// </summary> 
        /// <param name="original">密文</param> 
        /// <returns>明文</returns> 
        public static string Decrypt(string original)
        {
            return Decrypt(original, KEY_064, System.Text.Encoding.Default);
        }


        ///// <summary> 
        ///// 使用给定密钥解密 
        ///// </summary> 
        ///// <param name="original">密文</param> 
        ///// <param name="key">密钥</param> 
        ///// <returns>明文</returns> 
        //public static string Decrypt(string original, string key)
        //{
        //    return Decrypt(original, key, System.Text.Encoding.Default);
        //}

        ///// <summary> 
        ///// 使用缺省密钥解密,返回指定编码方式明文 
        ///// </summary> 
        ///// <param name="original">密文</param> 
        ///// <param name="encoding">编码方式</param> 
        ///// <returns>明文</returns> 
        //public static string Decrypt(string original, Encoding encoding)
        //{
        //    return Decrypt(original, "NjQingXinSoftWare", encoding);
        //}

        /// <summary> 
        /// 使用给定密钥加密 
        /// </summary> 
        /// <param name="original">原始文字</param> 
        /// <param name="key">密钥</param> 
        /// <param name="encoding">字符编码方案</param> 
        /// <returns>密文</returns> 
        public static string Encrypt(string original, string key)
        {
            if (original == null || original == string.Empty)
            {
                return string.Empty;
            }
            byte[] buff = System.Text.Encoding.Default.GetBytes(original);
            byte[] kb = System.Text.Encoding.Default.GetBytes(key);
            return Convert.ToBase64String(Encrypt(buff, kb));
        }

        /// <summary> 
        /// 使用给定密钥解密 
        /// </summary> 
        /// <param name="encrypted">密文</param> 
        /// <param name="key">密钥</param> 
        /// <param name="encoding">字符编码方案</param> 
        /// <returns>明文</returns> 
        public static string Decrypt(string encrypted, string key, Encoding encoding)
        {
            if (encrypted==null|| encrypted==string.Empty)
            {
                return string.Empty;
            }
            byte[] buff = Convert.FromBase64String(encrypted);
            byte[] kb = System.Text.Encoding.Default.GetBytes(key);
            return encoding.GetString(Decrypt(buff, kb));
        }

        /// <summary> 
        /// 生成MD5摘要 
        /// </summary> 
        /// <param name="original">数据源</param> 
        /// <returns>摘要</returns> 
        public static string MakeMD5(string original)
        {
            var strContent = System.Text.Encoding.ASCII.GetBytes(original);
            var byteArray = MakeMD5(strContent);
            return System.Text.Encoding.ASCII.GetString(byteArray);
        }

        /// <summary> 
        /// 生成MD5摘要 
        /// </summary> 
        /// <param name="original">数据源</param> 
        /// <returns>摘要</returns> 
        public static byte[] MakeMD5(byte[] original)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyhash = hashmd5.ComputeHash(original);
            hashmd5 = null;
            return keyhash;
        }

        /// <summary> 
        /// 使用给定密钥加密 
        /// </summary> 
        /// <param name="original">明文</param> 
        /// <param name="key">密钥</param> 
        /// <returns>密文</returns> 
        public static byte[] Encrypt(byte[] original, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
        }

        /// <summary> 
        /// 使用给定密钥解密数据 
        /// </summary> 
        /// <param name="encrypted">密文</param> 
        /// <param name="key">密钥</param> 
        /// <returns>明文</returns> 
        public static byte[] Decrypt(byte[] encrypted, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
        }

        /// <summary> 
        /// 使用给定密钥加密 
        /// </summary> 
        /// <param name="original">原始数据</param> 
        /// <param name="key">密钥</param> 
        /// <returns>密文</returns> 
        public static byte[] Encrypt(byte[] original)
        {
            byte[] key = System.Text.Encoding.Default.GetBytes(KEY_064);
            return Encrypt(original, key);
        }

        /// <summary> 
        /// 使用缺省密钥解密数据 
        /// </summary> 
        /// <param name="encrypted">密文</param> 
        /// <param name="key">密钥</param> 
        /// <returns>明文</returns> 
        public static byte[] Decrypt(byte[] encrypted)
        {
            byte[] key = System.Text.Encoding.Default.GetBytes(KEY_064);
            return Decrypt(encrypted, key);
        }

        //加
        public static string Encry(string express, string machineCode)
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = (machineCode + "zsyf").Substring(3, 11);//密匙容器的名称，保持加密解密一致才能解密成功
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] plaindata = Encoding.Default.GetBytes(express);//将要加密的字符串转换为字节数组
                    byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                    return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        //解
        public static string Decrypt(string ciphertext, string machineCode)
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = (machineCode + "zsyf").Substring(3, 11);
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] encryptdata = Convert.FromBase64String(ciphertext);
                    byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                    return Encoding.Default.GetString(decryptdata);
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static string M5Encry(string express)
        {
            try
            {
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] plaindata = Encoding.Default.GetBytes(express);//将要加密的字符串转换为字节数组
                    byte[] encryptdata = md5.ComputeHash(plaindata);//将加密后的字节数据转换为新的加密字节数组
                    return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
