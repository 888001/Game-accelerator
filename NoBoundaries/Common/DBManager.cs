using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBoundaries.Common
{
    class DBManager
    {
        private static DBManager instance;
        private XCode.DataAccessLayer.DAL dal = null;
        private string[] NumChineseCharacter;

        /// <summary>
        /// 唯一实例化一次对象
        /// </summary>
        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBManager();
                }

                return instance;
            }
        }

        public DBManager()
        {
            dal = XCode.DataAccessLayer.DAL.Create("NoBoundaries");
        }

        public DateTime GetCruTime()
        {
            var dt = ListBySql("SELECT GETDATE()");
            if (dt != null && dt.Rows.Count == 1)
            {
                DateTime theTime = Convert.ToDateTime(dt.Rows[0][0]);
                return theTime;
            }
            else
            {
                return DateTime.Now;
            }
        }

        public DataTable ListBySql(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = dal.Session.Query(sql);
            }
            catch (Exception)
            {
                return null;
            }
            return ds.Tables[0];
        }
        public bool Execute(string sql)
        {
            bool result = true;
            try
            {
                if (dal.Session.Execute(sql) > 0)
                {
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            return result;
        }


        public bool Execute(string sql, SqlParameter[] theParams)
        {
            bool result = true;
            try
            {
                if (dal.Session.Execute(sql, CommandType.Text, theParams) > 0)
                {

                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            return result;
        }

        public bool ExecuteSqls3(string SQLStringList)
        {
            SQLStringList = SQLStringList.Replace("；", ";");
            try
            {
                string[] array = SQLStringList.Split(new char[]
                {
                    '&'
                });
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    if (text.Trim() != "")
                    {
                        dal.Session.Execute(text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool ExecuteSqls4(string SQLStringList)
        {
            SQLStringList = SQLStringList.Replace("；", ";");
            try
            {
                string[] array = SQLStringList.Split(new char[]
                {
                    '￥'
                });
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    if (text.Trim() != "")
                    {
                        dal.Session.Execute(text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool ExecuteSqls(string SQLStringList)
        {
            SQLStringList = SQLStringList.Replace("；", ";");
            try
            {
                string[] array = SQLStringList.Split(new char[]
                {
                    ';'
                });
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    if (text.Trim() != "")
                    {
                        dal.Session.Execute(text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool ExecuteSqls2(string SQLStringList)
        {
            SQLStringList = SQLStringList.Replace("：", ":");
            try
            {
                string[] array = SQLStringList.Split(new char[]
                {
                    ':'
                });
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    if (text.Trim() != "")
                    {
                        dal.Session.Execute(text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public void BeginTrans()
        {
            dal.Session.BeginTransaction(IsolationLevel.Serializable);
        }
        public bool Rollback()
        {
            dal.Session.Rollback();
            return true;
        }
        public bool Commit()
        {
            bool result = true;
            try
            {
                dal.Session.Commit();
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            return result;
        }

        public string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            return DateTime2.Subtract(DateTime1).Days.ToString();
        }

        public string ConvertToChin(string str_num)
        {
            string[] array = str_num.Split(new char[]
            {
                '.'
            });
            string text;
            if (array.Length == 1)
            {
                text = this.NumberString(array[0]) + "元整";
                text = text.Replace("零零", "零");
            }
            else
            {
                text = this.NumberString(array[0]) + "元";
                text += this.FloatString(array[1]);
                text = text.Replace("零零", "零");
            }
            return text;
        }
        private string FloatString(string Num)
        {
            if (Num.Length > 2)
            {
                throw new FormatException("小数位数过多.");
            }
            string text = this.ConvertString(Num);
            int num = text.IndexOf("零");
            string text2;
            if (num != 0)
            {
                text = text.Replace("零", "");
                if (text.Length == 1)
                {
                    text2 = text.Substring(0, 1) + "角整";
                }
                else
                {
                    text2 = text.Substring(0, 1) + "角";
                    text2 = text2 + text.Substring(1, 1) + "分";
                }
            }
            else
            {
                text2 = text + "分";
            }
            return text2;
        }
        private string NumberString(string Num)
        {
            string text = "";
            if (Num.Length <= 4)
            {
                text = this.Convert4(Num);
            }
            else
            {
                if (Num.Length > 4 && Num.Length <= 8)
                {
                    text = this.Convert4(Num.Substring(0, Num.Length - 4)) + "万";
                    text += this.Convert4(Num.Substring(Num.Length - 4, 4));
                }
                else
                {
                    if (Num.Length > 8 && Num.Length <= 12)
                    {
                        text = this.Convert4(Num.Substring(0, Num.Length - 8)) + "亿";
                        if (this.Convert4(Num.Substring(Num.Length - 8, 4)) == "")
                        {
                            if (this.Convert4(Num.Substring(Num.Length - 4, 4)) != "")
                            {
                                text += "零";
                            }
                            else
                            {
                                text += "";
                            }
                        }
                        else
                        {
                            text = text + this.Convert4(Num.Substring(Num.Length - 8, 4)) + "万";
                        }
                        text += this.Convert4(Num.Substring(Num.Length - 4, 4));
                    }
                }
            }
            return text;
        }
        private string Convert4(string Num)
        {
            string text;
            if (Num.Length == 1)
            {
                text = this.ConvertString(Num);
            }
            else
            {
                if (Num.Length == 2)
                {
                    text = this.ConvertString(Num);
                    text = this.Convert2(text);
                }
                else
                {
                    if (Num.Length == 3)
                    {
                        text = this.ConvertString(Num);
                        text = this.Convert3(text);
                    }
                    else
                    {
                        text = this.ConvertString(Num);
                        string text2 = text.Substring(0, 4);
                        if (text2 != "零零零零")
                        {
                            text2 = text.Substring(0, 3);
                            if (text2 != "零零零")
                            {
                                text = text.Replace("零零零", "");
                                if (text.Length == 1)
                                {
                                    text = text.Substring(0, 1) + "仟";
                                }
                                else
                                {
                                    string str;
                                    if (text.Substring(0, 1) != "零" && text.Substring(0, 2) != "零")
                                    {
                                        str = text.Substring(0, 1) + "仟";
                                    }
                                    else
                                    {
                                        str = text.Substring(0, 1);
                                    }
                                    text = str + this.Convert3(text.Substring(1, 3));
                                }
                            }
                            else
                            {
                                text = text.Replace("零零零", "零");
                            }
                        }
                        else
                        {
                            text = text.Replace("零零零零", "");
                        }
                    }
                }
            }
            return text;
        }
        private string ConvertString(string Num)
        {
            string text = "";
            for (int i = 0; i < Num.Length; i++)
            {
                text += this.NumChineseCharacter[int.Parse(Num.Substring(i, 1))];
            }
            return text;
        }
        private string Convert2(string Num)
        {
            string text = Num.Substring(0, 1);
            string text3;
            if (text != "零")
            {
                string text2 = Num.Replace("零", "");
                if (text2.Length == 1)
                {
                    text3 = text2.Substring(0, 1) + "拾";
                }
                else
                {
                    text3 = text2.Substring(0, 1) + "拾";
                    text3 += text2.Substring(1, 1);
                }
            }
            else
            {
                text3 = Num;
            }
            return text3;
        }
        private string Convert3(string Num)
        {
            string text = Num.Substring(0, 2);
            string text2;
            if (text != "零零")
            {
                text2 = Num.Replace("零零", "");
                if (text2.Length == 1)
                {
                    text2 = text2.Substring(0, 1) + "佰";
                }
                else
                {
                    string str;
                    if (text2.Substring(0, 1) != "零")
                    {
                        str = text2.Substring(0, 1) + "佰";
                    }
                    else
                    {
                        str = text2.Substring(0, 1);
                    }
                    text2 = str + this.Convert2(text2.Substring(1, 2));
                }
            }
            else
            {
                text2 = Num.Replace("零零", "零");
            }
            return text2;
        }
    }
}
