
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    public class DinerMenu:Menu
    {
        readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menu;
        public DinerMenu()
        {
            menu = new MenuItem[MAX_ITEMS]; 
            MenuItem item1 = new MenuItem("din", "dinner", false, 2.11);
            AddItem(item1);
            MenuItem item2 = new MenuItem("din2", "dinner2", true, 2.44);
            AddItem(item2);
            
        }
        public Iterator createIterator()
        {
            return new DinerMenuIterator(menu);
        }
        public bool AddItem(MenuItem item)
        {
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("菜单已满，无法添加");
                return false;
            }
            else
            {
                menu[numberOfItems++] = item;
            } 
            return true;
        }
    }
}
