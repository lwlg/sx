﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;

namespace sx.Model
{
    [Entity("pos_OrderDetail", "ID")]
    public class pos_Net_OrderDetail : EntityBase
    {
        /// <summary>
        /// ID
        /// </summary>		
        //[DataField("ID", "nvarchar")]
        //[Validate("")]
        //public string ID { get; set; }

        /// <summary>
        /// OrderID
        /// </summary>		
        [DataField("OrderID", "nvarchar")]
        [Custom("GridCol", "OrderID", "订单编号", "invisible")]
        public string OrderID { get; set; }


        /// <summary>
        /// GoodsID
        /// </summary>		
        [DataField("GoodsID", "nvarchar")]
        public string GoodsID { get; set; }



        /// <summary>
        /// GoodsName
        /// </summary>		
        [DataField("GoodsName", "nvarchar")]
        [Custom("GridCol", "GoodsName", "商品名称")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品分类
        /// </summary>		
        [DataField("Category", "nvarchar")]
        public string Category { get; set; }


        /// <summary>
        /// Unit单位：包、盒、袋
        /// </summary>		
        [DataField("Unit", "nvarchar")]
        public string Unit { get; set; }

        /// <summary>
        /// UnitPrice
        /// </summary>		
        [DataField("UnitPrice", "float")]
        [Custom("GridCol", "UnitPrice", "商品单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// GoodsNum
        /// </summary>		
        [DataField("GoodsNum", "integer")]
        [Custom("GridCol", "GoodsNum", "购买数量")]
        public int GoodsNum { get; set; }

        /// <summary>
        /// OriginalPrice 进价
        /// </summary>		
        [DataField("OriginalPrice", "float")]
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// DiscountRate
        /// </summary>		
        //[DataField("DiscountRate", "float")]
        //public decimal DiscountRate { get; set; }

        /// <summary>
        /// Discount
        /// </summary>		
        //[DataField("Discount", "float")]
        //[Custom("GridCol", "Discount", "优惠金额")]
        //public decimal Discount { get; set; }

        /// <summary>
        /// SalePrice
        /// </summary>		
        [DataField("SalePrice", "float")]
        [Custom("GridCol", "SalePrice", "总金额")]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// CostPrice
        /// </summary>		
        //[DataField("CostPrice", "float")]
        //public decimal CostPrice { get; set; }

        /// <summary>
        /// Profit
        /// </summary>		
        //[DataField("Profit", "float")]
        //public decimal Profit { get; set; }

        /// <summary>
        /// Supplier
        /// </summary>		
        //[DataField("Supplier", "nvarchar")]
        //public string Supplier { get; set; }

        /// <summary>
        /// Status
        /// </summary>		
        //[DataField("Status", "integer")]
        //public int Status { get; set; }

        /// <summary>
        /// Memo
        /// </summary>		
        [DataField("Memo", "nvarchar")]
        public string Memo { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>		
        //[DataField("CreateTime", "datetime")]
        //public DateTime CreateTime { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>		
        //[DataField("UpdateTime", "datetime")]
        //public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Modifier
        /// </summary>		
        //[DataField("Modifier", "nvarchar")]
        //public string Modifier { get; set; }

        /// <summary>
        /// MemberPrice
        /// </summary>		
        [DataField("MemberPrice", "float")]
        [Custom("GridCol", "MemberPrice", "会员价")]
        public decimal MemberPrice { get; set; }
    }
}