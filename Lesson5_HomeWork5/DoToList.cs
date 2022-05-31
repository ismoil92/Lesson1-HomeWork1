using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson5_HomeWork5
{
    /// <summary>
    /// Класс создание список задач, для выполнение
    /// </summary>
    internal class DoToList
    {
        /// <summary>
        /// Поля
        /// </summary>
        #region FIELDS
        const string file = @"C:\Users\User\source\repos\ConsoleApp1\ConsoleApp1\tasks.json";
        string copyfile = null;
        int task1 = 1, task2 = 1, task3 = 1, task4 = 1, count = 0;
        #endregion

        /// <summary>
        /// Свойство
        /// </summary>
        #region PROPERTIES
        public string Title { get; set; }
        public bool IsDone { get; set; }
        #endregion

        /// <summary>
        /// Конструкторы
        /// </summary>
        #region CONSTRUCTORS
        public DoToList()
        {
            Title = "";
            IsDone = false;
        }

        public DoToList(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }
        #endregion

        /// <summary>
        /// Метод для выполнение всех задач
        /// </summary>
        /// <param name="doToLists"> массив задач</param>
        public void CompleteTasks(DoToList[] doToLists)
        {
            PrintTasks();
            while (true)
            {
                for (int i = 0; i < doToLists.Length; i++)
                {
                    if (count == 4)
                    {
                        break;
                    }
                    doToLists[i] = SelectTasks();
                    CompletePrintTasks(doToLists[i]);
                }
                if (count == 4)
                {
                    break;
                }
            }
            File.Delete(copyfile);
        }

        /// <summary>
        /// Метод, для вывода на экран выполненную задачи
        /// </summary>
        /// <param name="doToList">выбранная задача</param>
        void CompletePrintTasks(DoToList doToList)
        {
            if (copyfile == null)
            {
                copyfile = "file.json";
                File.Copy(file, copyfile);
            }
            string json = File.ReadAllText(copyfile);
            Dictionary<string, string> tasks = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            Dictionary<string, string> prints = new Dictionary<string, string>();
            foreach (var task in tasks)
            {
                if (doToList.IsDone && doToList.Title == task.Key)
                {
                    prints.Add(task.Key, (task.Value + " -X"));
                    Console.WriteLine($"{task.Key}:{task.Value} -X");
                    Console.WriteLine();
                    count++;
                }
                else
                {
                    prints.Add(task.Key, task.Value);
                    Console.WriteLine($"{task.Key}:{task.Value}");
                    Console.WriteLine();
                }
            }
            string json2 = JsonSerializer.Serialize<Dictionary<string, string>>(prints);
            File.WriteAllText(copyfile, json2);
        }

        /// <summary>
        /// Метод, для вывода на экран задачи
        /// </summary>
        void PrintTasks()
        {
            string json = File.ReadAllText(file);
            Dictionary<string, string> tasks = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Key}:{task.Value}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод для выборке задач.
        /// </summary>
        /// <returns> Возвращает выбранную задачу</returns>
        DoToList SelectTasks()
        {
            Console.Write("Выберите задачу от 1 до 4:");
            int tasknumb = Convert.ToInt32(Console.ReadLine());
            switch (tasknumb)
            {
                case 1:
                    if (task1 == 2)
                    {
                        Console.WriteLine($"Задача номер:{tasknumb} выполнено");
                        return new DoToList("", false);
                    }
                    Program.Task1();
                    IsDone = true;
                    Title = "Task1";
                    task1++;
                    return new DoToList(Title, IsDone);
                case 2:
                    if (task2 == 2)
                    {
                        Console.WriteLine($"Задача номер:{tasknumb} выполнено");
                        return new DoToList("", false);
                    }
                    Program.Task2();
                    IsDone = true;
                    Title = "Task2";
                    task2++;
                    return new DoToList(Title, IsDone);
                case 3:
                    if (task3 == 2)
                    {
                        Console.WriteLine($"Задача номер:{tasknumb} выполнено");
                        return new DoToList("", false);
                    }
                    Program.Task3();
                    IsDone = true;
                    Title = "Task3";
                    task3++;
                    return new DoToList(Title, IsDone);
                case 4:
                    if (task4 == 2)
                    {
                        Console.WriteLine($"Задача номер:{tasknumb} выполнено");
                        return new DoToList("", false);
                    }
                    Program.Task4();
                    IsDone = true;
                    Title = "Task4";
                    task4++;
                    return new DoToList(Title, IsDone);
                case 0:
                    return null;
                default:
                    Console.WriteLine("Введите номер задач от 1-4. Повторите попытку!!");
                    return null;
            }
        }
    }
}
