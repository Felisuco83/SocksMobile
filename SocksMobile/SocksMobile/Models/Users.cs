using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {

    [Table("Users")]
    public class Users {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Users_id")]
        public int Users_id { get; set; }

        [Column("Users_name")]
        public String Users_name { get; set; }

        [Column("Users_lastName")]
        public String Users_lastName { get; set; }

        [Column("Users_email")]
        public String Users_email { get; set; }

        [Column("Users_password")]
        public String User_password { get; set; }

        [Column("Users_nationality")]
        public String User_nationality { get; set; }

        [Column("Users_phone")]
        public String User_phone { get; set; }

        [Column("Users_birthDate")]
        public DateTime User_birthDate { get; set; }

        [Column("Users_gender")]
        public String Users_gender { get; set; }

        [Column("Users_salt")]
        public String Users_salt { get; set; }

        public Users() {}

        public Users (string users_name, string users_email, string user_password) {
            Users_name = users_name;
            Users_email = users_email;
            User_password = user_password;
        }

        public Users (int users_id, string users_name, string users_email, 
            string user_password, string user_nationality, string user_phone, 
            DateTime user_birthDate, string users_gender, string users_salt) {
            Users_id = users_id;
            Users_name = users_name;
            Users_email = users_email;
            User_password = user_password;
            User_nationality = user_nationality;
            User_phone = user_phone;
            User_birthDate = user_birthDate;
            Users_gender = users_gender;
            Users_salt = users_salt;
        }
    }
}
