using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Product
    {

        public int Product_id { get; set; }
        public String Product_name { get; set; }
        public String Product_description { get; set; }
        public float Product_price { get; set; }
        public String Product_style { get; set; }
        public String Product_print { get; set; }
        public String Product_color { get; set; }
        public int Product_category { get; set; }
        public int Product_subcategory { get; set; }
        public int Product_discount { get; set; }
        public int Product_collection { get; set; }

        public Product() { }

        public Product(int product_id, string product_name, string product_description,
            float product_price, string product_style, string product_print,
            string product_color, int product_category, int product_subcategory,
            int product_discount, int product_collection)
        {
            Product_id = product_id;
            Product_name = product_name;
            Product_description = product_description;
            Product_price = product_price;
            Product_style = product_style;
            Product_print = product_print;
            Product_color = product_color;
            Product_category = product_category;
            Product_subcategory = product_subcategory;
            Product_discount = product_discount;
            Product_collection = product_collection;
        }
    }
}