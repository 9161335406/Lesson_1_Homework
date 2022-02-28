using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine(); //объявляем переменную и присваеваем ей значение, введенное с консоли
            DateTime date = DateTime.Now; //создаем переменную типа DateTime

            Console.WriteLine($"Hello, {name}. Today is {date.ToShortDateString()}");//вывод данных нужного формата
            Console.ReadKey();
        }
    }
}
