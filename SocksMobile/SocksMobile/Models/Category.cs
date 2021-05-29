using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Category")]
    public class Category {

        [Key]
        [Column("Category_id")]
        public int Category_id { get; set; }
        [Column("Category_name")]
        public String Category_name { get; set; }
        [Column("Category_description")]
        public String Category_description { get; set; }

        public virtual ICollection<Product> products { get; set; }

        public Category() { }

        public Category( int category_id, string category_name, 
            string category_description ) {
            Category_id = category_id;
            Category_name = category_name;
            Category_description = category_description;
        }
    }
}
