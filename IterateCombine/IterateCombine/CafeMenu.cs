
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IterateCombine
{
    public class CafeMenu:Menu
    {
        Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            MenuItem item1 = new MenuItem("bitcoffee","this is a bit coffee",false,3.33);
            MenuItem item2 = new MenuItem("sugarcoffee", "this is a sugar coffee", false, 4.33);
            AddItem(item1);
            AddItem(item2);
            
        }
        public void AddItem(MenuItem item)
        {
            menuItems.Add(item.getName(), item);
        }
        public Hashtable GetTable()
        {
            return menuItems;
        }

        public Iterator createIterator()
        {
            return new CafeMenuIterator(menuItems);
        }

    }
}
