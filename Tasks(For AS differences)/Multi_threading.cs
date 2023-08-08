using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Multi_threading
    {

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(method2));
            thread.Start();
            for (int i = 0; i <= 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is first method");

                Console.WriteLine(i);

                Thread.Sleep(100);
            }
        }
        public  static void method2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("This is second method");
                Console.WriteLine(i);
                
                Thread.Sleep(100);
            }
        }
    }
}
