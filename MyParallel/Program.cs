namespace MyParallel
{
    internal class Program
    {
        static void Test(int k)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}, ThreadId = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(200);
            }
        }
        static void Main(string[] args)
        {
            //Parallel.For(1, 5, Test);            
            //Parallel.For(1, 5, k =>
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine($"i = {i}, ThreadId = {Thread.CurrentThread.ManagedThreadId}");
            //        Thread.Sleep(200);
            //    }
            //});

            Parallel.ForEach<int>(new List<int> { 1, 10 }, Test);
        }
    }
}