using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Core;
using NDolls.Data.Entity;
using NDolls.Data.Attribute;
namespace sx.Model
{
    [Entity("pos_Member", "ID")]
    public class pos_Member : EntityBase
    {
        [DataField("ID", "nvarchar")]
        [Validate("不允许为空")]
        [Custom("GirdCol", "ID", "系统编号", "invisible")]
        public string ID { get; set; }

        /// <summary>
        /// MemberNo
        /// </summary>		
        [DataField("MemberNo", "nvarchar")]
        [Validate("请填写会员卡号")]
        [Custom("GridCol", "MemberNo", "会员号")]
        [Custom("SCol", "MemberNo", "会员号")]
        public string MemberNo { get; set; }

        /// <summary>
        /// MemberName
        /// </summary>		
        [DataField("MemberName", "nvarchar")]
        [Validate("请填写会员名称")]
        [Custom("GridCol", "MemberName", "会员名称")]
        [Custom("SCol", "MemberName", "会员名称")]
        public string MemberName { get; set; }

        /// <summary>
        /// PhoneNo
        /// </summary>		
        [DataField("PhoneNo", "nvarchar")]
        [Validate("请填写会员手机号")]
        [Custom("GridCol", "PhoneNo", "会员手机")]
        [Custom("SCol", "PhoneNo", "会员手机")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>		
        [DataField("Birthday", "datetime")]
        [Custom("GridCol", "Birthday", "会员生日")]
        [Custom("SCol", "Birthday", "会员生日")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// ShortCode
        /// </summary>		
        [DataField("ShortCode", "nvarchar")]
        [Custom("GridCol", "ShortCode", "助记码")]
        [Custom("SCol", "ShortCode", "助记码")]
        public string ShortCode { get; set; }

        /// <summary>
        /// MemberType
        /// </summary>		
        [DataField("MemberType", "nvarchar")]
        public string MemberType { get; set; }

        /// <summary>
        /// 会员积分
        /// </summary>		
        [DataField("Scores", "float")]
        [Custom("GridCol", "Scores", "会员积分")]
        public float Scores { get; set; }

        /// <summary>
        /// IDNo
        /// </summary>		
        [DataField("IDNo", "nvarchar")]
        [Custom("GridCol", "IDNo", "身份证号")]
        public string IDNo { get; set; }

        /// <summary>
        /// Address
        /// </summary>		
        [DataField("Address", "nvarchar")]
        [Custom("GridCol", "Address", "联系地址")]
        public string Address { get; set; }

        /// <summary>
        /// Status
        /// </summary>		
        [DataField("Status", "integer")]
        public int Status { get; set; }

        /// <summary>
        /// Memo
        /// </summary>		
        [DataField("Memo", "nvarchar")]
        public string Memo { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>		
        [DataField("CreateTime", "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>		
        [DataField("UpdateTime", "datetime")]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Modifier
        /// </summary>		
        [DataField("Modifier", "nvarchar")]
        public string Modifier { get; set; }


    }
}
