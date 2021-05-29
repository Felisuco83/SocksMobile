using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Product_size")]
    public class Product_size {
        [Key]
        [Column("Product_size_id")]
        public int Product_size_id { get; set; }
        [Column("Product_id")]
        public int Product_id { get; set; }
        [Column("Size_id")]
        public int Size_id { get; set; }

        public Product_size() {}

        public Product_size( int product_id, int size_id ) {
            this.Product_id = product_id;
            this.Size_id = size_id;
        }
    }
}
