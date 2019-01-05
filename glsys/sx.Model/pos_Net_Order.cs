using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;
namespace sx.Model
{
    [Entity("pos_Order", "FlowNo")]
    public partial class pos_Net_Order : EntityBase
    {
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
        [Custom("GridCol", "OriginalPrice", "折前总价")]
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// Discount
        /// </summary>		
        //[DataField("Discount", "float")]
        //[Custom("GridCol", "Discount", "总优惠金额")]
        //public decimal Discount { get; set; }

        /// <summary>
        /// DiscountRate
        /// </summary>		
        //[DataField("DiscountRate", "float")]
        //[Custom("GridCol", "DiscountRate", "整单折扣")]
        //public decimal DiscountRate { get; set; }

        /// <summary>
        /// ReceivablePrice
        /// </summary>		
        [DataField("ReceivablePrice", "float")]
        [Custom("GridCol", "ReceivablePrice", "应收金额")]
        public decimal ReceivablePrice { get; set; }

        /// <summary>
        /// Received
        /// </summary>		
        //[DataField("Received", "float")]
        //[Custom("GridCol", "Received", "实收金额")]
        //public decimal Received { get; set; }

        /// <summary>
        /// Profit
        /// </summary>		
        [DataField("Profit", "float")]
        [Custom("GridCol", "Profit", "利润额")]
        public decimal Profit { get; set; }

        /// <summary>
        /// PayType
        /// </summary>		
        //[DataField("PayType", "nvarchar")]
        //public string PayType { get; set; }

        /// <summary>
        /// Cash
        /// </summary>		
        //[DataField("Cash", "float")]
        //public decimal Cash { get; set; }

        /// <summary>
        /// BandCard
        /// </summary>		
        //[DataField("BandCard", "float")]
        //public decimal BandCard { get; set; }

        /// <summary>
        /// IsPostCard
        /// </summary>		
        //[DataField("IsPostCard", "bit")]
        //public bool IsPostCard { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>		
        [DataField("CreateTime", "nvarchar")]
        [Custom("GridCol", "CreateTime", "订单时间")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 会员编号
        /// </summary>
        [DataField("MemberNo", "nvarchar")]
        [Custom("GridCol", "MemberNo", "会员号")]
        public string MemberNo { get; set; }
    }
}
