using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Discount
    {

        public int Discount_id { get; set; }
        public String Discount_name { get; set; }
        public float Discount_value { get; set; }
        public String Discount_code { get; set; }
        public DateTime Discount_date { get; set; }

        public Discount() { }

        public Discount(int discount_id, string discount_name,
            float discount_value, string discount_code, DateTime discount_date)
        {
            Discount_id = discount_id;
            Discount_name = discount_name;
            Discount_value = discount_value;
            Discount_code = discount_code;
            Discount_date = discount_date;
        }
    }
}