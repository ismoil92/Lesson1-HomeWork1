using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HomeWork4
{
    internal class CallMethod
    {
        static Random random = new Random();

        /// <summary>
        /// Метод, вывод всех пользователей из массива
        /// </summary>
        /// <param name="users"> массив пользователей</param>
        public static void ShowMenu((string firstName, string lastName, string patronymic)[] users)
        {
            int choose;
            do
            {
                choose = Choose();
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        PrintUsers(users);
                        break;
                    case 2:
                        PrintUserSelected(users);
                        break;
                    default:
                        break;
                }
            } while (choose != 0);
        }


        /// <summary>
        /// Метод, для создания несколько пользователей
        /// </summary>
        /// <returns></returns>
        public static (string firstName, string lastName, string patronymic)[] CreateUsers()
        {
            int length = random.Next(0, 10);
            Console.WriteLine($"Размер массива:{length}");
            (string firstName, string lastName, string patronymic)[] users = new (string firstName, string lastName, string patronymic)[length];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = CreateUser();
            }
            Console.WriteLine("Пользователи записано в базу данных");
            Console.ReadKey();
            Console.Clear();
            return users;
        }


        /// <summary>
        /// Метод, возвращает польного имя для одного пользователя
        /// </summary>
        /// <param name="user">ИО для одного пользователя</param>
        /// <returns></returns>
        static string GetFullName((string firstName, string lastName, string patronymic) user)
        {
            return $"Имя:{user.firstName}, Фамилия:{user.lastName}, Отчество:{user.patronymic}";
        }


        /// <summary>
        /// Метод, Выборка
        /// </summary>
        /// <returns></returns>
        static int Choose()
        {
            Console.WriteLine("0- Завершение приложение");
            Console.WriteLine("1- Вывод всех пользователей");
            Console.WriteLine("2- Вывод пользователя по индексу");
            return ReadInt();
        }


        /// <summary>
        /// Метод, Вывод одного пользователя
        /// </summary>
        /// <param name="users"> массив пользователей</param>
        static void PrintUserSelected((string firstName, string lastName, string patronymic)[] users)
        {
            int index;
            do
            {
                Console.WriteLine($"Введите индекс от 0 до {users.Length - 1}");
                index = ReadInt();
            } while (index < 0 || index >= users.Length);
            Console.WriteLine(GetFullName(users[index]));
        }



        /// <summary>
        /// Вывод всех пользователей
        /// </summary>
        /// <param name="users"></param>
        static void PrintUsers((string firstName, string lastName, string patronymic)[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(GetFullName(users[i]));
            }
        }



        /// <summary>
        /// Метод, для создание одного пользователя
        /// </summary>
        /// <returns></returns>
        static (string firstName, string lastName, string patronymic) CreateUser()
        {
            Console.Write("Введите имя:");
            string firstName = ReadString();
            Console.Write("Введите фамилия:");
            string lastName = ReadString();
            Console.Write("Введите отчество:");
            string patronymic = ReadString();
            Console.WriteLine();
            return (firstName, lastName, patronymic);
        }


        /// <summary>
        /// Метод, ввод для строки
        /// </summary>
        /// <returns></returns>
        static string ReadString() => Console.ReadLine();


        /// <summary>
        /// Метод, ввод для целых чисел
        /// </summary>
        /// <returns></returns>
        static int ReadInt() => Convert.ToInt32(ReadString());
    }
}
