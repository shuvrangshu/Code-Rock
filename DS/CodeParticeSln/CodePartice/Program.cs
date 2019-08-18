using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePartice
{
    class Program
    {
        static void Main(string[] args)
        {

            Task.Factory.StartNew(methodOne);
            Task.Factory.StartNew(methodTwo);

            Console.WriteLine("Enter Name...");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name : " + name);
            Console.ReadLine();
        }

        static void methodOne()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("Download File 1.....");
        }

        static void methodTwo()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("Download File 1.....");
        }
    }
}
