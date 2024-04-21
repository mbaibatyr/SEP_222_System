using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_222_System
{
    internal class Program
    {
        static void KillProcesses()
        {
            string[] processes = { "chrome" };
            foreach (var item in processes)
            {
                var p = Process.GetProcessesByName(item);
                if (p.Count() > 0)
                {
                    foreach (var item2 in p)
                    {
                        try
                        {
                            item2.Kill();
                        }
                        catch
                        { }
                    }

                }
            }

            //foreach (var item in Process.GetProcesses())
            //{
            //    Console.WriteLine($"{item.ProcessName}  {item.Id}  {item.BasePriority}");
            //}
        }

        static void StartProcesses(string[] array)
        {
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            //startInfo.UseShellExecute = false;
            //startInfo.FileName = @"C:\Users\байбатыровм.STEP\source\repos\SEP_222_System\SEP_222_System\bin\Debug\SEP_222_System.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Normal;            
            foreach (var item in array)
            {
                Process.Start(item);
            }
            
            //p.WaitForExit();
        }

        static int StartProcesses2(string process, int arg1)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = process;
            startInfo.Arguments = arg1.ToString();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;            
            var p = Process.Start(startInfo);
            p.PriorityClass = ProcessPriorityClass.Idle;
            p.WaitForExit();
            return p.Id;
        }
        static void Main(string[] args)
        {
            //KillProcesses();
            //StartProcesses(new string[] { "chrome", @"C:\Program Files\Microsoft VS Code\Code.exe" });
            //StartProcesses("chrome", "notepad");
            Console.WriteLine(StartProcesses2(@"C:\Users\байбатыровм.STEP\source\repos\SEP_222_System\SecondProcess\bin\Debug\SecondProcess.exe", 
                10));


        }
    }
}
