using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Subcategory
    {

        public int Subcategory_id { get; set; }
        public String Subcategory_name { get; set; }

        public Subcategory() { }

        public Subcategory(int subcategory_id, string subcategory_name)
        {
            Subcategory_id = subcategory_id;
            Subcategory_name = subcategory_name;
        }
    }
}