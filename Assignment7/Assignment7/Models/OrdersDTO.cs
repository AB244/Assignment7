﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment7.Models
{
    public class OrdersDTO
    {
        public class Detail
        {
            public int ProductID { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        public IEnumerable<Detail> Details { get; set; }
    }
}