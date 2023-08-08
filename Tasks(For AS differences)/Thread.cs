using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Tasks_For_AS_differences_
{
    /// <summary>
    /// unstarted - Thread th = new Thread();
    /// Runnable - th.Start();
    /// Running - Sum(process)
    /// Not Runnable - th.Sleep(1000);
    /// Dead - th.Abort();
    /// </summary>
    internal class Thread_Task
    {
        internal static Thread CurrentThread;

        public static void CallToChildThread()
        {

            try
            {

                Console.WriteLine("Child thread starts");

                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child thread completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread abort exception");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Couldnt catch the thread exception");
            }
        }

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);

            Console.WriteLine("In main");

            Thread childThread = new Thread(childref);
            childThread.Start();

            Thread.Sleep(1000);

            Console.WriteLine("Aborting child");

            childThread.Abort();
            Console.ReadKey();


        }
    }
}
