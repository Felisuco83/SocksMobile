using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Favorite")]
    public class Favorite {

        [Key]
        [Column("Favorite_id")]
        public int Favorite_id { get; set; }
        [Column("Favorite_product")]
        public int Favorite_product { get; set; }
        [Column("Favorite_user")]
        public int Favorite_user { get; set; }

        public Favorite() { }

        public Favorite( int favorite_id, int favorite_product, 
            int favorite_user ) {
            Favorite_id = favorite_id;
            Favorite_product = favorite_product;
            Favorite_user = favorite_user;
        }
    }
}
