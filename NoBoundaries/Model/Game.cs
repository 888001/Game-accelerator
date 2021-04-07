﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NoBoundaries.Model
{
    /// <summary>Game</summary>
    /// <remarks></remarks>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("PK__Game__651A95AE173876EA", true, "SerialCode")]
    [BindTable("Game", Description = "", ConnName = "NoBoundaries", DbType = DatabaseType.SqlServer)]
    public partial class Game : IGame
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

        private String _Name;
        /// <summary></summary>
        [DisplayName("Name")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "", "varchar(50)", Master=true)]
        public virtual String Name
        {
            get { return _Name; }
            set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } }
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
                    case __.Name : return _Name;
                    case __.Type : return _Type;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.SerialCode : _SerialCode = Convert.ToString(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得Game字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field SerialCode = FindByName(__.SerialCode);

            ///<summary></summary>
            public static readonly Field Name = FindByName(__.Name);

            ///<summary></summary>
            public static readonly Field Type = FindByName(__.Type);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得Game字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String SerialCode = "SerialCode";

            ///<summary></summary>
            public const String Name = "Name";

            ///<summary></summary>
            public const String Type = "Type";

        }
        #endregion
    }

    /// <summary>Game接口</summary>
    /// <remarks></remarks>
    public partial interface IGame
    {
        #region 属性
        /// <summary></summary>
        String SerialCode { get; set; }

        /// <summary></summary>
        String Name { get; set; }

        /// <summary></summary>
        Int32 Type { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}