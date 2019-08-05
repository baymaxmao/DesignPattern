using System;

namespace ModelFunc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Tea tea = new Tea();
            coffee.TemplateMethod();
            Console.WriteLine("/**********************/");
            tea.TemplateMethod();
            Console.ReadLine();           
        }
    }
}
