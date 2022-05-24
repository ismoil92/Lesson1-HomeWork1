using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork3
{
    internal class SeaBattle
    {
        const int size = 10;

        static char[,] fields = new char[size, size];


        /// <summary>
        /// Метод для создание поля для морского боя
        /// </summary>
        static void CreateArraySymbols()
        {
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    fields[i, j] = 'O';
                }
            }
        }

        /// <summary>
        /// Метод для создание кораблей в поле
        /// </summary>
        static void CreateFields()
        {
            int currentDecksNumber = 4;
            int typeShipNumber = 4;
            Random random = new Random();
            for (int shipNumber = 1; shipNumber <= typeShipNumber; shipNumber++)
            {
                for (int i = 0; i < shipNumber; i++)
                {
                    int x, y, axis, direction;
                    bool check = true;
                    do
                    {
                        x = random.Next(0, size);
                        y = random.Next(0, size);
                        axis = random.Next(0, 2);
                        direction = random.Next(0, 2) == 1 ? 1 : -1;
                        int dirtx = x;
                        int dirty = y;
                        for (int j = 0; j < currentDecksNumber; j++)
                        {
                            check = CheckCell(dirtx, dirty);
                            if (!check)
                            {
                                break;
                            }
                            if (axis == 0)
                            {
                                dirtx += direction;
                            }
                            else
                            {
                                dirty += direction;
                            }
                        }
                    } while (!check);
                    for (int j = 0; j < currentDecksNumber; j++)
                    {
                        fields[x, y] = 'X';
                        if (axis == 0)
                        {
                            x += direction;
                        }
                        else
                        {
                            y += direction;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Проверка клетки игрового поля
        /// </summary>
        /// <param name="x">координаты х</param>
        /// <param name="y"> координаты у</param>
        /// <returns> возвращает  true если клетки и соседные клетки пустой</returns>
        static bool CheckCell(int x, int y)
        {
            if (x < 0 || x >= size || y < 0 || y >= size || fields[x, y] == 'X')
            {
                return false;
            }
            (int, int)[] discreptions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (1, 1), (1, -1), (-1, 0), (-1, 1), (-1, -1) };
            foreach (var disreption in discreptions)
            {
                int divx = x + disreption.Item1;
                int divy = y + disreption.Item2;
                if (divx < 0 || divx >= size || divy < 0 || divy >= size)
                {
                    continue;
                }

                if (fields[x, y] == 'X')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод для Вывода на консоль игру
        /// </summary>
        public static void PrintSeaBattle()
        {
            CreateArraySymbols();
            CreateFields();
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    Console.Write(fields[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
