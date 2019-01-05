using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Attribute;
namespace sx.Model
{
    public partial class pos_Order
    {
        [Association("ID", "OrderID", AssociationType.Aggregation, CascadeType.UNDELETE)]
        public List<pos_OrderDetail> Details { get; set; }
    }
}
