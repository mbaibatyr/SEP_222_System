using Dapper;
using System.Data.SqlClient;

namespace MyTask
{
    internal class Program
    {
        static void Test1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i.ToString());
                //Thread.Sleep(100);
            }
        }

        static void Test2()
        {
            Console.WriteLine("Hello STEP 1");
        }        

        static async Task Test2_CallAsync()
        {
            //Task.Delay(1000);
            await Task.Run(() =>
                Test2()
            );

            using (SqlConnection db = new SqlConnection())
            {
                db.Query<dynamic>("");
            }
            

        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        async static Task<int> Sum2(int a, int b)
        {
            return a + b;
        }
        static async Task Main(string[] args)
        {
            await Test2_CallAsync();


            //Console.WriteLine("Hello STEP 2");
            //Console.WriteLine(await Sum2(12, 13));
            //var task1 = new Task<int>(() =>            
            //    Sum(10,20)
            //);            
            //task1.Start();
            //task1.Wait();
            //Console.WriteLine(task1.Result);

            //Task.Run(() =>
            //{
            //    Test1();
            //    Test1();
            //    Test1();
            //});

            //var task1 = new Task(() =>
            //{
            //    Test1();
            //});
            //task1.Start();

            //Task[] arTasks = new Task[2]
            //{
            //    new Task(() => Test1()),
            //    //new Task(() => Test1()),
            //    //new Task(() => Test1()),
            //    //new Task(() => Test1()),
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