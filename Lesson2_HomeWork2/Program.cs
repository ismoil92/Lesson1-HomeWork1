using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HomeWork2
{
    internal class Program
    {
        /// <summary>
        /// Перечисление для месяца
        /// </summary>
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        /// <summary>
        /// Перечисление для недели 
        /// </summary>
        enum Week
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            SelectMethodByHomeWork();
            Console.ReadKey();
        }

        /// <summary>
        /// Первая задача. Найти средную температуру за сутки
        /// </summary>
        static void MiddleTemperature()
        {
            Console.WriteLine("Найти средную температуру за сутки");
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.Write("Введите максимальную температуру:");
            double maxTemperature = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную температуру:");
            double minTemperature = Convert.ToDouble(Console.ReadLine());
            double middleTemperature = (maxTemperature + minTemperature) / 2.0;
            Console.WriteLine($"Средная температура:{middleTemperature:F1}");
        }


        /// <summary>
        /// Вторая задача. Найти месяц по по номеру который ввел пользователь 
        /// </summary>
        static void SelectByMonthToNumber()
        {
            Console.WriteLine("Найти месяц по по номеру");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.Write("Введите номер месяца:");
            int numbMonth = Convert.ToInt32(Console.ReadLine());
            switch (numbMonth)
            {
                case (int)Month.Январь: Console.WriteLine(Month.Январь); break;
                case (int)Month.Февраль: Console.WriteLine(Month.Февраль); break;
                case (int)Month.Март: Console.WriteLine(Month.Март); break;
                case (int)Month.Апрель: Console.WriteLine(Month.Апрель); break;
                case (int)Month.Май: Console.WriteLine(Month.Май); break;
                case (int)Month.Июнь: Console.WriteLine(Month.Июнь); break;
                case (int)Month.Июль: Console.WriteLine(Month.Июль); break;
                case (int)Month.Август: Console.WriteLine(Month.Август); break;
                case (int)Month.Сентябрь: Console.WriteLine(Month.Сентябрь); break;
                case (int)Month.Октябрь: Console.WriteLine(Month.Октябрь); break;
                case (int)Month.Ноябрь: Console.WriteLine(Month.Ноябрь); break;
                case (int)Month.Декабрь: Console.WriteLine(Month.Декабрь); break; ;
                default:
                    Console.WriteLine($"Нет месяц с таким номером:{numbMonth}");
                    break;
            }
        }


        /// <summary>
        /// Третья задача. Определить является ли число чётным 
        /// </summary>
        static void CheckingEven()
        {

            Console.WriteLine("Определить является ли число чётным");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.Write("Введите число:");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.WriteLine("Число чётный");
            }
            else
            {
                Console.WriteLine("Число нечётный");
            }
        }

        /// <summary>
        /// Четёртая задача. Нарисовать товарный чек
        /// </summary>
        static void DrawingCheck()
        {
            Console.WriteLine("\tНарисовать товарный чек");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            int sum = 250000;
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("#######################################");
            Console.WriteLine("#\t       UZCARD \t              #");
            Console.WriteLine("#            Копия клиента            #");
            Console.WriteLine("#      ООО СП 'МАРКА Супермаркет'     #");
            Console.WriteLine("#    Ташкент, улица Карасув дом 17    #");
            Console.WriteLine("#\t\t\t\t      #");
            Console.WriteLine("#        Номер операции:  107433      #");
            Console.WriteLine("#      Идент. терминала:   00010916   #");
            Console.WriteLine("#     Идент.торговца: 009809596425    #");
            Console.WriteLine($"#  Дата и время: {dateTime.ToString("yyyy-MM-dd HH:mm:ss")}  #");
            Console.WriteLine("#    Карта:       860003******0246    #");
            Console.WriteLine("#      Тип:\t           UZCARD     #");
            Console.WriteLine("#\t\t   ISMOIL/MUHAMMADIEV #");
            Console.WriteLine("#\t\t\t\t      #");
            Console.WriteLine("#\t\tОплата\t\t      #");
            Console.WriteLine($"#\t     {sum} сум\t\t      #");
            Console.WriteLine("#\t\tОдобрено\t      #");
            Console.WriteLine("#######################################");
        }

        /// <summary>
        /// Пятая задача. Определить из зимнего периода дождливую зиму
        /// </summary>
        static void PrintInformationByWinterMonth()
        {
            Console.WriteLine("Определить из зимнего периода дождливую зиму");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            Console.Write("Введите Максимальную температуру: ");
            double maxTemperature = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Минимальную температуру: ");
            double minTemperature = Convert.ToDouble(Console.ReadLine());
            double middleTemperature = (maxTemperature + minTemperature) / 2;
            if (((month == Month.Январь.ToString() || month == "январь") || (month == Month.Февраль.ToString() || month == "февраль")
                || (month == Month.Декабрь.ToString() || month == "декабрь")) && middleTemperature > 0)
            {
                Console.WriteLine("Дождливая зима!!");
            }
            else
                Console.WriteLine("Другая погода !!");
        }

        /// <summary>
        /// Шестая задача. Создать расписание рабочих дней
        /// </summary>
        public static void StructureWorkingWeek()
        {
            string office1 = "Office 1";
            string office2 = "Office 2";
            Console.WriteLine("\t\t\t\t  Расписание рабочих дней");
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine();
            Console.WriteLine($"{Week.Понедельник}||\t  {Week.Вторник}|| \t{Week.Среда}||\t   {Week.Четверг}|| \t{Week.Пятница}|| \t{Week.Суббота}|| \t{Week.Воскресенье}||");
            Console.WriteLine("####################################################################################################");
            Console.WriteLine($"   {office2}||    {office2}||  {office2}||   {office2}||   {office2}||      {office2}||          {office2}||");
            Console.WriteLine($"           ||    {office1}||  {office1}||   {office1}||   {office1}||");
        }

        /// <summary>
        /// Выбор домашнего задачи
        /// </summary>
        public static void SelectMethodByHomeWork()
        {
            Console.WriteLine("Домашная задача!!!");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.Write("Выберите домашную задачи:");
            int numb = Convert.ToInt32(Console.ReadLine());
            switch (numb)
            {
                case 1:
                    MiddleTemperature();
                    break;
                case 2:
                    SelectByMonthToNumber();
                    break;
                case 3:
                    CheckingEven();
                    break;
                case 4:
                    DrawingCheck();
                    break;
                case 5:
                    PrintInformationByWinterMonth();
                    break;
                case 6:
                    StructureWorkingWeek();
                    break;
                case 0:
                    Console.WriteLine("Завершение метода Main");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("номер задачи в диапозоне 1-6");
                    break;
            }
        }
    }
}
