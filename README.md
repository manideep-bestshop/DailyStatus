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
Collections:
------------
array-- type safe, fixed in size
arraylist,hashtable--auto resize and but not type safe
                     
solution is Generics

Generics--type safe and auto resized
String and String Builders:
---------------------------
string:
-------

string: immutable
 string s="hello"   
 s+="World"
 
 creates memoery for every change:
 Hello (one location)
 Hello world (different location)
-> string will not allow changes ,if any change takes place it will be in new memory loaction

 string Builder: Mutable
 ---------------
 stringBulder sb=new stringBulder();
 sb="Hello";
 sb+="World";
  
 saved in same memory loaction
  Hello World
-> It will allow changes ,if any changes takes place it will be in same location

stringBulder execution is also very fast compare with String  
 Exception Handlings:
-------------------
classification of errors:
-------------------------
1.CTE:
------
these errors will when the compile it provides error for those innstructions which are written beyond the syntx or rule.
2.Logical error:
---------------
when expected output mismatch with actual output

3.RTE:
------
this will occur aftrer execution of program

Blocks used in exception handlings:
-----------------------------------
1)try
2)catch
3)finally
4) throw-- single statement block
Boxing and UnBoxing:
--------------------
Boxing:
-------
It is a term used to describe the transformation from "Value Type to Reference Type(object)".
At runtime it creates a temparory reference type box for the object an heap memory.

UnBoxing:
---------
It is a term used describe the transformation from reference type to value type It should be converted explicitly.

 int i=37;
 object j = i;   //Boxing Value type to reference type  
 // 1) value is copied from stack to heap
 //2) creates Box for that value
 //3) Provide reference for that value
 //4) returns reference to stack
 
 Console.WriteLine(i+" "+j); // 37 37

 // int k = j; CTE-- need Explicit

 int k = (int)j;  //UnBoxing refernce type to value type
            
Access Specifiers:
------------------
In C#,access specifiers are keywords used to control the visibility and accessability of types and their members(fields,methods,properties etc..)
 there are four main access specifiers in c#
 
 1)Public: Public members are accessible from any other code in same Assembly or referencing Assembly.
 2)Private: private members are accessible only within the same class.
 3)Protected:Protected members are accessible within the same class and also in derived class
 4)Internal:Internal members accessible within the same assembly but not from outside the assembly.
 
1. What are access specifiers in C#?
A. Access specifiers are keywords used to control the visibility and accessability of the members(fields,methods,Properties).

2.Why are access specifiers important in object-oriented programming?
A.Access specifiers are like security guards for the data and methods within an object-oriented programming.
  they control who gets to see and use what. Imagine your object as a house with different rooms containing valuable items.
  Access specifiers decide who can enter which room and who can touch or modify the items inside.

3.Explain the difference between public, private, protected, and internal access specifiers. 
A. Public: Public members are accessible from any other code in same Assembly or referencing Assembly.
   Private: private members are accessible only within the same class.
   Protected:Protected members are accessible within the same class and also in derived class
   Internal:Internal members accessible within the same assembly but not from outside the assembly.
 
4.Can you have multiple access specifiers for a single member in C#?
A. No, a single member can only have one access specifier in C#. 
  Combining multiple access specifiers for a single member is not allowed.

5.What is the default access specifier for members in a C# class if no access specifier is specified?
A.
The default access specifier for members in a C# class is private.

6.How does the protected internal access specifier differ from protected and internal individually?
A.protected internal: Members are accessible within the same assembly or by derived classes,
 regardless of the assembly in which they are derived.
 protected: Members are accessible within the same class or by derived classes.
 internal: Members are accessible only within the same assembly.

7.What is the significance of the private protected access specifier introduced in C# 7.2?
A.private protected: Members are accessible within the same assembly and
  by derived classes that are declared within the same assembly.

8.How does the accessibility of members differ between base classes and derived classes?
A.Derived classes inherit accessible members (public and protected) from their base classes.
 Private members are not inherited and cannot be accessed directly by derived classes.

9.Explain the concept of encapsulation and how access specifiers contribute to it.
A.Encapsulation is the bundling of data and methods that operate on the data into a single unit (class) and controlling access to that unit.
 Access specifiers help enforce encapsulation by allowing developers to specify which parts of a class are visible to other parts of the program.

10.Can access specifiers be applied to namespaces in C#?
A.No, access specifiers cannot be applied to namespaces in C#. Namespaces do not have accessibility levels.

11.How does the protected internal access specifier affect inheritance and access control within different assemblies?
A.protected internal members are accessible within the same assembly and by derived classes,
 regardless of the assembly in which they are derived. owever, outside the assembly, 
 protected internal members behave as protected, meaning they are accessible only by derived classes

12.What happens if you attempt to access a private member of a class from outside the class?
A.If you attempt to access a private member of a class from outside the class, you will encounter a compilation error,
  indicating that the member is inaccessible due to its protection level.

13.When would you use the internal access specifier instead of public or private?
A.You would use the internal access specifier when you want members to be accessible only within the same assembly but not from outside the assembly.
 This is useful for hiding implementation details and ensuring that certain functionalities are only accessible within a specific assembly.

14.Can you change the accessibility of a base class member in a derived class?
A.No, the accessibility of a base class member cannot be changed in a derived class. 
The accessibility of a member is determined by its declaration in the base class and cannot be altered in derived classes.


Methods in C#:
-------------
In c#,Methods are classified based on various criteria such as access modiffiers,return types and parameters.

1.Instance Method:
------------------
These are methods that operates on an instance of a class and can access instance variables and other instance methods.

2.Static Method:
----------------
These methods belong to the class rather to any specific instance.They can be called using the class name

3.Parameterized methods:
------------------------
These methods accept parameters that provide input for the method logic

4.Return Types Methods:
-----------------------
These methods return a value after programing a logic

5.Void Method:
--------------
These methods are do not return any value

6.Overloaded Methods:
---------------------
these are the methods with same name and with different parameters lists


1.What is a method in C#?
A. Method in C# is a block of code that performs a specific task

2.Explain the difference between instance methods and static methods in C#.
A.Instance methods operate on an instance of a class and can access instance variables. 
  Static methods belong to the class itself and can be called without creating an instance of the class.
  
3.How do you define a method with multiple parameters in C#?
A.  public void MyMethod(int param1, string param2)
   {
    // Method logic
   }

4.What is method overloading? Provide an example.
A.Method overloading is the ability to define multiple methods with the same name but different parameter lists within the same class.   

5.How do you return multiple values from a method in C#?
A.You can return multiple values from a method by using out or by returning an object 
  that encapsulates multiple values such as a tuple or a custom class.

6.What are access modifiers in C# methods? Provide examples.
A.Access modifiers control the visibility and accessibility of methods. Examples include public, private, protected, and internal  

7.How do you call a base class method from a derived class in C#?
A.You can call a base class method from a derived class using the base keyword followed by the method name.

8.Explain the purpose of the override keyword in C# methods.
A.The override keyword is used to override a virtual or abstract method defined in a base class. 
  It allows derived classes to provide their own implementation of the me

9.What is the difference between virtual and abstract methods in C#?
A.virtual methods have a default implementation in the base class but can be overridden in derived classes. 
  abstract methods do not have an implementation in the base class and must be overridden in derived classes. 

10.Explain the concept of method signature in C#.
A.The method signature consists of the method's name and its parameter list.
 It does not include the return type or the method's access modifie  
 
 
Basic C# questions:
------------------
1.What is method overloading in C#?
A.Method overloading allows multiple methods in the same class to have the same name but with different parameter lists.

2.Describe the difference between for, foreach, while, and do-while loops in C#.?
A.for loop is used when the number of iterations is known, foreach loop is used to iterate over collections, while loop continues 
  iterating while a condition is true, and do-while loop is similar to while loop but guarantees at least one iteratio
  
3.How would you break out of nested loops in C#?
A.You can use the break statement followed by a label name to break out of nested loops in C#.

4.What is the purpose of the continue statement in a loop?
A.The continue statement is used to skip the current iteration of a loop and proceed to the next iteration. 

5.Explain the difference between break and return statements.
A.break is used to exit a loop or switch statement, while return is used to exit a method and optionally return a value.

6.What is an enum in C#?
A.An enum, short for enumeration, is a distinct type consisting of a set of named constants called enumerators. 

7.How do you define an enum in C#?
A.Enums are defined using the enum keyword followed by the enum name and a list of comma-separated enum members enclosed in curly braces.

8.What are implicit and explicit conversions in C#?
A.Implicit conversions are performed automatically by the compiler when no data loss can occur, 
while explicit conversions require a cast operator and may result in data loss.

9.What is the difference between boxing and unboxing in C#?
A.Boxing is the process of converting a value type to a reference type, while unboxing is the process of converting a reference type back to a value type.

10.How would you convert a string to an integer in C#?
A.You can use methods like int.Parse() or int.TryParse() to convert a string to an integer in C#.

					 		
