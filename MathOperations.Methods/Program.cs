using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Methods
{
    public class MathOperations
    {
        //Instance Method
        public int Add(int addParameter1, int addParameter2)
        {
            return addParameter1+ addParameter2;
        }

        //Static method
        public static double Divide(double dividend,double divisor)
        {
            if (divisor == 0)
                throw new Exception("can not divided by Zero");
            return dividend / divisor;
        }

        //Parameterized Method
        public void PrintResult(string operation,double result)
        {
            Console.WriteLine($"Result of {operation} : {result}");
        }

        // Return type method
        public double CalculateAreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        //Void Method
        public void DisplayMessage()
        {
            Console.WriteLine("This is a void Method");
        }

        //Overloaded methods
        public int Add(int addParameter1,int addParameter2,int addParameter3)
        {
            return addParameter1 + addParameter2 + addParameter3;
        }
        public double Add(double addParameter1,double addParameter2)
        {
            return addParameter1 + addParameter2;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations calculator=new MathOperations();

            int sum = calculator.Add(10, 24); // Instance method
            Console.WriteLine($"Sum : {sum}");

            double quotient = MathOperations.Divide(300, 5); //static method calling with class name
            Console.WriteLine($"Quotient : {quotient}");

            Console.WriteLine("area of circle:"+calculator.CalculateAreaOfCircle(6));

            calculator.DisplayMessage(); // Void Method

            int sumOfThree = calculator.Add(23, 45, 67);
            Console.WriteLine($"Sum of Three numbers: {sumOfThree}"); // OverLoaded Method

            double sumOfDoubles = calculator.Add(12.5, 12);  //OverLoaded Method
            Console.WriteLine($"Sum of Doubles: {sumOfDoubles}");
        }
    }
}
