using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;
namespace sx.Model
{
    [Entity("pos_Order", "ID")]
    public partial class pos_Order : EntityBase
    {
        /// <summary>
        /// ID
        /// </summary>		
        [DataField("ID", "nvarchar")]
        [Validate("")]
        [Custom("GridCol", "ID", "订单号", "invisible")]
        public string ID { get; set; }

        /// <summary>
        /// FlowNo
        /// </summary>		
        [DataField("FlowNo", "nvarchar")]
        [Custom("GridCol", "FlowNo", "订单流水号")]
        public string FlowNo { get; set; }

        /// <summary>
        /// GoodsNum
        /// </summary>		
        [DataField("GoodsNum", "integer")]
        [Custom("GridCol", "GoodsNum", "商品数量")]
        public int GoodsNum { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>		
        [DataField("OriginalPrice", "float")]
        [Custom("GridCol", "OriginalPrice", "订单价格")]
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>		
        [DataField("Scores", "float")]
        [Custom("GridCol", "Scores", "积分变化")]
        public decimal Scores { get; set; }

        /// <summary>
        /// Discount
        /// </summary>
        [DataField("Discount", "float")]
        [Custom("GridCol", "Discount", "总优惠金额")]
        public decimal Discount { get; set; }

        /// <summary>
        /// DiscountRate
        /// </summary>		
        [DataField("DiscountRate", "float")]
        [Custom("GridCol", "DiscountRate", "整单折扣")]
        public decimal DiscountRate { get; set; }

        /// <summary>
        /// NCSC
        /// </summary>		
        [DataField("NCSC", "float")]
        public decimal NCSC { get; set; }

        /// <summary>
        /// ReceivablePrice
        /// </summary>		
        [DataField("ReceivablePrice", "float")]
        [Custom("GridCol", "ReceivablePrice", "应收金额")]
        public decimal ReceivablePrice { get; set; }

        /// <summary>
        /// Received
        /// </summary>		
        [DataField("Received", "float")]
        //[Custom("GridCol", "Received", "实收金额")]
        public decimal Received { get; set; }

        /// <summary>
        /// Change
        /// </summary>		
        [DataField("Change", "float")]
        //[Custom("GridCol", "Change", "找零")]
        public decimal Change { get; set; }

        /// <summary>
        /// Profit
        /// </summary>		
        [DataField("Profit", "float")]
        [Custom("GridCol", "Profit", "利润额")]
        public decimal Profit { get; set; }

        /// <summary>
        /// PayType
        /// </summary>		
        [DataField("PayType", "nvarchar")]
        public string PayType { get; set; }

        /// <summary>
        /// Cash
        /// </summary>		
        [DataField("Cash", "float")]
        [Custom("GridCol", "Cash", "现金结账")]
        public decimal Cash { get; set; }

        /// <summary>
        /// BandCard
        /// </summary>		
        [DataField("BandCard", "float")]
        [Custom("GridCol", "BandCard", "刷卡结账")]
        public decimal BandCard { get; set; }

        /// <summary>
        /// IsPostCard
        /// </summary>		
        [DataField("IsPostCard", "bit")]
        public bool IsPostCard { get; set; }

        /// <summary>
        /// Coupon
        /// </summary>		
        [DataField("Coupon", "float")]
        public decimal Coupon { get; set; }

        /// <summary>
        /// ValueCard
        /// </summary>		
        [DataField("ValueCard", "float")]
        public decimal ValueCard { get; set; }

        /// <summary>
        /// ValueCardNo
        /// </summary>		
        [DataField("ValueCardNo", "nvarchar")]
        public string ValueCardNo { get; set; }

        /// <summary>
        /// 会员编号
        /// </summary>
        [DataField("MemberNo", "nvarchar")]
        [Custom("GridCol", "MemberNo", "会员号")]
        public string MemberNo { get; set; }

        /// <summary>
        /// Status
        /// </summary>		
        [DataField("Status", "integer")]
        public int Status { get; set; }

        /// <summary>
        /// Memo
        /// </summary>		
        [DataField("Memo", "nvarchar")]
        [Custom("GridCol", "Memo", "备注")]
        public string Memo { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>		
        [DataField("CreateTime", "datetime")]
        [Custom("GridCol", "CreateTime", "订单时间")]
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
        [Custom("GridCol", "Modifier", "处理人")]
        public string Modifier { get; set; }

    }
}
