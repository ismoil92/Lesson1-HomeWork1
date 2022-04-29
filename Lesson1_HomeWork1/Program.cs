using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Привет, {name}, сегодня:{dateTime} !!!");
            Console.ReadKey();
        }
    }
}
