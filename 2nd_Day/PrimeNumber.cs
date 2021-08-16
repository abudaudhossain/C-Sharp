using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.Write("Entern Your Number :");
             n=Convert.ToInt32(Console.ReadLine());
            for ( i = 2; i <= n-1; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("It is Not Prime Number.");
                    break;
                }      
            }
	    if( i==n)
		Console.WriteLine("It is Prime Number.");
            Console.ReadKey();
        }
    }
}
