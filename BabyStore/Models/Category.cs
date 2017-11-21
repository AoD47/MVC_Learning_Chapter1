﻿using System.Collections.Generic;

namespace BabyStore.Models
{
    public partial class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}