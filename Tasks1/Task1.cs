using System;
using System.Collections.Generic;
using System.Linq;
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
        private object console;

        public Class1()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Please enter the number of members");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter the name of member {i + 1}");
                sb.Append(Console.ReadLine());
            }
            Console.WriteLine("The name list: ");
            Console.WriteLine(sb.ToString());
        }



    }

    public class FloDoubDeci
    {
        public FloDoubDeci()
        {
            Console.WriteLine("Lets know the differnece between float, double and decimal");

            Console.WriteLine("Lets do that with a small calculation");

            Console.WriteLine("Enter The Numbers to be divided for float");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Numbers to be divided for double");

            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Numbers to be divided for decimal");

            decimal num5 = Convert.ToDecimal(Console.ReadLine());
            decimal num6 = Convert.ToDecimal(Console.ReadLine());



            Console.WriteLine("The division of both the numbers is: ");
            Console.WriteLine(num1 / num2+" This shows that float value data type takes 4 bytes");
            Console.WriteLine(num3 / num4 + " This shows that double value data type takes 8 bytes");
            Console.WriteLine(num5 / num6 + " This shows that decimal value data type takes 16 bytes");


        }
    }

    public class Class3
    {
        static void Main(string[] args)
        {
            // Class1 obj1 = new Class1();
            //  Class2 obj2 = new Class2();
            FloDoubDeci Calc = new FloDoubDeci();

        }
    }



}
