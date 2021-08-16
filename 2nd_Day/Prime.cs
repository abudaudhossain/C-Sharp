using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
	   for(;;)
           {
            int n,i;
	    Console.Write("Enter The Number:");
   	    int k=Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine("Prime Number.1");
 	    for(n=1;n<=k;n++)
	    {
            for ( i = 2; i <= n-1; i++)
            {
                if (n % i == 0)
                {
                   
                    break;
                }      
            }
	    if( i==n)
	     Console.WriteLine("Prime Number.{0}",n);
             }
	    }
            Console.ReadKey();
        }
    }
}
