using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_4_3
{
    class Seasons
    {
        enum season { Winter, Spring, Summer, Autumn };
        static season OfMonth(int n)
        {
                if (n <= 0 || n > 12)

                Console.WriteLine("Ошибка: введите число от 1 до 12");

                switch (n % 12 / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }     
        }
        static void Main(string[]vs)
        {
            do
            {
                Console.WriteLine("Введите номер месяца: ");
                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            }
            while (true);
        }

    }
}
    


              








        










        
  

   
    
   

        




   
            
    
 
      


    





       
    

        
        
        
    









