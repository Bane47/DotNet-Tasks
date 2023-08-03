using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Trainee
    {
        double CSharpScore, UIScore, AvgScore;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();

                if (name != )
                {
                    throw new my_exception();
                }

            }
        }
    }
    class my_exception : Exception
    {
        public my_exception()
        {

        }
        public my_exception(string message) : base(message){ }
    }




}
