using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Products_sizes")]
    public class Product_sizes {

        [Key]
        [Column("Product_size_id")]
        public int Product_size_id {get;set;}

        [Column("Product_id")]
        public int Product_id { get; set; }

        [Column("size_id")]
        public int Size_id { get; set; }

        [Column("size_US")]
        public String Size_US { get; set; }

        [Column("size_EUR")]
        public String Size_EUR { get; set; }

        [Column("Size_UK")]

        public String Size_UK { get; set; }

        public Product_sizes () {}

        public Product_sizes (int product_size_id, int product_id,
            int size_id, string size_US, string size_EUR, string size_UK) {
            Product_size_id = product_size_id;
            Product_id = product_id;
            Size_id = size_id;
            Size_US = size_US;
            Size_EUR = size_EUR;
            Size_UK = size_UK;
        }
    }
}
