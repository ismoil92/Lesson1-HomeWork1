using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiddleTemperature(23.4f, 30.9f);
            Console.ReadKey();
        }

        static void MiddleTemperature(float minTemperature, float maxTemperature)
        {
            float middleTemperature = (maxTemperature + minTemperature) / 2;
            Console.WriteLine($"Middle Temperature:{middleTemperature}");
        }

        static void EnterToMonthNumber(int number)
        {

        }
    }
}
