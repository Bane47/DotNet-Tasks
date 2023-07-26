using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Class2
    {
        //            Get an input of 'Hello!!!' using StringBuilder and show the working of AppendLine,AppenLine,Remove,Insert and Replace(!with ?).
        public Class2()
        {

            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Kindly type as follows: Hello!!!");
            Console.ReadLine();
            sb.AppendLine("Satis");
            sb.AppendLine("Hemanth");
            sb.AppendLine("Sharon");
            sb.Append("Arun");
            sb.Append("Siva");
            sb.Remove(3, 1);
            sb.Insert(4, "Darshan");
            sb.Replace("Darshan", "Vignesh");

            Console.WriteLine(sb.ToString());
        }
        

    }
    internal class Class1
    {
        public Class1()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Please enter the number of members");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter the name of member {i+1}");
                sb.Append(Console.ReadLine());
            }

            Console.WriteLine(sb.ToString());
        }
        


    }

public class Class3
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
                        

        }
    }



}
