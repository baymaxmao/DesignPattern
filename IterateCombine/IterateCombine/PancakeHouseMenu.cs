using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    class PancakeHouseMenu:Menu
    {
        public List<MenuItem> lst=new List<MenuItem>();
        public PancakeHouseMenu()
        {
            MenuItem item = new MenuItem("pan","pancakehouse",false,2.11);
            AddItem(item);
            item = new MenuItem("pan2", "pancakehouse2", false, 2.33);
            AddItem(item);

        }
        public Iterator createIterator()
        {
            return new PancakeHouseIterator(lst);
        }
        public void AddItem(MenuItem item)
        {
            lst.Add(item);
        }

        
    }
}
