﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Classes
{
    public class NYStyleCheesePizza : Pizza 
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");


        }
    }
}
