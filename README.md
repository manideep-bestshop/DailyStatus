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
		
