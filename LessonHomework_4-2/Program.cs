using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите кол-во элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine()); //Запрос значения от пользователя.

            int[] numbArray = new int[elementsCount];

            for (int i = 0; i < numbArray.Length; i++) //Цикл ввода элементов с клавиатуры.
            {
                Console.Write($"\nВведите элемент массива {i}:\t ");

                numbArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Вывод элементов массива:");

            for (int i = 0; i < numbArray.Length; i++) //Цикл вывода элементов.
            {
                Console.Write(" ");

                Console.Write(numbArray[i]);
            }
            Console.WriteLine();

            int Sum = 0;

            for (int i = 0; i < numbArray.Length; i++)
            {

                Sum += numbArray[i];

            }
            Console.WriteLine("Сумма элементов: ");

            Console.Write(Sum); //Вывод суммы значений.

            Console.ReadKey();
        }

    }
}
        
