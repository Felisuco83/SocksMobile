using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Collections")]
    public class Collections {

        [Key]
        [Column("Collections_id")]
        public int Collections_id { get; set; }
        [Column("Collections_name")]
        public String Collections_name { get; set; }
        [Column("Collections_discount")]
        public int Collections_discount { get; set; }

        public Collections() { }

        public Collections( int collections_id, string collections_name, 
            int collections_discount ) {
            Collections_id = collections_id;
            Collections_name = collections_name;
            Collections_discount = collections_discount;
        }
    }
}
