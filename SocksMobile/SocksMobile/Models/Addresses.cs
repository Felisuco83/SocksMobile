using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Addresses
    {

        public int Addresses_id { get; set; }
        public int Addresses_user { get; set; }
        public String Addresses_name { get; set; }
        public String Addresses_street { get; set; }
        public String Addresses_cp { get; set; }
        public String Addresses_country { get; set; }
        public String Addresses_province { get; set; }
        public String Addresses_city { get; set; }

        public Addresses() { }

        public Addresses(int addresses_id, int addresses_user,
            string addresses_name, string addresses_street,
            string addresses_cp, string addresses_country,
            string addresses_province, string addresses_city)
        {
            Addresses_id = addresses_id;
            Addresses_user = addresses_user;
            Addresses_name = addresses_name;
            Addresses_street = addresses_street;
            Addresses_cp = addresses_cp;
            Addresses_country = addresses_country;
            Addresses_province = addresses_province;
            Addresses_city = addresses_city;
        }
    }
}