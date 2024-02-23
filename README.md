c# Interview questions:
-----------------------
.NET framework
--------------
 helps you build web apps, desktop apps, and web services. It works only on the Windows operating system. 
.NET
----
. NET core is for creating cross-platform cloud apps that run on Windows, Mac, and Linux.
 
1.Explain Difference between .NET and C#?
A..Net is a framework and contains Libraries and Runtime
  C# is a Programming Language And it contains syntaxes,conditions,loops and more..
  by using both .net and c# we can develop the applications
  
2.what is MSIL(microsoft Intermediate Language)?
A. IL is partially converted code. when we compile the higher level it conveted into partially compiled code

3.What is JIT?
A.JIT(Just In Time) is runs over the IL code and compiled into Machine Language

4.Is it possible to view IL code?
A.Yes,it possible to see IL code using IL DASM(Dis Assembler)

5.What is the benefit of compiling into IL code?
A.The runtime enviroment and development enviroment can be very different.so depending on runtime enviroment
  JIT compiles the best optimized code as per enviroment. 
Ex. developer developed the app in windows10 then if we want run in win8 win7 or linux , using thst IL code
  JIT compiles best to that enviroment

6.does .NET framework supports multiple programming languages?
A.Yes,it supports multiple programming languages like c#,vb.net,f# etc
 but at end that code compiles into IL code. 

7.What is CLR?
A. 1.CLR converts te IL code into Native language(Machine Language)
   2.it cleans any unused code objects by using Garbage Collector(GC)

8.what is managed code and unmanaged code?
A.Manage Code: The code that executes under CLR enviroment 
  unmanaged code:The code that executes outside of CLR enviroment, this code has its own enviroment.
  Unmanged code nothing but c++,vc++,vb6 etc...
  
9.what is garbage collector?
A. Garbage Collector is a Back ground process which cleans unused managed resources.

10.Can garbage collector claim unmanaged code?
A.  No,garbage collector can not collects objects which runs outside the CLR.

11.what is CTS?
A. Common Type System(CTS) ensures that data types of two different langages gets compiled to a common data type

12.Explain CLS?
A. common language specification(CLS) are set of guide lines or rules. when any .net programming lanuage adheres to
  to these set of rules it can be consumed by any language of .NET framework

13.what is stack and heap?
A.stack and heap are memory types in an application.Stack memory stores data types like int,bool,double etc
  while heap stores the data tyeps like string and objects  
  
14.what are Value types and Reference types ?
A. Value types contain actual data and while reference types contain pointers and pointer points the actual data
  Value types are  are stored in stck while refernce stored in heap.
  values types like int,double,bool etc.. and refernce types are all objects..
  
15.what is boxing and unboxing?
A.when value type is moved to reference type is called Boxing.
  when reference type moved into value type is called Unboxing  
 
16.what is the consequance of boxing and unboxing?
A.performance issues, beacuse we are moving value to reference i.e stack to heap so performance issues will occure

17. 
Array
-----
1.array is a collection of elelments in a single varible with similar data type.
2.array variable in a c# is always of reference type
3.array variable sizeis fixed which means a runtime it cant be increased or decreased
4.in c# all array variables by default are objects to system.array class
5.in c# arrays can be implemented with follwing categories
 a)single one dimensional array
 b)multi dimensional array 
 c)Jagged array
 

  
Reference Shollow Deep Copy:
----------------------------

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
JaggedArray:
------------

1.It is called array of arrays
2.it supports to create array with rows and cols providing discrete coloumn leghth for each row.

Collections:
-----------
Limitations of array:
--------------------
1.size is fixed 
2.array always have collection of values with same data types

to over come these limitations microsoft introduced collections 

system.collections

               IEnumerable
			        |extends
				Icollections
			|extends          |	extends
		   IList           IDictionary	
		   |                   |
		 ArrayList          Hashable
        (always works     (always works with
		with Index          keywords)
		Position)		 
		
ArrayList:
----------
1.the collection class will support to have collection of same datatype and different data types,access through index position
2.by default array list create buffer of 4 elemnts
3.if bufer filled and double the meomory and repeat
4.arraylist size can be customized
5.object can be provided with the initializers.
		