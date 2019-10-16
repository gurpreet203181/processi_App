using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace processi_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe", @"C:\Users\studenti\Desktop\processi_App\processi_App\HelloWorld.txt");
           Process.Start("Chrome.exe", @"https://github.com/");
            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\studenti\Desktop\processi_App\processi_App\HelloWorld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            app.WaitForExit();

            var processes = Process.GetProcesses();
            foreach(var p in processes)
            {  
                if(p.ProcessName=="Notepad") p.Kill();
            }
            Console.WriteLine("Programma terminato");
            Console.ReadLine();
        }
    }
}
