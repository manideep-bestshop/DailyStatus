using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefShallowDeepCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reference copy
            int[] arr1 = new int[4] { 1, 2, 3, 4 };

            int[] arr2 = arr1;   // arr1 and arr2 are in same memory loaction 
            arr2[3] = 22;       // if any changes made in arr2 will reflect in arr1

            Console.WriteLine("First Array..");
            foreach(int i in arr1)
             Console.Write(i+" ");
            Console.WriteLine();

            Console.WriteLine("Second Array..");  
            foreach (int i in arr2)               
              Console.Write(i+" ");
            Console.WriteLine();

            //shallow copy
            int[] arr3 = new int[4] { 1, 2, 3, 4 };

            int[] arr4 = (int[])arr3.Clone();   // arr3 and arr4 are in different memory loaction 
            arr4[3] = 22;                      // if any changes made in arr3 will not reflect in arr4

            Console.WriteLine("First Array..");
            foreach (int i in arr3)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Second Array..");
            foreach (int i in arr4)
                Console.Write(i + " ");
            Console.WriteLine();

            //Deep copy
            int[] arr5 = new int[4] { 1, 2, 3, 4 };
            int[] arr6 = new int[arr5.Length];

            arr5.CopyTo(arr6, 0);      //we can copy from particular index position using deep copy
            arr6[2] = 55;

            Console.WriteLine("First Array..");
            foreach (int i in arr5)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Second Array..");
            foreach (int i in arr6)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
