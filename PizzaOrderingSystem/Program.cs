﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzaOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Big Mammas Pizzaria!");
            PizzaMenu menu = new PizzaMenu();
            menu.DisplayMenu();

            Order order = new Order();
            order.PlaceOrder();

            Console.ReadLine();
        }
    }
}
