using System;

namespace LessonHomework_3_2
{
    class Program
    {


        static void Main(string[] args)
        {
            string[,] contact = new string[5, 2]
           {
           {"Sem","phone/email"},
           {"Helly","phone/email"},
           {"Yulya","phone/email"},
           {"Curt","phone/email"},
           {"Tom","phone/email"}};


            for (int i = 0; i < contact.GetLength(0); i++)
            {
                for (int j = 0; j < contact.GetLength(1); j++) 
                {
                    Console.Write($"{contact[i, j]}\t");
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
        
             
    }
}
                              














