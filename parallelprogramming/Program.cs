using System;
using System.Threading.Tasks;

namespace parallelprogramming
{
    class ReturningData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Func<object, int> fun = delegate (object st)
            {
                Console.WriteLine("Parameter value: {0}", st);
                return 10;
            };
            Task<int> task1 = new Task<int>(fun, "Hello world");
            task1.Start();
            Console.WriteLine("task1 return value: {0}", task1.Result);
            Console.ReadKey();
        }
    }
}
