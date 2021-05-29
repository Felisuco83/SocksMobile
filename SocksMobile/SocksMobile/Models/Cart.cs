using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    public class Cart {

        public int Product_id { get; set; }
        public int Size_id { get; set; }
        public int Amount { get; set; }

        public Cart (int product_id, int size_id, int amount) {
            Product_id = product_id;
            Size_id = size_id;
            Amount = amount;
        }
    }
}
