namespace MyTask
{
    internal class Program
    {
        static void Test1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(100);
            }
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int result = 0;
            var task1 = new Task(() =>
            {
                result = Sum(10,20);
            });
            task1.Start();
            task1.Wait();
            Console.WriteLine(result);
            //Task.Run(() =>
            //{
            //    Test1();
            //    Test1();
            //});

            //var task1 = new Task(() =>
            //{
            //    Test1();
            //});
            //task1.Start();

            //Task[] arTasks = new Task[5]
            //{
            //    new Task(() => Test1()),
            //    new Task(() => Test1()),
            //    new Task(() => Test1()),
            //    new Task(() => Test1()),
            //    new Task(() => Test1())
            //};

            //foreach (var task in arTasks)
            //{
            //    task.Start();
            //}

            //Task.WaitAll(arTasks);

            //Console.ReadLine();
            //Test1();
        }
    }
}