using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "file_txt;";
            string file = "startup.txt";
            string time = DateTime.Now.ToLongTimeString();//Текущее время
            File.WriteAllText(filename,"str");//Запись строки в файл
            File.AppendAllText(file, "time");
            Console.WriteLine($"{file}, {time}");//Вывод файла и текущего времени
            Console.ReadKey();
        } 
       
    }
}
