using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Orders
    {

        public int Orders_id { get; set; }
        public int Orders_user { get; set; }
        public DateTime Orders_date { get; set; }

        public Orders() { }

        public Orders(int orders_id, int orders_user,
            DateTime orders_date)
        {
            Orders_id = orders_id;
            Orders_user = orders_user;
            Orders_date = orders_date;
        }
    }
}