using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;

namespace sx.Model
{
    /// <summary>
    /// Entity 特性用于映射实体类与db表和主键
    /// DataFileld 特性数据库字段、类型对应关系
    /// validate 特性修改时候需要验证的字段和规则
    /// </summary>
    [Entity("sys_Dictionary","DID")]
    public class sys_Dictionary:EntityBase
    {
        /// <summary>
        /// DID
        /// </summary>
        [DataField("DID", "nvarchar")]
        [Validate("")]
        [Custom("GridCol", "DID", "字典项编号", "invisible")]
        public string DID { get; set; }

        /// <summary>
        /// DType
        /// </summary>
        [DataField("DType","nvarchar")]
        [Custom("GridCol","DType","字典类别")]
        [Validate("类别名称")]
        public string DType{get;set;}

        [DataField("DName","nvarchar")]
        [Custom("GridCol","DName","字典项名称")]
        [Validate("类别项名称")]
        public string DName{get;set;}
        
        [DataField("Sequence","nvarchar")]
        [Custom("GridCol","Sequence","排列顺序")]
        public string Sequence{get;set;}


        [DataField("ExtDLL","nvarchar")]
        public string ExtDLL{get;set;}

        [DataField("Memo","nvarchar")]
        [Custom("GridCol","Memo","备注")]
        public string Memo{get;set;}

        [DataField("CreateTime","datetime")]
        [Custom("GridCol","CreateTime","创建时间")]
        public DateTime CreateTime{get;set;}

        [DataField("UpdateTime","datetime")]
        [Custom("GridCol","UpdateTime","最近修改时间")]
        public DateTime UpdateTime{get;set;}

        [DataField("Modifier","nvarchar")]
        public string Modifier{get;set;}


    }
}
