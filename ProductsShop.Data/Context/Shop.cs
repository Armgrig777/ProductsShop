using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ProductsShop.Data.Context
{
    public class Shop
    {
        private readonly ILazyLoader _lazyLoader;
        public Shop()
        {

        }
        public Shop(ILazyLoader lazyLoader)
        {
            this._lazyLoader = lazyLoader;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        private List<Product> _products;
       
        public List<Product> products
        {
            get => _lazyLoader.Load(this,ref _products);
            set => _products = value;

        }

        
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
