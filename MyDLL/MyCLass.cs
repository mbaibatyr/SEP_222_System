namespace MyDLL
{
    public class MyCLass
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public string Hello(string name) => "Hello " + name;

        public string Concat(string a, string b) => a + " " + b;
    }
}