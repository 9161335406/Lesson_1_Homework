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
            string time = DateTime.Now.ToLongTimeString();//Текущее время
            File.WriteAllText(filename,"str");
            File.AppendAllText(filename, "time");
            Console.WriteLine($"{filename}, {time}");
            Console.ReadKey();
        } 
       
    }
}
