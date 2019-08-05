using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    class Program
    {
        static void Main(string[] args)
        {

            TestTwo();
        }
        public static void TestTwo()
        {

            MenuComponent pancakeHousMenu = new MenuTree("Pancake house menu","breakfast");
            MenuComponent dinerMenu = new MenuTree("Diner menu", "lunch");
            MenuComponent cafeMenu = new MenuTree("Cafe menu","cafe");
            MenuComponent dessertMenu = new MenuTree("Dessert menu", "dessert");
            MenuComponent allMenus = new MenuTree("All Menus", "All menu combined");
            allMenus.add(pancakeHousMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);
            dinerMenu.add(new LeafComponent("Pasta", "Spaghetti with Marinara Sauce,and a slice of sourdough bread", true, 3.89));
            dinerMenu.add(dessertMenu);
            dessertMenu.add(new LeafComponent("Apple pie", "Apple pie with a flakey crust,topped with vanilla ice cream", true, 1.59));
            WaitressOne waitress = new WaitressOne(allMenus);
            // waitress.print();
            waitress.printVegetarianMenu();
            Console.ReadKey();
        }
        public static void TestOne()
        {
            PancakeHouseMenu pan = new PancakeHouseMenu();
            DinerMenu din = new DinerMenu();
            CafeMenu cafe = new CafeMenu();
            List<Menu> lst = new List<Menu>();
            lst.Add(din);
            lst.Add(pan);
            lst.Add(cafe);
            Waitress waitress = new Waitress(lst);
            waitress.printMenu();
            Console.ReadLine();
        }
    }
}
