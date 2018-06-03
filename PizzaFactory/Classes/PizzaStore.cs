using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Classes
{
    public abstract class PizzaStore
    {
        //PizzaFactory factory;

        //public PizzaStore(PizzaFactory fact)
        //{
        //    factory = fact;
        //}

        public Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }

        public abstract Pizza CreatePizza(string type);
    }
}
