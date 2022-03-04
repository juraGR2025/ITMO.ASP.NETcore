using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreProduct_1_1.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool IsCorrect { get; set; } = true;
        public void OnGet(string name, decimal? price)
        {
            if (price == null || price < 0 ||
            string.IsNullOrEmpty(name))
            {
                IsCorrect = false;
                return;
            }
            Price = price;
            Name = name;
        }
    }
}
