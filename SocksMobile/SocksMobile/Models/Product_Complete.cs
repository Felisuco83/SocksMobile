using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Product_Complete")]
    public class Product_Complete {

        [Key]
        [Column("Product_id")]
        public int Product_id { get; set; }
        [Column("Product_name")]
        public String Product_name { get; set; }
        [Column("Product_description")]
        public String Product_description { get; set; }
        [Column("Product_price")]
        public double Product_price { get; set; }
        [Column("Product_style")]
        public String Product_style { get; set; }
        [Column("Product_print")]
        public String Product_print { get; set; }
        [Column("Product_color")]
        public String Product_color { get; set; }
        [Column("Product_category")]
        public int? Product_category { get; set; }
        [Column("Product_subcategory")]
        public int? Product_subcategory { get; set; }
        [Column("Product_discount")]
        public int? Product_discount { get; set; }
        [Column("Product_collection")]
        public int? Product_collection { get; set; }
        [Column("Category_name")]
        public String CategoryName { get; set; }
        [Column("Category_description")]
        public String Category_description { get; set; }
        [Column("Subcategory_name")]
        public String Subcategory_name { get; set; }

        public Product_Complete () {}

        public Product_Complete (int product_id, string product_name, string product_description, 
            double product_price, string product_style, string product_print, string product_color, 
            int? product_category, int? product_subcategory, int? product_discount, int? product_collection, 
            string categoryName, string category_description, string subcategory_name) {
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
            CategoryName = categoryName;
            Category_description = category_description;
            Subcategory_name = subcategory_name;
        }
    }
}
