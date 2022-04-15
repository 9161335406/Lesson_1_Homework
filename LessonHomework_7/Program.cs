using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_7
{
    class Program
    {   //Исходный код.
        static void Main(string[] args)
        {
            string secret = "some secret password";
            Console.WriteLine("Введите пароль:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
   
            Console.ReadKey(true);
        }
  
        
        
        //Код с изменениями условий.
        private static void Main(string[] args)
        { 
           string str = "some secret password";
           Console.WriteLine("Введите пароль:");
           if (!(Console.ReadLine() == str))
           Console.WriteLine("Welcome!");
           Console.ReadKey(true);
        }
    
    }    
}
     //Код с изменениями условий.     
    

