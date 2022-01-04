﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

    }
}
