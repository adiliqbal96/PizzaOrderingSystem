using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Order
    {
        private PizzaMenu menu;

        public Order()
        {
            menu = new PizzaMenu();
        }

        public void PlaceOrder()
        {
            Console.Write("Select a pizza (enter the number): ");
            int selectedPizzaIndex = int.Parse(Console.ReadLine()) - 1;
            Pizza selectedPizza = menu.GetPizza(selectedPizzaIndex);

            Console.WriteLine($"You selected {selectedPizza.Name}.");

            Console.Write("Would you like to add extra toppings? (yes/no): ");
            string addToppings = Console.ReadLine().ToLower();

            List<string> toppings = new List<string>();
            if (addToppings == "yes")
            {
                // The different topping choices
                Console.WriteLine("Available toppings:");
                Console.WriteLine("1. Tomato");
                Console.WriteLine("2. Cheese");
                Console.WriteLine("3. Pepperoni");
                Console.WriteLine("4. Chicken");
                Console.WriteLine("5. Pineapple");
                Console.WriteLine("6. Tuna");
                

                Console.Write("Enter the numbers of the toppings you'd like (separated by commas) each extra topping cost 10kr: ");
                string[] selectedToppingsIndices = Console.ReadLine().Split(',');

                foreach (string index in selectedToppingsIndices)
                {
                    int toppingIndex = int.Parse(index.Trim());
                    string topping = GetToppingName(toppingIndex);
                    toppings.Add(topping);
                }

                Console.WriteLine("Toppings added.");
            }

            // Display toppings
            if (toppings.Count > 0)
            {
                Console.WriteLine("Selected toppings:");
                foreach (string topping in toppings)
                {
                    Console.WriteLine("- " + topping);
                }
            }

            // Calculate and display total price
            decimal totalPrice = selectedPizza.Price + (toppings.Count * 10); //Each topping costs 10 kr
            Console.WriteLine($"Total Price: {totalPrice} kr");
        }

        private string GetToppingName(int index)
        {
            switch (index)
            {
                case 1:
                    return "Tomato";
                case 2:
                    return "Cheese";
                case 3:
                    return "Pepperoni";
                case 4:
                    return "Chicken";
                case 5:
                    return "Pineapple";
                case 6:
                    return "Tuna";
               
                default:
                    return "";
            }
        }
    }
}