using System;

//装饰者模式需要进一步研究
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            Duck adapter = new TurkeyAdapter(turkey);
            Console.WriteLine("The turkey says...");
            turkey.Google();
            turkey.fly();
            Console.WriteLine("The duck says...");
            duck.quack();
            duck.fly();
            Console.WriteLine("The adapter says ...");
            adapter.quack();
            adapter.fly();
            Console.ReadKey();

        }
    }
}
