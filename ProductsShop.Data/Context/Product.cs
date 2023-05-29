using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ProductsShop.Data.Context
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";
        public decimal? Price { get; set; }
        public int? Ammount { get; set; }

        [ForeignKey("Shop")]
        public int? ShopID { get; set; }
        public virtual Shop? ShopName { get; set; }

        

        public override string ToString()
        {
            return $"{Id}{Name}{Price}{Ammount}{ShopID}";
        }
    }
}
