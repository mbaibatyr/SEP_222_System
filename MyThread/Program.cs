namespace MyThread
{
    internal class Program
    {
        static void Test1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i.ToString() + " " + Thread.CurrentThread.Name);                
                Thread.Sleep(200);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread MyTread = new Thread(Test1);
                MyTread.Priority = ThreadPriority.Highest;
                MyTread.Name = $" Поток номер: {i}";
                MyTread.Start();
                //Test1();
            }
            //Test1();
            //Test1();            
        }
    }
}