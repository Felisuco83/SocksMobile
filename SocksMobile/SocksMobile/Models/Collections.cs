using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Collections
    {

        public int Collections_id { get; set; }
        public String Collections_name { get; set; }
        public int Collections_discount { get; set; }

        public Collections() { }

        public Collections(int collections_id, string collections_name,
            int collections_discount)
        {
            Collections_id = collections_id;
            Collections_name = collections_name;
            Collections_discount = collections_discount;
        }
    }
}