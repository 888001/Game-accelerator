﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NoBoundaries.Model
{
    /// <summary>User</summary>
    /// <remarks></remarks>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK__User__651A95AE07F6335A", true, "SerialCode")]
    [BindTable("User", Description = "", ConnName = "NoBoundaries", DbType = DatabaseType.SqlServer)]
    public partial class User : IUser
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

        private String _UserId;
        /// <summary></summary>
        [DisplayName("UserId")]
        [Description("")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("UserId", "", "varchar(20)")]
        public virtual String UserId
        {
            get { return _UserId; }
            set { if (OnPropertyChanging(__.UserId, value)) { _UserId = value; OnPropertyChanged(__.UserId); } }
        }

        private String _UserPwd;
        /// <summary></summary>
        [DisplayName("UserPwd")]
        [Description("")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("UserPwd", "", "varchar(100)")]
        public virtual String UserPwd
        {
            get { return _UserPwd; }
            set { if (OnPropertyChanging(__.UserPwd, value)) { _UserPwd = value; OnPropertyChanged(__.UserPwd); } }
        }

        private Int32 _UserType;
        /// <summary></summary>
        [DisplayName("UserType")]
        [Description("")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("UserType", "", "int")]
        public virtual Int32 UserType
        {
            get { return _UserType; }
            set { if (OnPropertyChanging(__.UserType, value)) { _UserType = value; OnPropertyChanged(__.UserType); } }
        }

        private DateTime _CreatTime;
        /// <summary></summary>
        [DisplayName("CreatTime")]
        [Description("")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("CreatTime", "", "datetime")]
        public virtual DateTime CreatTime
        {
            get { return _CreatTime; }
            set { if (OnPropertyChanging(__.CreatTime, value)) { _CreatTime = value; OnPropertyChanged(__.CreatTime); } }
        }

        private DateTime _DueTime;
        /// <summary></summary>
        [DisplayName("DueTime")]
        [Description("")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("DueTime", "", "datetime")]
        public virtual DateTime DueTime
        {
            get { return _DueTime; }
            set { if (OnPropertyChanging(__.DueTime, value)) { _DueTime = value; OnPropertyChanged(__.DueTime); } }
        }

        private Int32 _LoginCount;
        /// <summary></summary>
        [DisplayName("LoginCount")]
        [Description("")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("LoginCount", "", "int")]
        public virtual Int32 LoginCount
        {
            get { return _LoginCount; }
            set { if (OnPropertyChanging(__.LoginCount, value)) { _LoginCount = value; OnPropertyChanged(__.LoginCount); } }
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
                    case __.UserId : return _UserId;
                    case __.UserPwd : return _UserPwd;
                    case __.UserType : return _UserType;
                    case __.CreatTime : return _CreatTime;
                    case __.DueTime : return _DueTime;
                    case __.LoginCount : return _LoginCount;
                    case __.Memo : return _Memo;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.SerialCode : _SerialCode = Convert.ToString(value); break;
                    case __.UserId : _UserId = Convert.ToString(value); break;
                    case __.UserPwd : _UserPwd = Convert.ToString(value); break;
                    case __.UserType : _UserType = Convert.ToInt32(value); break;
                    case __.CreatTime : _CreatTime = Convert.ToDateTime(value); break;
                    case __.DueTime : _DueTime = Convert.ToDateTime(value); break;
                    case __.LoginCount : _LoginCount = Convert.ToInt32(value); break;
                    case __.Memo : _Memo = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得User字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field SerialCode = FindByName(__.SerialCode);

            ///<summary></summary>
            public static readonly Field UserId = FindByName(__.UserId);

            ///<summary></summary>
            public static readonly Field UserPwd = FindByName(__.UserPwd);

            ///<summary></summary>
            public static readonly Field UserType = FindByName(__.UserType);

            ///<summary></summary>
            public static readonly Field CreatTime = FindByName(__.CreatTime);

            ///<summary></summary>
            public static readonly Field DueTime = FindByName(__.DueTime);

            ///<summary></summary>
            public static readonly Field LoginCount = FindByName(__.LoginCount);

            ///<summary></summary>
            public static readonly Field Memo = FindByName(__.Memo);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得User字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String SerialCode = "SerialCode";

            ///<summary></summary>
            public const String UserId = "UserId";

            ///<summary></summary>
            public const String UserPwd = "UserPwd";

            ///<summary></summary>
            public const String UserType = "UserType";

            ///<summary></summary>
            public const String CreatTime = "CreatTime";

            ///<summary></summary>
            public const String DueTime = "DueTime";

            ///<summary></summary>
            public const String LoginCount = "LoginCount";

            ///<summary></summary>
            public const String Memo = "Memo";

        }
        #endregion
    }

    /// <summary>User接口</summary>
    /// <remarks></remarks>
    public partial interface IUser
    {
        #region 属性
        /// <summary></summary>
        String SerialCode { get; set; }

        /// <summary></summary>
        String UserId { get; set; }

        /// <summary></summary>
        String UserPwd { get; set; }

        /// <summary></summary>
        Int32 UserType { get; set; }

        /// <summary></summary>
        DateTime CreatTime { get; set; }

        /// <summary></summary>
        DateTime DueTime { get; set; }

        /// <summary></summary>
        Int32 LoginCount { get; set; }

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