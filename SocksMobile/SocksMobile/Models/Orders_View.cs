using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models {
    [Table("orders_View")]
    public class Orders_View {

        [Key]
        [Column("Order_Details_id")]
        public int Order_details_id { get; set; }

        [Column("Order_id")]
        public int Order_id { get; set; }

        [Column("Product_id")]
        public int Product_id { get; set; }

        [Column("Size_id")]
        public int Size_id { get; set; }

        [Column("Amount")]
        public int Amount { get; set; }

        [Column("Orders_user")]
        public int Order_user { get; set; }

        [Column("Orders_date")]
        public DateTime Order_date { get; set; }

        public Orders_View () { }

        public Orders_View (int order_details_id, int order_id, 
            int product_id, int size_id, int amount, int order_user, 
            DateTime order_date) {
            Order_details_id = order_details_id;
            Order_id = order_id;
            Product_id = product_id;
            Size_id = size_id;
            Amount = amount;
            Order_user = order_user;
            Order_date = order_date;
        }
    }
}
