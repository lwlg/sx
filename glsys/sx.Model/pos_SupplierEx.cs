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
	[Entity("pos_Supplier","SID")]
    public partial class pos_Supplier
    {
    	[Association["SID","SID",AssociationType.Aggregation,CascadeType.SELECT]]
    	public List<pos_SupplierGoods> Goods{get;set;}
    }
}
