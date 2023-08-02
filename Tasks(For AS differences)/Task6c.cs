using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double salary;

        public  void Details()
        {
            Console.WriteLine("Salary: "+salary);

        }

    }

    internal class HR : Employee
    {
        public double Bonus;

        public new void Details()
        {
            Console.WriteLine("Salary: "+salary+"Bonus: "+Bonus);
        }


    }
    internal class Employee2
    {
        public double Salary;
        public void Details2()
        {
            Console.WriteLine("Salary: "+Salary);
        }
    }
    internal class HR2 : Employee2
    {
        public double Bonus;

        public void Details2()
        {
            Console.WriteLine("Salary:"+Salary+" Bonus: "+Bonus);
        }
    }

    internal class main_class
    {
        static void Main(string[] args)
        {
            HR employee = new HR() { salary = 45000, Bonus = 3000 };
            Employee employee1 = employee;

            employee1.Details();

            employee.Details();

            HR2 emp = new HR2() { Salary = 50000, Bonus = 5420 };

            Employee2 emp2 = emp;

            emp2.Details2();
            emp.Details2();

            


        }
    }


}
