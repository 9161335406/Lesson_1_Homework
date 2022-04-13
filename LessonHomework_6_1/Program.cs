using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHomework_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process processes = new Process();
            Process[] processes = Process.GetProcessesByName("taskmgr");
            
            Console.WriteLine(processes);
            //Process[] processes = Process.GetProcesses();
            //for (int i = 0; i < processes.Length; i++)
            //{
            //    Process process1 = processes[i];
            //    Console.WriteLine($"ID: {process1.Id}  Name: {process1.ProcessName}");
            //}
            //Process[] processes = Process.GetProcessesById("taskmgr");

            Console.ReadKey(true);

        }
    }

    internal class tasklist
    {
        Process processes = new Process();
        Process[] processes = Process.GetProcessesByName("taskmgr");

    }
}
 









//Process.StartInfo.FileName ={ @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\System Tools\taskmgr" };
           