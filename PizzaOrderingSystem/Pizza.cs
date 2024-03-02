﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Pizza
    {
        public string Name { get; }
        public decimal Price { get; }

        public Pizza(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
