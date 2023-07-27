using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        public void arrayBuilder()
        {
           

            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[rows,columns] ;
        }
        static void Main(string[] args)
        {

        }
    }
}
