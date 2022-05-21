using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectByTasks();
        }

        /// <summary>
        /// Метод меню для выбора Задачи
        /// </summary>
        static void SelectByTasks()
        {
            Console.WriteLine("===============Домашная работа №3========================");
            Console.WriteLine();
            Console.WriteLine("Задача номер 1. Вывести элементы массива по диагонали.");
            Console.WriteLine("Задача номер 2. Создать телефонный справочник.");
            Console.WriteLine("Задача номер 3. Вывести строку обратном порядке.");
            Console.WriteLine("Задача номер 4. Нарисовать игру Морской бой (до конца не разработал)");
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.Write("Выберите номер задачи:");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (true)

            {
                switch (numb)
                {
                    case 1:
                        ArrayByDiagonal();
                        Console.ReadKey();
                        return;
                    case 2:
                        PhoneBook();
                        Console.ReadKey();
                        return;
                    case 3:
                        ReverseText();
                        Console.ReadKey();
                        return;
                    case 4:
                        SeaBattle.PrintSeaBattle();
                        Console.ReadKey();
                        return;
                    case 0:
                        Console.WriteLine("Завершение работы приложение, нажмите любую кнопку");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Номер задачи в диапазоне 1-4. Повторите вводит номер задач");
                        SelectByTasks();
                        return;
                }
            }
        }


        /// <summary>
        /// Первая задача. Вывести элементы массива по диагонали 
        /// </summary>
        static void ArrayByDiagonal()
        {
            Console.WriteLine("Задача номер 1. Вывести элементы массива по диагонали");
            Console.WriteLine("=====================================================");
            Console.WriteLine();
            Console.WriteLine("Введите размер массива!!!");
            Console.Write("Введите размер строки:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер столбца:");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] arrays = new int[rows, columns];
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    arrays[i, j] = (i + 1) * (j + 1);
                }
            }
            int padLeft = 0;
            Console.WriteLine();
            Console.WriteLine("элементы массива до диагонали");
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    Console.WriteLine(arrays[i, j].ToString().PadLeft(padLeft += 2, ' '));
                }
            }
        }

        /// <summary>
        /// Вторая задача. Создать телефонный справочник с помощью двумерного массива
        /// </summary>
        static void PhoneBook()
        {
            Console.WriteLine("Задача номер 2. Создать телефонный справочник");
            Console.WriteLine("============================================");
            Console.WriteLine();
            string[,] phoneBook = new string[5, 2] {
                { "Name", "Phone/Email" },
                {"DAD", "+998 90 425 57 67/ahmad.muhammadiev@gmail.com" },
                {"MOM", "+99890 906 54 16/gulya.azimova@gmail.com" },
                {"Brother", "+998 90 512 83 45/chingi3@gmail.com" },
                {"Sister", "+99890 461 92 40/guzaliya.muhammadieva@gmail.com" }
            };
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i, j]}\t\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Третья задача. Вывести строку обратном порядке
        /// </summary>
        static void ReverseText()
        {
            Console.WriteLine("Задача номер 3. Строка обратном порядке");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.Write("Введите строку:");
            string text = Console.ReadLine();
            string reverseText = Reverse(text);
            Console.Write($"Строка обратном порядке:{reverseText}");
        }

        /// <summary>
        /// Метод возвращающий обратный текст
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Reverse(string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
    }
}
