using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class PizzaMenu
    {
        private List<Pizza> pizzas;

        public PizzaMenu()
        {
            pizzas = new List<Pizza>
            {
                new Pizza("Margherita - Tomato & Cheese", 69),
                new Pizza("Vesuvio - Tomato, Cheese & Ham", 75),
                new Pizza("Capricciosa - Tomato, Cheese, Ham & Mushrooms ", 80),
                new Pizza("Calzone - Baked pizza with Tomatoes, Cheese, Ham & Mushrooms", 80),
                new Pizza("Quattro Stagioni - Tomato, Cheese, Ham, Mushrooms, Shrimps & Peppers", 85),
                new Pizza("Marinara - Tomato, Cheese, Shrimp & Garlic ", 85),
                new Pizza("Vegetarian - Tomato, Cheese & Vegetables", 80),
                new Pizza("Italiana - Tomato, Cheese, Onions & Meat Sauce", 75),
                new Pizza("Gorgonzola - Tomato, Gorgonzola, Onions & Mushrooms", 85),
                new Pizza("Contadina - Tomato, Cheese, Olives & Mushrooms", 75),
                new Pizza("Naples - Tomato, Cheese, Anchovies & Olives", 79),
                new Pizza("Vichinga - Tomato, Cheese, Ham, Mushrooms, Peppers, Garlic & Chilli", 80),
                new Pizza ("Calzone Special - (Not baked) Tomato, Cheese, Shrimp, Ham & Meat sauce", 80),
                new Pizza ("Esotica - Tomato, Cheese, Ham, Shrimp & Pineapple", 80),
                new Pizza ("Tonno - Tomato, Cheese, Tuna & Shrimp", 85),
                new Pizza ("Sardegna - Tomato, Cheese, Conctail sausages, Bacon, Onions & Eggs", 80),
                new Pizza ("Romana - Tomato, Cheese, Ham, Bacon & Onion", 78),
                new Pizza ("Sole - Tomato, Cheese, Ham, Bacon & Eggs", 80),
                new Pizza ("Big Mamma - Tomato, Gorgonzola, Shrimp, Asparges & Parma ham", 90),
    
            };
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzas[i].Name} - {pizzas[i].Price} kr");
            }
        }

        public Pizza GetPizza(int index)
        {
            return pizzas[index];
        }
    }
}
