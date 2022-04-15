using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igoryan.Utils
{
    public static class Utils
    {
        public static void PrintInfo(int homeworkNumber, string fio)
        {
            Console.WriteLine($"Домашняя работа. Урок {homeworkNumber}");
            Console.WriteLine($"Студент {fio}");
            Console.WriteLine("====================================");
        }
    }
}

