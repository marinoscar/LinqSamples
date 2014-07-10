using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new PartsRepository();
            target.InitializeDemoData();
            Console.WriteLine("Quering data...");
            Console.WriteLine();

            foreach (var part in target.GetPartsByPartType("Interior"))
            {
               Console.WriteLine(part);
            }

            Console.WriteLine();
            Console.WriteLine("That's all folks");
            Console.ReadKey();
        }
    }
}
