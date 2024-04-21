using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Без аргументов не запускается");
                return;
            }
            var x = int.Parse(args[0]);          
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
