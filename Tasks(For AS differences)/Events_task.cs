using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    #region event props class
     class EventClass : EventArgs
    {
        public string name { get; set; }
        public int age { get; set; }
        public int id { get; set; }
        public int salary { get; set; }  
        public int bonus { get; set; }
        public string email { get; set; }
    }
    #endregion


     class Events_task
    {
       public event EventHandler<EventClass> EmployeeBonus;
        int count = 0;

        public void Create(string name,int age, int salary, string email)
        {
             
            if(EmployeeBonus != null)
            {
                Console.WriteLine("Employee bonus");
                EmployeeBonus(this, new EventClass { name = name, age = age ,salary = salary,bonus = salary+1000 , email = email});
            }
        }
    }

    class Salary
    {
        public static void payment(object salary, EventClass e)
        {
            try { 
            string reg_ex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Console.WriteLine(e.name);
            Console.WriteLine(e.salary);
            Console.WriteLine(e.age);
            Console.WriteLine(e.bonus);

            if (Regex.IsMatch(e.email, reg_ex))
            {
                Console.WriteLine(e.email);
               
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    class ProgramEvent
    {
        static void Main(string[] args)
        {
            var obj = new Events_task();
            obj.EmployeeBonus += Salary.payment;
            int id,age, salary;
            string name;
            string email;
            Console.WriteLine("Enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Email:");
            email= Console.ReadLine();
            Console.WriteLine("Enter the salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            obj.Create(name, age, salary, email);

        }
    }

    
}
