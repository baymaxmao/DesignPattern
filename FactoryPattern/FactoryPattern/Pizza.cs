
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredient;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        String name;
        public Dough dough;
        public  Sauce sauce;
        public Cheese cheese;
        public abstract void prepare();
      
        public void bake()
        {
        }
        public void cut()
        {

        }
        public void box()
        {

        }

    }
}
