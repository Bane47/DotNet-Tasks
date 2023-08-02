#define BubbleSort
#define QuickSort

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal abstract class Calculator
    {
        public abstract void taxCalculator(float salary);

    }

    internal class low_sal : Calculator
    {
        public override void taxCalculator(float salary)
        {

            float income = salary * 50 / 100;
            Console.WriteLine("The tax=" + income);

        }

    }
    internal class med_sal : Calculator
    {
        public override void taxCalculator(float salary)
        {
            float income = salary * 25 / 100;
            Console.WriteLine("The tax=" + income);
        }
    }
    internal class high_sal : Calculator
    {
        public override void taxCalculator(float salary)
        {
            float income = salary * 15 / 100;
            Console.WriteLine("The tax=" + income);
        }
    }

    internal class Main_method
    {
        static void Main(string[] args)
        {

            //2nd task 
            preprocs sorts = new preprocs();
            sorts.my_meth();
            low_sal low = new low_sal();
            med_sal med = new med_sal();
            high_sal high = new high_sal();

            Console.WriteLine("Enter your salary:");

            float actual_sal = float.Parse(Console.ReadLine());

            if (actual_sal <= 25000)
            {
                low.taxCalculator(actual_sal);
            }
            else if (actual_sal <= 50000)
            {
                med.taxCalculator(actual_sal);
            }
            else high.taxCalculator(actual_sal);





            // 3rd task 
            sorts.preprocs_two();

            //5th task 

        }
    }

    internal class preprocs
    {
        #region sorts
        public void my_meth()
        {
            Console.WriteLine("Please enter the number of elements to sort: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[length];
            int temp;
            Console.WriteLine("Please enter the numbers of the array : ");



#if (BubbleSort)
            for (int i = 0; i < length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());


            }

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            Console.WriteLine("The sorted array elements are: ");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine("\t");
#elif(QuickSort)
       
            Console.WriteLine("Enter the numbers for the quick sort: ");

            for (int i = 0; i < length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
                          
                
            }
            for(int i = 0; i < length; i++)
            {
                int pivot = length-1 ;

                if (arr[i] > arr[pivot])
                    {
                    Console.WriteLine("Hello");
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[pivot];
                    arr[pivot] = temp;

                    }
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }       
#endif

        }

        #endregion

        public void preprocs_two()
        {
            Console.WriteLine("#error");


            Console.WriteLine("#Warning message");
#if (!myError)
#warning myError is undefined
#endif

            Console.WriteLine("#line message");
#line 142 "Generics.cs"
#warning This is a fake error

            Console.WriteLine("#Pragma preprocessor, With the help of pragma we can disable and enable the warnings");

#pragma warning disable
#warning this warning will not be displayed
#pragma warning restore
#warning this warning will be displayed because it is enabled using pragma

            Console.WriteLine("Apart from this i have used #if, #elis and #endif in the above methods");
        }

    }


    //4th task
    internal sealed class myCalculator
    {
        internal int add(int a, int b)
        {
            return a + b;
        }
    }

    //public class myCalc : myCalculator
    //{
    //    myCalculator myCal = new myCalculator();
    //    myCal.add(4,6);
    //}

    //Console.WriteLine("Sealed cannot be inherited");

#warning Sealed class cannot be inherited

}
