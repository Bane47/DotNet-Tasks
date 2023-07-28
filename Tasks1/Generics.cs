using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks1
{
    internal class MyGeneric<T>
    {
      
        public void sorting(T[] a)
        {

            Array.Sort(a);
            Array.Reverse(a);

            foreach (T t in a)
            {
                Console.WriteLine("The reversed array elements are: ");
                Console.Write(t + "\t");
            }
        }

        public void swapper(T a,T b,T c)
        {
            Console.WriteLine($"Before swap first element is {a} and the second element is {b}");
            c = a; a=b; b=c;
            Console.WriteLine($"After swap first element is {a} and the second element is {b}");
        }

        public void firsta(T a,T b,T c) 
        {

        }


    }
  
    internal class second
    {
        public void secondTask()
        {
            int? nul = null;
            ArrayList list = new ArrayList();
            list.Add("Satis");
            list.Add(6);
            list.Add(nul);

            foreach (var i in list)
            {
                if (i != null)
                {
                    Console.WriteLine(i);
                }
                else Console.WriteLine("There's a null value");
            }

        }

    }

    internal class third
    {
        public string name { get; set; }
        public int age { get; set; }
        public string location { get; set; }

      

        public void thirdTask(third a)
        {
            a.name = name;
            a.age = age;
            a.location=location;
        }


    }
  

    internal class Main_class
    {
        static void Main(string[] args)
      {
           


            Console.WriteLine("Enter the number of rows of the array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int[] intArr = new int[rows] ;
            char[] stringArr = new char[rows];
            MyGeneric<int> obj1 = new MyGeneric<int>();
            MyGeneric<char> obj2 = new MyGeneric<char>();
            second sec = new second();

            Console.WriteLine("Press a for integer array or b for string array");
            

            string type = Console.ReadLine();


            if (type == "a")
            {
                Console.WriteLine("Enter the elements");

                for (int i = 0; i < rows; i++)
                {
                    intArr[i] = Convert.ToInt32(Console.ReadLine());

                }
                obj1.sorting(intArr);
               


            }
        else
            {
               Console.WriteLine("Enter the elements");
      for (int i = 0; i < rows; i++)
               {
                  stringArr[i] = char.Parse(Console.ReadLine());

               }
              obj2.sorting(stringArr);
         }

           Console.WriteLine("Swapping");
           Console.WriteLine("Press 0 for swapping an integer or 1 for swapping character values");
            int swap = Convert.ToInt32(Console.ReadLine());

            if(swap==0) {
              Console.WriteLine("Enter the first number: ");
               int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
               int b = Convert.ToInt32(Console.ReadLine());
               int c=0;
                obj1.swapper(a, b, c);
                
            }
            else
            {
                
             Console.WriteLine("Enter the first letter: ");
              char a = char.Parse(Console.ReadLine());
               Console.WriteLine("Enter the second letter: ");
                char b = char.Parse(Console.ReadLine());
                char c = ' ';
                obj2.swapper(a, b, c);
            }

            MyGeneric<int> obj3 = new MyGeneric<int>();
            MyGeneric<char> obj4 = new MyGeneric<char>();
            MyGeneric<string> obj5 = new MyGeneric<string>();


            sec.secondTask();

            Console.WriteLine("Third task");

            third thir = new third();
            Console.WriteLine("Enter the name of the trainee: ");
            thir.name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            thir.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the location: ");
            thir.location = Console.ReadLine();

            Console.WriteLine("Name : " + thir.name);
            Console.WriteLine("Age :" + thir.name);
            Console.WriteLine("Location : " + thir.name);

            Console.ReadLine();
       }
    }


   


}


