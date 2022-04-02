using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_4_2
{
    class Program
    {
        static int Sum(int[] numbArray)
        {
            int result = numbArray.Sum();

            return result;
        }


        static void Main(string[] args)
        {

            Console.Write("Введите кол-во элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] numbArray = new int[elementsCount];

            for (int i = 0; i < numbArray.Length; i++)
            {
             Console.Write($"\nВведите элемент массива {i}:\t ");

             numbArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Вывод элементов массива:");

            for (int i = 0; i < numbArray.Length; i++)
            {
                               
                Console.Write(" ");

                Console.Write(numbArray[i]);
            
            }

            int c = numbArray.Sum();

            Console.Write(c);


                Console.ReadKey();
        }

    }
}