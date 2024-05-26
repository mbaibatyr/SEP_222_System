using T1 = System.Timers;
using T2 = System.Threading;

namespace MyTimer
{
    internal class Program
    {
        static int Counter = 0;
        static T1.Timer timer_1;
        static T2.Timer timer_2;       

        static void Main(string[] args)
        {
            //TimerCallback tc = new TimerCallback(Method2);
            //timer_2 = new T2.Timer(tc, 2, 5, 300);
            //Console.ReadLine();

            timer_1 = new T1.Timer();
            timer_1.Interval = 300;
            timer_1.Elapsed += Method1;            
            timer_1.Start();
            string st = "start";
            while (st == "start")
            {
                st = Console.ReadLine();
                if (st == "start")
                {
                    Counter = 0;
                    timer_1.Start();
                }
            }

        }

        static async void Method1(object sender, T1.ElapsedEventArgs e)
        {            
            Console.WriteLine("Hello STEP - " + Counter++);
            if(Counter > 10)
                timer_1.Stop();            
                //timer_1.Enabled = false;
                //timer_1.Elapsed -= Method1;
        }

        static void Method2(object sender)
        {
            Console.WriteLine("Hello STEP - " + Counter++);
            if (Counter > 10)                
                timer_2.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}