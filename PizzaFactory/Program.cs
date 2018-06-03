using System;
using PizzaFactory.Classes;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0}{1}", pizza.Name, Environment.NewLine);

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a {0}{1}", pizza.Name, Environment.NewLine);

            Console.ReadLine();
        }
    }
}
