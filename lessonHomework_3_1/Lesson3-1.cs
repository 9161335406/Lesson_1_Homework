﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonHomework_3_1
{
    class Lesson3
    {
        static void Main(string[] args)
        {
         int[,] a = new int[10, 10]
         for (int i = 0; i < 10; i++)
         for (int j = 0; j < 10; j++)
         a[i, j] = (i + j) % 10 + 1;
         for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
    
