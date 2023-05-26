using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsShop.Data.Context
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
