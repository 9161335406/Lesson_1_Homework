using Igoryan.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_8
{
    internal class Sample01
    {
        static void Main(string[] args)
        {
            Console.Title = Properties.Settings.Default.ApplicationName;

            Utils.PrintInfo(8, "Разумных Игорь Александрович");

            Console.WriteLine(Properties.Settings.Default.Usersettings1);
            Console.WriteLine(Properties.Settings.Default.Usersettings2);

            Properties.Settings.Default.Usersettings1 = "Hello student";
            Properties.Settings.Default.Usersettings2 = 1000;
            Properties.Settings.Default.Save();

            Console.WriteLine(Properties.Settings.Default.Usersettings1);
            Console.WriteLine(Properties.Settings.Default.Usersettings2);

            Console.ReadKey(true);

        }
    }
}



