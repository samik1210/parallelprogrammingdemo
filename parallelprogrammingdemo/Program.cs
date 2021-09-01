using System;
using System.Threading.Tasks;

namespace parallelprogrammingdemo

{
    class CreatingTaskEx
    {
        static void HelloConsole()
        {
            Console.WriteLine("Hello Task");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Action action = delegate
           {
               Console.WriteLine("message from task1 ");
           };
            Task task1 = new Task(action);
            task1.Start();
            Console.WriteLine(task1.Status);
            Task task2 = new Task(delegate
            {
                HelloConsole();
            });
            task2.Start();
            Task task3 = new Task(() => HelloConsole());
            task3.Start();
            Console.ReadKey();
        }
    }
}
