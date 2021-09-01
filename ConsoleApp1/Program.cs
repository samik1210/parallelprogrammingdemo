using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parallel.For(1, 10, i =>
                {
                Console.WriteLine(i);

            });
            Console.ReadKey();
        }
    }
}
