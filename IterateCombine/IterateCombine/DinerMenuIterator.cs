using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    class DinerMenuIterator : Iterator
    {
        MenuItem[] menu;
        int position = 0;
        public DinerMenuIterator(MenuItem[] menu)
        {
            this.menu = menu;
        }
        public bool hasNext()
        {
            if (position >= menu.Length || menu[position] == null)
                return false;
            else
                return true;
        }
        public object Next()
        {
            MenuItem item = menu[position];
            position = position + 1;
            return item;
        }
    }
}
