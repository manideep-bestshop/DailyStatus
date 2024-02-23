using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingsEx
{
    internal class Program
    {
        public void divide()
        {
            try
            {
                Console.WriteLine("Enter A value");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter B value");
                int b = int.Parse(Console.ReadLine());

                int c = a / b;
                Console.WriteLine("Quote is.." + c);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed...");
            }

        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            ///p.show();

            try
            {
                Console.WriteLine("Enter A value");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter B value");
                int b = int.Parse(Console.ReadLine());
                if(b==0)
                    throw new DivideByZeroException();
                int c = a / b;
                Console.WriteLine("Quote is.." + c);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed...");
            }

        }
    }
}
