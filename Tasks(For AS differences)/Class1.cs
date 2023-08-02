using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Task6B
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount: ");
            Double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double rate = 3.14;


            var simp_interest = (double amount, int years, double rate) =>
            {
                Console.WriteLine("The simple interest is: "+amount * years * rate / 100);
            };

            simp_interest(amount, years, rate);            
        }
           
       

        
    }
}
