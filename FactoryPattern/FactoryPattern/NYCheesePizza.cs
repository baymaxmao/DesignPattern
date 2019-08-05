
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredient;

namespace FactoryPattern
{
    class NYCheesePizza : CheesePizza
    {
        NYPizzaIngredientFactory pif = new NYPizzaIngredientFactory();
        public NYCheesePizza(PizzaIngredientFactory pif) : base(pif)
        {

        }
    }
}
