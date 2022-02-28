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

            string name = Console.ReadLine();
            DateTime date = DateTime.Now;

            Console.WriteLine($"Hello, {name}. Today is {date.ToShortDateString()}");//6
            Console.ReadKey();
        }
    }
}
