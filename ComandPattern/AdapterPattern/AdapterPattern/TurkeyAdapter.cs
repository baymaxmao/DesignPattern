
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class TurkeyAdapter : Duck
    {
        Turkey turkey;
        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }
        public void fly()
        {
            for (int i = 0; i < 5; i++)
                turkey.fly();
        }

        public void quack()
        {
            turkey.Google();
        }
    }
}
