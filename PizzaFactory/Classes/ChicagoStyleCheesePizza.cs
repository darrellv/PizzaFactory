using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Classes
{
    public class ChicagoStyleCheesePizza : Pizza 
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzerella Cheese");

        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into square slices");
        }
    }
}
