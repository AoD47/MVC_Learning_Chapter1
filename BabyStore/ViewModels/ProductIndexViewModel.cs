using BabyStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BabyStore.ViewModels
{
    public class ProductIndexViewModel
    {
        public IQueryable<Product> Products { get; set; }
        public string Search { get; set; }
        
    }
}