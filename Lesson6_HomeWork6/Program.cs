using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager();
            Console.ReadKey();
        }

        static void TaskManager()
        {
            Console.WriteLine("Домашная работа номер 6. Вывести все процессы и завершить по процессы по ID");
            Console.WriteLine("============================================================================");
            Console.WriteLine();
            Process[] processes = Process.GetProcesses();
            int id1 = 0, id2 = 0;
            for(int i=0;i<processes.Length;i++)
            {
                Console.WriteLine(processes[i]);
                if(processes[i].ProcessName=="firefox")
                {
                    id1=processes[i].Id;
                }
                if(processes[i].ProcessName=="uTorrent")
                {
                    id2 = processes[i].Id;
                }
            }
            Process firefox = Process.GetProcessById(id1);
            Process torrent = Process.GetProcessById(id2);
            firefox.Kill();
            torrent.Kill();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Задачи {firefox.ProcessName} и {torrent.ProcessName} Завершено");
        }
    }
}
