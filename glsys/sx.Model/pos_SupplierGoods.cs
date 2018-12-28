/*
	供应商商品字段
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
	[Entity("pos_SupplierGoods","SID,GoodsID")]
    public  class pos_SupplierGoods:EntityBase
    {
    	[DataField("SID","nvarchar")]
    	[Validate("不许为空")]
    	[Custom("GridCol","SID","系统编号","invisible")]
    	public string SID{get;set;}

    	[DataField("GoodsID","nvarchar")]
    	[Validate("不许为空")]
    	[Custom("GridCol","GoodsID","商品编号","invisible")]
    	public string GoodsID{get;set;}

		[DataField("GoodsName","nvarchar")]
    	[Custom("GridCol","GoodsName","商品名称")]
    	public string GoodsName{get;set;}

		[DataField("GoodsBrand","nvarchar")]
    	[Custom("GridCol","GoodsBrand","商品品牌")]
    	public string GoodsBrand{get;set;}

    	[DataField("BuyingPrice","float")]
    	[Custom("GridCol","BuyingPrice","商品进价")]
    	public decimal BuyingPrice{get;set;}

    	 [DataField("SalePrice", "float")]
        public decimal SalePrice { get; set; }

         [DataField("Status", "int")]
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
