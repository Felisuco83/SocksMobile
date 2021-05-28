using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Category
    {

        public int Category_id { get; set; }
        public String Category_name { get; set; }
        public String Category_description { get; set; }

        public Category() { }

        public Category(int category_id, string category_name,
            string category_description)
        {
            Category_id = category_id;
            Category_name = category_name;
            Category_description = category_description;
        }
    }
}