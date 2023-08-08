using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class csv
    {

        static void Main(string[] args)
        {
          int salary,bonus;

        Console.WriteLine("Enter the employee salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(salary);

            if (salary >= 20000 && salary <=29000)
            {
                 bonus = salary + 1000;
            }
            else if (salary >= 30000 && salary <=39000)
            {
                 bonus = salary + 2000;
            }
            else if (salary >= 40000)
            {
                 bonus = salary + 3000;
            }
            else
            {
                 bonus = salary + 500;
            }
            Console.WriteLine("The total salary is: "+bonus);
            
        }


        public void csv_adder()
        {
            StringBuilder sb = new StringBuilder();

            csv ob = new csv();
            
        }
    }
}
