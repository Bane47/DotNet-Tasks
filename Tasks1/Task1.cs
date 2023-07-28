using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks
{
    public class Class2
    {
        //     Get an input of 'Hello!!!' using StringBuilder and show the working of AppendLine,AppenLine,Remove,Insert and Replace(!with ?).
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
      //static void Main(string[] args)
      // {
      //      // Class1 obj1 = new Class1();
      //      //  Class2 obj2 = new Class2();
      //      //  FloDoubDeci Calc = new FloDoubDeci();
      //      Task2a task2Obj = new Task2a();
      //      task2Obj.arrayBuilder();
      //      task2Obj.oneDconvertor();
      //         task2Obj.jaggedArray();
      //       task2Obj.outParamCaller();
      //      task2Obj.paramArr();

      //  }
    }

    internal class Task2a
    {
      public  int[,] a;
        public int rows, columns;

       
   
        public  void arrayBuilder()
        {


            Console.WriteLine("Enter the number of rows");
             rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
             columns = Convert.ToInt32(Console.ReadLine());

            a = new int[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the elements of row number {i + 1}");
                for (int j = 0; j < columns; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }

                
            }

            Console.WriteLine("The elements of the 2 dimensional array are: ");

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(a[i,j]+"\t");


                }
                Console.WriteLine("\n");
            }


        }

        public void oneDconvertor()
        {
            int size= rows * columns;
            int[] convertedArray = new int [rows * columns] ;

            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    convertedArray[k] = a[i, j];
                    Console.Write(a[i, j] + "\t");
                    k++;
                }
            }



        }

        public void jaggedArray()
        {
            int[][] ja = new int[3][]
            {
                new int[5]{1,2,3,4,5 },
                new int[4]{5,6,3,2},
                new int[7]{10,20,30,60,50,40,70 }
            };

            for(int row = 0; row < 3; row++)
            {
                for( int col = 0; col < ja[row].Length;col++)
                {
                    Console.Write(ja[row][col] +"\t");
                }
            }
        }

        public void paramArr()
        {
           
            object[] paramObj = new object[] {"Darshan",21,8300287044,"Coimbatore" } ;

            int i = 0;
            int bin = 0;

            //   while (bin!=1)
            //       {
            //           Console.WriteLine("Enter the name: ");
            //          paramObj[i++] = Console.ReadLine();
            //          Console.WriteLine("Enter the age: ");
            //          paramObj[i++] = Console.ReadLine(); 
            //         Console.WriteLine("Enter the mobile: ");
            //           paramObj[i++] = Console.ReadLine();
            //           Console.WriteLine("Enter the address: ");
            //           paramObj[i++] = Console.ReadLine();

            //            Console.WriteLine("Press any button to continue or press 1 to stop");
            //           bin=Convert.ToInt32(Console.ReadLine());
            //       }

            Console.WriteLine("Enter the name: ");
            


            displayParam(paramObj);

        }


        public void displayParam(params object[] arr)
        {
            Console.WriteLine("The Details:");
            for (int i = 0; i < arr.Length; i++)
            {
                //  Console.WriteLine($"The details of the person {i + 1}");
               
                Console.WriteLine(arr[i]);
            }
        }

        // 5. Get details of 5 employees(id, name, salary, bonus) and show the working of bonus calculation using out parameter.

        public void outParam(out int id,out string name,out decimal salary,out decimal bonusPercent)
        {

            for(int i = 0; i < 5; i++) { }
            Console.WriteLine("Enter the id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the bonus percentage: ");
            bonusPercent = Convert.ToDecimal(Console.ReadLine());

              
        }
        public void outParamCaller()
        {

            int id;
            string name;
            decimal salary, bonusPercent, bonus;


            outParam(out id,out name,out salary,out bonusPercent);
            bonus = salary / bonusPercent;
            Console.WriteLine($"The bonus for {name} is {bonus} Rs");
        }

    }





    

}
