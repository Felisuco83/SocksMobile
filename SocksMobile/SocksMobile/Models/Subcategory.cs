using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Subcategory")]
    public class Subcategory {

        [Key]
        [Column("Subcategory_id")]
        public int Subcategory_id { get; set; }
        [Column("Subcategory_name")]
        public String Subcategory_name { get; set; }

        public Subcategory() {}

        public Subcategory( int subcategory_id, string subcategory_name ) {
            Subcategory_id = subcategory_id;
            Subcategory_name = subcategory_name;
        }
    }
}
