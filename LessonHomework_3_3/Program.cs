using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world";
            string rev = "";
            for (int i = 1; i <= text.Length; i++)
            {
                rev += text[text.Length - i]; //Запуск строки в обратном порядке
            }
            Console.WriteLine(rev);

            Console.ReadKey();
        }
    }
}
