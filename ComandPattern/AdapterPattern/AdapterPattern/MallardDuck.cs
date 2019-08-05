using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void quack()
        {
            Console.WriteLine("quack");
        }
        
    }
}
