using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Order_details
    {

        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public int Pack_id { get; set; }
        public int Amount { get; set; }

        public Order_details() { }

        public Order_details(int order_id, int product_id,
            int pack_id, int amount)
        {
            Order_id = order_id;
            Product_id = product_id;
            Pack_id = pack_id;
            Amount = amount;
        }
    }
}