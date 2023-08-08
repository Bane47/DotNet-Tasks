using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Pointers
    {

        public unsafe void matrixAddition()
        {

            int[] arr1 = new int[3] {1,2,3 };
            int[] arr2 = new int[3] {4,5,6 };



        }



        static unsafe void Main(string[] args)
        {

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[3] { 4, 5, 6 };
            int[] ptrArr = new int[3];

            fixed (int* ptr = arr1)
            {
                for(int i = 0; i < arr1.Length; i++) {
                    ptrArr[i] = arr1[i];
                    Console.Write((ptrArr[i])+"\t");
                }
            }

            fixed(int* ptr2 = arr2)
            {
                for(int i = 0; i<arr2.Length; i++)
                {
                    Console.Write(*(ptr2 + i)+"\t");
                }
            }

            


      

        }
    }
}
