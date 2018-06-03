using System;
using System.Collections.Generic;
using System.Text;
using PizzaFactory.Interfaces;

namespace PizzaFactory.Classes
{
    public abstract class Pizza
    {
        public List<string> Toppings { get; set; }

        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding Toppings:");

            foreach (string topping in Toppings)
            {
                Console.WriteLine("     {0}", topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }

}
