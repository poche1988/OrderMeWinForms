﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        public string Name { get; set; }

        public Brand Brand { get; set; }

        public bool active { get; set; }
    }
}
