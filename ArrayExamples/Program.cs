using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            
           //method1 using idex method
           for(int ind=0; ind<arr.Length; ind++)
            {
                Console.Write(arr[ind]+" ");  
            }
            Console.WriteLine();
            Console.WriteLine("------------");

            //method2 using foreach loop

            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();

            int[] arr1 = new int[3]; //here size i must
            arr1[0] = 4;
            arr1[1] = 2;
            arr1[2] = 3;
          //  Array.Sort(arr1);
            Array.Reverse(arr1);    
            foreach (int x in arr1) 
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();

            int[] arr2 = new int[] { 1, 2, 3, 4 };  //size is optional

            foreach (int x in arr2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.WriteLine("enter array size");
            int s=int.Parse(Console.ReadLine());
            int[] arr3 = new int[s];

            for(int ind=0;ind<arr3.Length ; ind++)
            {
                arr3[ind]=int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach(int x in arr3)
            {
                sum += x;
            }
            Console.WriteLine("Sum of the array.."+sum);
        }
    }
}
