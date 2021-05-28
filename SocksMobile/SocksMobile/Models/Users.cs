using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    public class Users
    {

        public int Users_id { get; set; }
        public String Users_name { get; set; }
        public String Users_email { get; set; }
        public String User_password { get; set; }
        public String User_nationality { get; set; }
        public String User_phone { get; set; }
        public DateTime User_birthDate { get; set; }

        public Users() { }

        public Users(int users_id, string users_name, string users_email,
            string user_password, string user_nationality, string user_phone,
            DateTime user_birthDate)
        {
            Users_id = users_id;
            Users_name = users_name;
            Users_email = users_email;
            User_password = user_password;
            User_nationality = user_nationality;
            User_phone = user_phone;
            User_birthDate = user_birthDate;
        }
    }
}