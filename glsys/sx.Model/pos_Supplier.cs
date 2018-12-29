/*
	供应商字段
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;

namespace sx.Model
{
    [Entity("pos_Supplier", "SID")]
    public partial class pos_Supplier : EntityBase
    {
        [DataField("SID", "nvarchar")]
        [Validate("不许为空")]
        [Custom("GridCol", "SID", "系统编号", "invisible")]
        public string SID { get; set; }


        [DataField("SName", "nvarchar")]
        [Custom("GridCol", "SName", "供应商名称")]
        public string SName { get; set; }

        [DataField("ShortCode", "nvarchar")]
        [Custom("GridCol", "ShortCode", "助记码")]
        public string ShortCode { get; set; }

        [DataField("SAddress", "nvarchar")]
        [Custom("GridCol", "SAddress", "供应商地址")]
        public string SAddress { get; set; }

        [DataField("SPhone", "nvarchar")]
        [Custom("GridCol", "SPhone", "联系电话")]
        public string SPhone { get; set; }

        [DataField("Status", "int")]
        public int Status { get; set; }

        [DataField("Memo", "nvarchar")]
        public string Memo { get; set; }

        [DataField("CreateTime", "datetime")]
        public DateTime CreateTime { get; set; }

        [DataField("UpdateTime", "datetime")]
        public DateTime UpdateTime { get; set; }

        [DataField("Modifier", "nvarchar")]
        public string Modifier { get; set; }
    }
}
