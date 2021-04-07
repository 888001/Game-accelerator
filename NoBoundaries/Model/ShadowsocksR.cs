﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NoBoundaries.Model
{
    /// <summary>ShadowsocksR</summary>
    /// <remarks></remarks>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK__Shadowso__651A95AE0425A276", true, "SerialCode")]
    [BindTable("ShadowsocksR", Description = "", ConnName = "NoBoundaries", DbType = DatabaseType.SqlServer)]
    public partial class ShadowsocksR : IShadowsocksR
    {
        #region 属性
        private String _SerialCode;
        /// <summary></summary>
        [DisplayName("SerialCode")]
        [Description("")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("SerialCode", "", "varchar(50)")]
        public virtual String SerialCode
        {
            get { return _SerialCode; }
            set { if (OnPropertyChanging(__.SerialCode, value)) { _SerialCode = value; OnPropertyChanged(__.SerialCode); } }
        }

        private String _Remark;
        /// <summary></summary>
        [DisplayName("Remark")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Remark", "", "varchar(50)")]
        public virtual String Remark
        {
            get { return _Remark; }
            set { if (OnPropertyChanging(__.Remark, value)) { _Remark = value; OnPropertyChanged(__.Remark); } }
        }

        private String _HostName;
        /// <summary></summary>
        [DisplayName("HostName")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("HostName", "", "varchar(50)")]
        public virtual String HostName
        {
            get { return _HostName; }
            set { if (OnPropertyChanging(__.HostName, value)) { _HostName = value; OnPropertyChanged(__.HostName); } }
        }

        private String _Port;
        /// <summary></summary>
        [DisplayName("Port")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Port", "", "varchar(50)")]
        public virtual String Port
        {
            get { return _Port; }
            set { if (OnPropertyChanging(__.Port, value)) { _Port = value; OnPropertyChanged(__.Port); } }
        }

        private String _Method;
        /// <summary></summary>
        [DisplayName("Method")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Method", "", "varchar(50)")]
        public virtual String Method
        {
            get { return _Method; }
            set { if (OnPropertyChanging(__.Method, value)) { _Method = value; OnPropertyChanged(__.Method); } }
        }

        private String _Password;
        /// <summary></summary>
        [DisplayName("Password")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Password", "", "varchar(50)")]
        public virtual String Password
        {
            get { return _Password; }
            set { if (OnPropertyChanging(__.Password, value)) { _Password = value; OnPropertyChanged(__.Password); } }
        }

        private String _Protocol;
        /// <summary></summary>
        [DisplayName("Protocol")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Protocol", "", "varchar(50)")]
        public virtual String Protocol
        {
            get { return _Protocol; }
            set { if (OnPropertyChanging(__.Protocol, value)) { _Protocol = value; OnPropertyChanged(__.Protocol); } }
        }

        private String _ProtocolParam;
        /// <summary></summary>
        [DisplayName("ProtocolParam")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ProtocolParam", "", "varchar(50)")]
        public virtual String ProtocolParam
        {
            get { return _ProtocolParam; }
            set { if (OnPropertyChanging(__.ProtocolParam, value)) { _ProtocolParam = value; OnPropertyChanged(__.ProtocolParam); } }
        }

        private String _Obfs;
        /// <summary></summary>
        [DisplayName("Obfs")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OBFS", "", "varchar(50)")]
        public virtual String Obfs
        {
            get { return _Obfs; }
            set { if (OnPropertyChanging(__.Obfs, value)) { _Obfs = value; OnPropertyChanged(__.Obfs); } }
        }

        private String _OBFSParam;
        /// <summary></summary>
        [DisplayName("OBFSParam")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OBFSParam", "", "varchar(50)")]
        public virtual String OBFSParam
        {
            get { return _OBFSParam; }
            set { if (OnPropertyChanging(__.OBFSParam, value)) { _OBFSParam = value; OnPropertyChanged(__.OBFSParam); } }
        }

        private Int32 _Type;
        /// <summary></summary>
        [DisplayName("Type")]
        [Description("")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Type", "", "int")]
        public virtual Int32 Type
        {
            get { return _Type; }
            set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } }
        }

        private String _State;
        /// <summary></summary>
        [DisplayName("State")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("State", "", "varchar(50)")]
        public virtual String State
        {
            get { return _State; }
            set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } }
        }

        private String _Memo;
        /// <summary></summary>
        [DisplayName("Memo")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Memo", "", "varchar(50)")]
        public virtual String Memo
        {
            get { return _Memo; }
            set { if (OnPropertyChanging(__.Memo, value)) { _Memo = value; OnPropertyChanged(__.Memo); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.SerialCode : return _SerialCode;
                    case __.Remark : return _Remark;
                    case __.HostName : return _HostName;
                    case __.Port : return _Port;
                    case __.Method : return _Method;
                    case __.Password : return _Password;
                    case __.Protocol : return _Protocol;
                    case __.ProtocolParam : return _ProtocolParam;
                    case __.Obfs : return _Obfs;
                    case __.OBFSParam : return _OBFSParam;
                    case __.Type : return _Type;
                    case __.State : return _State;
                    case __.Memo : return _Memo;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.SerialCode : _SerialCode = Convert.ToString(value); break;
                    case __.Remark : _Remark = Convert.ToString(value); break;
                    case __.HostName : _HostName = Convert.ToString(value); break;
                    case __.Port : _Port = Convert.ToString(value); break;
                    case __.Method : _Method = Convert.ToString(value); break;
                    case __.Password : _Password = Convert.ToString(value); break;
                    case __.Protocol : _Protocol = Convert.ToString(value); break;
                    case __.ProtocolParam : _ProtocolParam = Convert.ToString(value); break;
                    case __.Obfs : _Obfs = Convert.ToString(value); break;
                    case __.OBFSParam : _OBFSParam = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToInt32(value); break;
                    case __.State : _State = Convert.ToString(value); break;
                    case __.Memo : _Memo = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ShadowsocksR字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field SerialCode = FindByName(__.SerialCode);

            ///<summary></summary>
            public static readonly Field Remark = FindByName(__.Remark);

            ///<summary></summary>
            public static readonly Field HostName = FindByName(__.HostName);

            ///<summary></summary>
            public static readonly Field Port = FindByName(__.Port);

            ///<summary></summary>
            public static readonly Field Method = FindByName(__.Method);

            ///<summary></summary>
            public static readonly Field Password = FindByName(__.Password);

            ///<summary></summary>
            public static readonly Field Protocol = FindByName(__.Protocol);

            ///<summary></summary>
            public static readonly Field ProtocolParam = FindByName(__.ProtocolParam);

            ///<summary></summary>
            public static readonly Field Obfs = FindByName(__.Obfs);

            ///<summary></summary>
            public static readonly Field OBFSParam = FindByName(__.OBFSParam);

            ///<summary></summary>
            public static readonly Field Type = FindByName(__.Type);

            ///<summary></summary>
            public static readonly Field State = FindByName(__.State);

            ///<summary></summary>
            public static readonly Field Memo = FindByName(__.Memo);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得ShadowsocksR字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String SerialCode = "SerialCode";

            ///<summary></summary>
            public const String Remark = "Remark";

            ///<summary></summary>
            public const String HostName = "HostName";

            ///<summary></summary>
            public const String Port = "Port";

            ///<summary></summary>
            public const String Method = "Method";

            ///<summary></summary>
            public const String Password = "Password";

            ///<summary></summary>
            public const String Protocol = "Protocol";

            ///<summary></summary>
            public const String ProtocolParam = "ProtocolParam";

            ///<summary></summary>
            public const String Obfs = "Obfs";

            ///<summary></summary>
            public const String OBFSParam = "OBFSParam";

            ///<summary></summary>
            public const String Type = "Type";

            ///<summary></summary>
            public const String State = "State";

            ///<summary></summary>
            public const String Memo = "Memo";

        }
        #endregion
    }

    /// <summary>ShadowsocksR接口</summary>
    /// <remarks></remarks>
    public partial interface IShadowsocksR
    {
        #region 属性
        /// <summary></summary>
        String SerialCode { get; set; }

        /// <summary></summary>
        String Remark { get; set; }

        /// <summary></summary>
        String HostName { get; set; }

        /// <summary></summary>
        String Port { get; set; }

        /// <summary></summary>
        String Method { get; set; }

        /// <summary></summary>
        String Password { get; set; }

        /// <summary></summary>
        String Protocol { get; set; }

        /// <summary></summary>
        String ProtocolParam { get; set; }

        /// <summary></summary>
        String Obfs { get; set; }

        /// <summary></summary>
        String OBFSParam { get; set; }

        /// <summary></summary>
        Int32 Type { get; set; }

        /// <summary></summary>
        String State { get; set; }

        /// <summary></summary>
        String Memo { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}