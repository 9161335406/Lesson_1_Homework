using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            Console.WriteLine("Пуременная a = " + a +  "\nПеременная b = " + b);
            Console.ReadKey();
            a = a + b;//12
            b = a - b;//10
            a = a - b;//2
            Console.WriteLine("Пуременная a = " + a + "\nПеременная b = " + b);
            Console.ReadKey();
            string rev = "";
            for (int i = 1; i <= text.Length; i++)
            {
                rev = rev + text[text.Length - i];
            }
            Console.WriteLine(rev);

            Console.ReadKey();
        }
    }
}
