using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HomeWork4
{
    internal class Program
    {
        /// <summary>
        /// Перечисление времена года
        /// </summary>
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            ShowMenu();
        }

        /// <summary>
        /// Меню, для выбора задач.
        /// </summary>
        static void ShowMenu()
        {
            Console.WriteLine("============Домашная работа номер 4.===================");
            Console.WriteLine("Выберите номер задачи. От 1 до 4");
            Console.WriteLine("========================================================");
            Console.WriteLine("Задача номер 1: Написать метод GetFullName() для возврата полного имени человека");
            Console.WriteLine("Задача номер 2: Найти сумму цифр в строке");
            Console.WriteLine("Задача номер 3: Метод, для определения времена года по номеру месяца");
            Console.WriteLine("Задача номер 4: Найти число Фибоначчи с помощью рекурсии");
            Console.Write("Номер задачи:");
            int number = ReadInt();
            while (true)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложение.");
                        return;
                    case 1:
                        GetFullName();
                        return;
                    case 2:
                        CallMethodDigitSum();
                        Console.ReadKey();
                        return;
                    case 3:
                        CallMethodFindSeason();
                        Console.ReadKey();
                        return;
                    case 4:
                        CallMethodRecursion();
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Введите номер задач от 1 до 4. Повторите вводит номер задач");
                        ShowMenu();
                        return;
                }
            }
        }




        /// <summary>
        /// Задача номер 1. Написать метод GetFullName() для вывести польное имя пользователя
        /// </summary>
        static void GetFullName()
        {
            Console.WriteLine("Задача номер 1. Написать метод GetFullName() для вывести польное имя пользователя");
            Console.WriteLine("============================================================================");
            Console.WriteLine();
            (string firstName, string lastName, string patronymic)[] users = CallMethod.CreateUsers();
            CallMethod.ShowMenu(users);
        }


        /// <summary>
        /// Задача номер 2. Метод для нахождение сумму цифр в строке
        /// </summary>
        static void CallMethodDigitSum()
        {
            Console.WriteLine("Задача номер 2. Метод для нахождение сумму цифр в строке");
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.Write("Введите строку с цифрами:");
            string input = Console.ReadLine();
            Console.WriteLine($"Сумма цифр в строке:{DigitSum(input)}");
        }

        /// <summary>
        /// Задача номер 3.  Метод, для определения времена года по номеру месяца
        /// </summary>
        static void CallMethodFindSeason()
        {
            Console.WriteLine("Задача номер 3.  Метод, для определения времена года по номеру месяца");
            Console.WriteLine("=====================================================================");
            Console.WriteLine();
            Console.Write("Введите номер месяца:");
            int number = ReadInt();
            Console.WriteLine($"Номер месяца:{number}, времена года:{FindSeasonByNumberMonth(number)}");
        }

        /// <summary>
        /// Задача номер 4. Метод для нахождение число Фибоначчи с помощью рекурсии
        /// </summary>
        static void CallMethodRecursion()
        {
            Console.WriteLine("Задача номер 4. Метод для нахождение число Фибоначчи с помощью рекурсии");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.Write("Введите номер:");
            int number = ReadInt();
            Console.WriteLine($"Для {number} число, фибоначчи равно:{Recursion(number)}");
        }
        /// <summary>
        /// Метод для нахождение сумму цифр в строке
        /// </summary>
        /// <param name="input"> строка с цифрами и пробелами</param>
        /// <returns></returns>
        static int DigitSum(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ('0' <= input[i] && input[i] <= '9')
                {
                    sum += (Convert.ToInt32(input[i]) - 48);
                }
            }
            return sum;
        }


        /// <summary>
        /// Метод, для определения времена года по номеру месяца
        /// </summary>
        /// <param name="number"> номер месяца</param>
        /// <returns></returns>
        static Seasons FindSeasonByNumberMonth(int number)
        {
            if (number < 0 || number > 12)
                Console.WriteLine("Введите число от 1 до 12");
            switch (number)
            {
                case 1:
                case 2:
                case 12:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                default:
                    break;
            }
            return 0;
        }


        /// <summary>
        /// Метод для нахождение число Фибоначчи с помощью рекурсии
        /// </summary>
        /// <param name="numb">номер последнего число фибоначчи</param>
        /// <returns></returns>
        static int Recursion(int numb)
        {
            if (numb == 0 || numb == 1)
            {
                return 1;
            }
            return Recursion(numb - 2) + Recursion(numb - 1);
        }

        static int ReadInt() => Convert.ToInt32(Console.ReadLine());
    }
}
