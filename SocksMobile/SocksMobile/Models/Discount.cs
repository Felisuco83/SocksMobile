using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {

    [Table("Discount")]
    public class Discount {

        [Key]
        [Column("Discount_id")]
        public int Discount_id { get; set; }
        [Column("Discount_name")]
        public String Discount_name { get; set; }
        [Column("Discount_value")]
        public float Discount_value { get; set; }
        [Column("Discount_code")]
        public String Discount_code { get; set; }
        [Column("Discount_date")]
        public DateTime Discount_date { get; set; }

        public Discount() { }

        public Discount( int discount_id, string discount_name, 
            float discount_value, string discount_code, DateTime discount_date ) {
            Discount_id = discount_id;
            Discount_name = discount_name;
            Discount_value = discount_value;
            Discount_code = discount_code;
            Discount_date = discount_date;
        }
    }
}
