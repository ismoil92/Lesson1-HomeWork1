using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HomeWorkd7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашная работа номер 7. Компиляция, декомпиляция и сборка.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            string secret = "hello";
            Console.Write("Enter to password:");
            string input = Console.ReadLine();
            if(input == secret)
            {
                Console.WriteLine("Welcome");
            }
            Console.ReadKey(true);
        }
    }
}
