using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Product_size
    {

        public int Product_id { get; set; }
        public int Size_id { get; set; }

        public Product_size() { }

        public Product_size(int product_id, int size_id)
        {
            Product_id = product_id;
            Size_id = size_id;
        }
    }
}