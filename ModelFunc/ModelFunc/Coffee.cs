
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ModelFunc
{
    class Coffee:BaseAlgorithm
    {
        public override void brew()
        {
            Console.WriteLine("Coffee Brew");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Coffe AddCondiments");
        }
        public override bool customerWantsCondiment()
        {
            Console.WriteLine("");
            string answer =getUserInput();
            if (answer.ToLower().StartsWith("y"))
                return true;
            else
                return false;

        }
        private string getUserInput()
        {
             Console.WriteLine("would you like milk and sugar with your coffee(y/n)\n");
             string answer = Console.ReadKey().Key.ToString();
             return answer;
            
        }
    }
}
