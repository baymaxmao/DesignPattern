using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredient;

namespace FactoryPattern
{
    class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            dough = ingredientFactory.CreateDough();
            cheese = ingredientFactory.CreateCheese();
            sauce = ingredientFactory.CreateSauce();
        }
    }
}
