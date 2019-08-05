
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class PizzaStore
    {
       public abstract Pizza createPizza(string type);
       public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
     
    }
}
