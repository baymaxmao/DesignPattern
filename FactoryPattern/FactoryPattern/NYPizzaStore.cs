
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredient;

namespace FactoryPattern
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            NYPizzaIngredientFactory nyPIF = new NYPizzaIngredientFactory();
            if (type == "cheese")
            {
                return new NYCheesePizza(nyPIF);
            }
                
            return null;
        }
    }
}
