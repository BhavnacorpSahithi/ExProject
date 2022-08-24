using System;
using System.Collections.Generic;
using System.Text;

namespace OrderEcommerceProject
{
    public class Order
    {
        public int Orderid { get; set; }
        public string Orderitem { get; set; }
        public int Orderamount { get; set; }
        public int Orderqty { get; set; }
        public string OrderedCusName { get; set; }
        public int totalprice { get; set; }

    }
}
