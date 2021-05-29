using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("Orders")]
    public class Orders {

        [Key]
        [Column("Orders_id")]
        public int Orders_id { get; set; }
        [Column("Orders_user")]
        public int Orders_user { get; set; }
        [Column("Orders_date")]
        public DateTime Orders_date { get; set; }

        public Orders() { }

        public Orders( int orders_id, int orders_user, 
            DateTime orders_date ) {
            Orders_id = orders_id;
            Orders_user = orders_user;
            Orders_date = orders_date;
        }
    }
}
