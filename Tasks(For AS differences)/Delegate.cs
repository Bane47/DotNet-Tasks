using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    /// <summary>
    /// Delegate - reference type - holds the ref of a method -  runtime
    /// </summary>
    /// 

    public delegate void Delegates_meth(int id, string name);
    internal class Delegates
    {
        public void TraineeDetails(int tid, string tname)
        {
            Console.WriteLine($"{tname}'s id is {tid}");
        }
        public void PromotionDetails(int tid, string tname)
        {
            Console.WriteLine($"{tname}-{tid} is moved to the moon");
        }
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            Delegates classInstance = new Delegates();
            
            classInstance.TraineeDetails(100, "Pinkman");

            Delegates_meth delegateInstance = classInstance.TraineeDetails;


            delegateInstance += classInstance.PromotionDetails;
            delegateInstance(100, "Hello World");
        //    delegateInstance += classInstance.PromotionDetails;
            delegateInstance(200, "Walter white");

            classInstance.add(100, 200);


            List<int> num = new List<int>();

            num.Add(34);
            num.Add(50);


            num.ForEach( delegate (int num)
            {
                Console.WriteLine(num);
            });

            Exampe();
        }


        public delegate bool isPromote(Employee emp); // promote(employee)

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int salary { get; set; }
            public float Experience { get; set; }

            public static void PromoteEmp(List<Employee> EmployeeList, isPromote isEligible)
            {
                foreach(Employee emp in EmployeeList)
                {
                    if (isEligible(emp))
                    {
                        Console.WriteLine(emp.Name + " Promoted");
                    }
                    else
                        Console.WriteLine(emp.Name + " is not promoted");
                }
            }

           
        }
        public static bool promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
                return false;
        }
        public static void Exampe()
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee() { ID = 100,Name = "Satis" , salary=4000,Experience=3 });
            emp.Add(new Employee() { ID = 101, Name = "Sharon", salary = 45000, Experience = 7 });
            isPromote pro = new isPromote(promote);
            Employee.PromoteEmp(emp,pro);

        }

       
    }

}
