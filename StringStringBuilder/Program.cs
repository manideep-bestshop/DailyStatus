using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
             Stopwatch sw1 = Stopwatch.StartNew();
            sw1.Start();
            for(int i=0;i<100000;i++)
            {
                s =s+ i;
            }
            sw1.Stop();
            Console.WriteLine("string execution time:"+sw1.ElapsedMilliseconds); //o/p: 32043

            StringBuilder sb=new StringBuilder();
            Stopwatch sw2 = Stopwatch.StartNew();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("stringBuilder execution time:" + sw2.ElapsedMilliseconds);//o/p: 23   more faster than string

        }
    }
}
