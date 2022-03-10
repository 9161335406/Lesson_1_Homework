using System;

namespace lessonHomework_3_1
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            int[,] matrixfor = new int[5, 5];
            matrixfor[2, 2] = 1;
            for (int i = 0; i < matrixfor.GetLenght(0); i++)
            {
            for (int j = 0; j < matrixfor.GetLenght(1); j++)

                    Console.Write($"{matrixfor[i, j]} ");

            }

        }
    }

}


