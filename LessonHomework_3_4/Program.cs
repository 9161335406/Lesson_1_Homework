using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Sea_​​battle
    {
        static void Main(string[] args)
        {
            int[,] Pole = new int[11, 11];
            int rows = Pole.GetUpperBound(0);
            int columns = Pole.Length / rows;//поле боя

            for (int i = 0; i < rows; i++) ;
            {
                for (int j = 0; j < columns; j++) ;
                Console.Write($"{Pole[rows, columns]}");
            }
            Console.ReadKey();


        }
    }
}
