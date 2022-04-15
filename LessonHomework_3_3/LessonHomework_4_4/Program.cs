using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_4_4
{
    class Fibonacci
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Введите число ряда Фибоначчи: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Fibonaththi(a)}");//Вводим число фибоначчи
            Console.ReadKey();
        }

        public static int Fibonaththi(int n)//Метод рекурсии числа фибоначчи
        {
            if (n == 0)
            {
                return 0;
            } 
            else if (n == 1)
            {
                return 1;
            }
            else { 

            return Fibonaththi(n - 1) + Fibonaththi(n - 2);

            }

        }
    }
}



