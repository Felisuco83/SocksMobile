using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Size
    {

        public int Size_id { get; set; }
        public String Size_US { get; set; }
        public String Size_EUR { get; set; }
        public String Size_UK { get; set; }

        public Size() { }

        public Size(int size_id, string size_US,
            string size_EUR, string size_UK)
        {
            Size_id = size_id;
            Size_US = size_US;
            Size_EUR = size_EUR;
            Size_UK = size_UK;
        }
    }
}