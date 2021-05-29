using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocksMobile.Models
{
    [Table("Pack")]
    public class Pack
    {

        [Key]
        [Column("Pack_id")]
        public int Pack_id { get; set; }
        [Column("Pack_name")]
        public String Pack_name { get; set; }
        [Column("Pack_product")]
        public int Pack_product { get; set; }
        [Column("Pack_discount")]
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