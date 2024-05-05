namespace CheckDLL
{
    public interface ITest
    {
        void Print();
        void Move();
        string Hello(string name);

    }
    public class MyClass_1 : ITest
    {
        public int id { get; set; }
        public string name { get; set; }
        public MyClass_1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public MyClass_1()
        {}

        public void Move()
        {
            Console.WriteLine("I Am Moving");

        }

        public void Print()
        {
            Console.WriteLine("I Am Printing");
        }

        public string Hello(string name)
        {
            return "Hello " + name;
        }
    }
}