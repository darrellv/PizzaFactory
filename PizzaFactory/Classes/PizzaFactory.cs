using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Classes
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            if (type.Equals("clam"))
                pizza = new ClamPizza();
            if (type.Equals("veggie"))
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}
