using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp160
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer1 = new StringBuilder();
            var buffer2 = new StringBuilder(10);
            var buffer3 = new StringBuilder("hello");


            Console.WriteLine($"buffer1=\"{buffer1}\"");
            Console.WriteLine($"buffer2=\"{buffer2}\"");
            Console.WriteLine($"buffer3=\"{buffer3}\"");

            Console.ReadLine();


        }
    }
}
