using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Favorite
    {

        public int Favorite_id { get; set; }
        public int Favorite_product { get; set; }
        public int Favorite_pack { get; set; }
        public int Favorite_user { get; set; }

        public Favorite() { }

        public Favorite(int favorite_id, int favorite_product,
            int favorite_pack, int favorite_user)
        {
            Favorite_id = favorite_id;
            Favorite_product = favorite_product;
            Favorite_pack = favorite_pack;
            Favorite_user = favorite_user;
        }
    }
}