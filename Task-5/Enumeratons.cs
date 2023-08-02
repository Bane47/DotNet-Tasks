using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Enumeratons
    {
        public enum shapes
        {
            circle,
            rectangle,
            square
        }

        public static void enum_method(double a, shapes shape, params object[] b)
        {
            Console.Write("Area of ");
            if ((int)shape == 0)
            {
                Console.WriteLine("Circle:" + 3.14 * a * a);
            }
            else if ((int)shape == 1)
            {
                foreach (int i in b) Console.WriteLine("Rectangle: " + a * i);
            }
            else if ((int)shape == 2)
            {
                Console.WriteLine("Square: " + a * a);
            }


        }
        public static void iterate(double a, params object[] b)
        {
            foreach (Enum shape in Enum.GetValues(typeof(shapes)))
            {
                if (shape.ToString() == "circle")
                {
                    Console.WriteLine("circle:" + 3.14 * a * a);
                }
                else if (shape.ToString() == "rectangle")
                {
                    foreach (int i in b)
                    {
                        Console.WriteLine("Rectangle" + a * i);
                    }
                }
                else if (shape.ToString() == "square")
                {

                    Console.WriteLine("Square: " + a * a);

                }
            }
        }
        public static void Main(string[] args)
        {
            enum_method(10.21,shapes.square);
            Console.ReadLine();
        }

    }
}
