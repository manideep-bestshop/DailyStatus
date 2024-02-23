using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    internal class Program
    {
        public bool compare(int a,int b)
        {
            if(a==b)
            return true;
            return false;
        }
        public bool comp(object a,object b)
        {
            if(a.Equals(b))
                return true;
            return false;
        }
        public bool compare1<T>(T a,T b)
        {
            if(a.Equals(b)) return true;    
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            bool result=p.compare(2, 4);
            Console.WriteLine(result);

            bool res=p.comp(12.5f, 12.54);
            Console.WriteLine(res);

            bool res1=p.compare1<int>(2, 4);
            Console.WriteLine(res1);

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);    
            list.Add(6);

            for(int i=0;i<list.Count;i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            list.Remove(3);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();

            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
