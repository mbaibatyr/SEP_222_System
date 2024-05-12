namespace MyThread
{
    internal class Program
    {
        static object MyLock = new();
        //static Mutex mutexObj = new();
        static void Test1(object p)
        {
            bool acquiredLock = false;
            //mutexObj.WaitOne();
            //lock (MyLock)
            try
            {
                Monitor.Enter(MyLock, ref acquiredLock);
                Monitor.Wait(MyLock, 200);                
                for (int i = 1; i <= int.Parse(p.ToString()); i++)
                {
                    Console.WriteLine(i.ToString() + " " + Thread.CurrentThread.Name);
                    Thread.Sleep(100);
                }
            }
            catch 
            {

                throw;
            }
            finally
            {
                if (acquiredLock) Monitor.Exit(MyLock);
            }
            //mutexObj.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                //Thread MyTread = new Thread(Test1);
                Thread MyTread = new Thread(new ParameterizedThreadStart(Test1));
                MyTread.Priority = ThreadPriority.Highest;
                MyTread.Name = $" Поток номер: {i}";
                MyTread.Start(5);
                //Test1();
            }
            //Console.ReadLine();
            //Test1();
            //Test1();            
        }
    }
}