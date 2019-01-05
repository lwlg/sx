using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Attribute;

namespace sx.Model
{
    public partial class pos_Net_Order
    {
        [Association("FlowNo", "OrderID", AssociationType.Aggregation, CascadeType.ALL)]
        public List<pos_Net_OrderDetail> Details { get; set; }
    }
}
