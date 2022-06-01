using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HomeWork5
{
    internal class Program
    {
        static string result = "";
        static void Main(string[] args)
        {
            DoToList[] doToLists = new DoToList[] { new DoToList(), new DoToList(), new DoToList(), new DoToList() };
            new DoToList().CompleteTasks(doToLists);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Зажача номер 1. Записать в текст набор данных с клавиатуры
        /// </summary>
        public static void Task1()
        {
            Console.WriteLine("Домашная задание 1. Записать в текст набор данных с клавиатуры");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.Write("Введите набор данных:");
            string text = Console.ReadLine();
            string file = "text.txt";
            File.WriteAllText(file, text);
        }

        /// <summary>
        /// Задача номер 2. При старте дописывает текущее время в файл <<startup.txt>>
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("Домашная задание 2. При старте дописывает текущее время в файл <<startup.txt>>");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            Console.Write("Введите набор данных:");
            string text = Console.ReadLine();
            string file = "startup.txt";
            File.AppendAllLines(file, new[] { text, DateTime.Now.ToString() });
        }
        /// <summary>
        /// Задача номер 3. Ввести с клавиатуры произвольный набор чисел (0-255), и записать бинарный файл
        /// </summary>
        public static void Task3()
        {
            Console.WriteLine("Домашная задание 3. Ввести с клавиатуры произвольный набор чисел (0-255), и записать бинарный файл");
            Console.WriteLine("=================================================================================================");
            Console.WriteLine();
            Random random = new Random();
            int length = random.Next(0, 10);
            Console.WriteLine("Размер массива:" + length);
            byte[] bytes = new byte[length];
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write($"Введите bytes[{i + 1}]:");
                bytes[i] = Convert.ToByte(Console.ReadLine());
            }
            string file = "bytes.bin";
            File.WriteAllBytes(file, bytes);
        }

        /// <summary>
        /// Задача номер 4.  Создать дерево иерархии каталогов и файлов по заданному пути и записать в текстовой файл, с рекурсии и без рекурсии
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("Домашная задание 4. Создать дерево иерархии каталогов и файлов по заданному пути и записать в текстовой файл, с рекурсии и без рекурсии");
            Console.WriteLine("======================================================================================================================================");
            Console.WriteLine();
            RecursionPrintDir(new DirectoryInfo(@"C:\Users\User\source\repos\ConsoleApp1"), "", true);
            //NotRecursionPrintDir(new DirectoryInfo(@"C:\Users\User\source\repos\ConsoleApp1"), "", true);
        }

        /// <summary>
        /// Рекурсивный метод для создание дерево иерархии каталогов и файлов
        /// </summary>
        /// <param name="directory"> путь к каталогам и файлам</param>
        /// <param name="indent">отступ для рисование дерево</param>
        /// <param name="lastDirectory"> проверяет, последный ли каталог в этом уровне</param>
        static void RecursionPrintDir(DirectoryInfo directory, string indent, bool lastDirectory)
        {
            string _file = "directAndFile.txt";
            Console.Write(indent);
            result += indent;
            Console.Write(lastDirectory ? "└─" : "├─");
            result += (lastDirectory ? "└─" : "├─");
            indent += lastDirectory ? " " : "│ ";
            Console.WriteLine(directory.Name);
            result += directory.Name + "\n";

            DirectoryInfo[] directories = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();
            for (int i = 0; i < directories.Length; i++)
            {
                foreach (var file in files)
                {
                    Console.Write(indent);
                    result += indent;
                    Console.Write(lastDirectory ? "" : "├─");
                    result += (lastDirectory ? "" : "├─");
                    indent += lastDirectory ? "" : "";
                    Console.WriteLine(file);
                    result += file + "\n";
                }
                RecursionPrintDir(directories[i], indent, i == directories.Length - 1);
            }
            File.WriteAllText(_file, result);
        }


        /// <summary>
        /// До конца не смог разработать метод без рекурсии
        /// </summary>
        /// <param name="directory"></param>
        static void NotRecursionPrintDir(DirectoryInfo directory)
        {
            Console.WriteLine(directory.Name);
            DirectoryInfo[] directories = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();
            foreach (var dir in directories)
            {
                if (dir.Exists)
                    Console.WriteLine("  " + dir.Name);
            }
            //........................................
        }
    }
}
