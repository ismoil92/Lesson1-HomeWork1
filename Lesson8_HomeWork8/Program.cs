using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашная работа номер 8. Свойство проекта");
            Console.WriteLine("========================================");
            Console.WriteLine();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Greetings))
            {
                Console.WriteLine(Properties.Settings.Default.Greetings);
                Console.WriteLine($"Имя пользователя:{Properties.Settings.Default.UserName}");
                Console.WriteLine($"Возраст пользователя:{Properties.Settings.Default.UserAge}");
                Console.WriteLine($"Род деятельность  пользователя:{Properties.Settings.Default.UserJob}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Введите имя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Введите возраст:");
                Properties.Settings.Default.UserAge = int.Parse(Console.ReadLine());
                Console.Write("Введите профессию:");
                Properties.Settings.Default.UserJob = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Имя пользователя:{Properties.Settings.Default.UserName}");
                Console.WriteLine($"Возраст пользователя:{Properties.Settings.Default.UserAge}");
                Console.WriteLine($"Род деятельность пользователя:{Properties.Settings.Default.UserJob}");
            }
            Console.ReadKey(true);
        }
    }
}
