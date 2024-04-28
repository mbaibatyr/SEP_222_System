using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using MyDLL;


namespace MyConsole
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        static void Main(string[] args)
        {
            //Assembly assembly = Assembly.LoadFrom(@"C:\Temp\MyDLL.dll");
            //var result = assembly.GetTypes().Where(z=>z.Name == "MyCLass").FirstOrDefault();
            //object myLink = Activator.CreateInstance(result);
            //var Sum = result.GetMethod("Sum");
            //var resultSum = Sum.Invoke(myLink, new object[] { 3, 5 });
            //Console.WriteLine(resultSum);

            //MyCLass my = new MyCLass();
            //var resultSum2 = my.Sum(1, 2);

            StringBuilder sTitleBar = new StringBuilder(255);
            MessageBox(IntPtr.Zero, "Hello STEP!", "Название", 0);

        }
    }
}