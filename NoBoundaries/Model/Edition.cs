﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NoBoundaries.Model
{
    /// <summary>Edition</summary>
    /// <remarks></remarks>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK_Edition", true, "Number")]
    [BindTable("Edition", Description = "", ConnName = "NoBoundaries", DbType = DatabaseType.SqlServer)]
    public partial class Edition : IEdition
    {
        #region 属性
        private Double _Number;
        /// <summary></summary>
        [DisplayName("Number")]
        [Description("")]
        [DataObjectField(true, false, false, 53)]
        [BindColumn("Number", "", "float")]
        public virtual Double Number
        {
            get { return _Number; }
            set { if (OnPropertyChanging(__.Number, value)) { _Number = value; OnPropertyChanged(__.Number); } }
        }

        private String _GameUrl;
        /// <summary></summary>
        [DisplayName("GameUrl")]
        [Description("")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("GameUrl", "", "varchar(100)")]
        public virtual String GameUrl
        {
            get { return _GameUrl; }
            set { if (OnPropertyChanging(__.GameUrl, value)) { _GameUrl = value; OnPropertyChanged(__.GameUrl); } }
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
                    case __.Number : return _Number;
                    case __.GameUrl : return _GameUrl;
                    case __.Memo : return _Memo;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Number : _Number = Convert.ToDouble(value); break;
                    case __.GameUrl : _GameUrl = Convert.ToString(value); break;
                    case __.Memo : _Memo = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得Edition字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field Number = FindByName(__.Number);

            ///<summary></summary>
            public static readonly Field GameUrl = FindByName(__.GameUrl);

            ///<summary></summary>
            public static readonly Field Memo = FindByName(__.Memo);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得Edition字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String Number = "Number";

            ///<summary></summary>
            public const String GameUrl = "GameUrl";

            ///<summary></summary>
            public const String Memo = "Memo";

        }
        #endregion
    }

    /// <summary>Edition接口</summary>
    /// <remarks></remarks>
    public partial interface IEdition
    {
        #region 属性
        /// <summary></summary>
        Double Number { get; set; }

        /// <summary></summary>
        String GameUrl { get; set; }

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