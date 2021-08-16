using System;
namespace EvenOrOdd
 {
   class Simple
   {
     public static void Main()
     {
       for(; ;)
      {
       int a,b;
       Console.Write("Enter frist Your Number :\t");
       a=Convert.ToInt16(Console.ReadLine());
       Console.Write("Enter Second Your Number :\t");
       b=Convert.ToInt16(Console.ReadLine());
	if(a%2==0 && b%2==0)
	{
	  Console.WriteLine("Result \t: Both Numbers are Even.");
	}
	else if(a%2!=0 && b%2!=0)
	{
	  Console.WriteLine("Result \t: Both Number are odd.");
	}
        else
	{
	  Console.WriteLine("Result \t: One Number is Even and One Number is Odd.");
	}
	Console.ReadKey();
	}
     }
   }
 }