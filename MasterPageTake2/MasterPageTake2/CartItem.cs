﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterPageTake2
{
    public class CartItem
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}