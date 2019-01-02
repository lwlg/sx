using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Core;
using NDolls.Data.Entity;
using NDolls.Data.Attribute;

namespace sx.Model
{
    [Entity("pos_GoodsIn", "ID")]
    public class posGoodsIn : EntityBase
    {
        /// <summary>
        /// ID
        /// </summary>		
        [DataField("ID", "nvarchar")]
        [Validate("")]
        [Custom("GridCol", "ID", "入库编号", "invisible")]
        public string ID { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>		
        [DataField("GoodsID", "nvarchar")]
        [Custom("GridCol", "GoodsID", "商品编号", "invisible")]
        public string GoodsID { get; set; }

        /// <summary>
        /// BarCode
        /// </summary>		
        [DataField("BarCode", "nvarchar")]
        [Custom("GridCol", "BarCode", "商品条码", "")]
        public string BarCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>		
        [DataField("GoodsName", "nvarchar")]
        [Custom("GridCol", "GoodsName", "商品名称", "sortble")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>		
        [DataField("Brand", "nvarchar")]
        [Custom("GridCol", "Brand", "商品品牌", "sortble")]
        public string Brand { get; set; }

        /// <summary>
        /// BuyingPrice
        /// </summary>		
        [DataField("BuyingPrice", "float")]
        [Custom("GridCol", "BuyingPrice", "商品进价", "")]
        [Validate("商品进价应大于0", "PositiveNumber")]
        public decimal BuyingPrice { get; set; }

        /// <summary>
        /// RetailPrice
        /// </summary>		
        [DataField("RetailPrice", "float")]
        [Custom("GridCol", "RetailPrice", "零售价", "")]
        [Validate("商品零售价应大于0", "PositiveNumber")]
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// InCount
        /// </summary>		
        [DataField("InCount", "integer")]
        [Validate("入库数量应为整数", "NonNegativeInt")]
        [Custom("GridCol", "InCount", "入库数量", "")]
        public int InCount { get; set; }

        /// <summary>
        /// InCount
        /// </summary>		
        [DataField("Unit", "nvarchar")]
        [Custom("GridCol", "Unit", "商品单位", "")]
        public String Unit { get; set; }

        /// <summary>
        /// ProductionDate
        /// </summary>		
        [DataField("ProductionDate", "date")]
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// ShelfLife
        /// </summary>		
        [DataField("ShelfLife", "integer")]
        public int ShelfLife { get; set; }

        /// <summary>
        /// ExpirationDate
        /// </summary>		
        [DataField("ExpirationDate", "date")]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Supplier
        /// </summary>		
        [DataField("Supplier", "nvarchar")]
        [Custom("GridCol", "Supplier", "供应商", "sortble")]
        public string Supplier { get; set; }

        /// <summary>
        /// Memo
        /// </summary>		
        [DataField("Memo", "nvarchar")]
        [Custom("GridCol", "Memo", "备注", "")]
        public string Memo { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>		
        [DataField("CreateTime", "datetime")]
        [Custom("GridCol", "CreateTime", "入库时间", "")]
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

        /// <summary>
        /// Status
        /// </summary>		
        [DataField("Status", "integer")]
        public int Status { get; set; }
    }
}
