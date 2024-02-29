//using System;

namespace BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Number");
            int myIntegerNumber = int.Parse(Console.ReadLine());
            
            object myObjectValue = myIntegerNumber;   //Boxing Value type to reference type  // 
            Console.WriteLine($"{myIntegerNumber} {myObjectValue}"); //string interpolation


            int myIntegerNumberConvertedFromObject = (int)myObjectValue;  //UnBoxing refernce type to value type

            Console.WriteLine(string.Format("My Integer Value Converted From Object {0} ",myIntegerNumberConvertedFromObject));
            Console.ReadLine();

        }
    }
}
