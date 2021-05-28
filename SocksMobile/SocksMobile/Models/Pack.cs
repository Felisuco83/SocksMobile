using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Pack
    {

        public int Pack_id { get; set; }
        public String Pack_name { get; set; }
        public int Pack_product { get; set; }
        public int Pack_discount { get; set; }

        public Pack() { }
        public Pack(int pack_id, string pack_name,
            int pack_product, int pack_discount)
        {
            Pack_id = pack_id;
            Pack_name = pack_name;
            Pack_product = pack_product;
            Pack_discount = pack_discount;
        }
    }
}