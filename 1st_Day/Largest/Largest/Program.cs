using System;

namespace Largest
{
    class Program
    {
        static void largest(int a,int b,int c)
        {

            if (a > b && a > b)
            {
                Console.WriteLine("Result \t:Largest Number is {0}", a);
            }
            else if (b > c)
            {
                Console.WriteLine("Result \t:Largest Number is {0}", b);

            }
            else
            {
                Console.WriteLine("Result \t:Largest Number is {0}", c);
            }
        
       
        
            Console.Write("Enter Your Frist Number:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Your Second Number:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Your Thrid Number:");
            c = Convert.ToInt16(Console.ReadLine());
        
        static void Main(string[] args)
        {
            
            Program .largest();


                Console.WriteLine();
            Console.ReadKey();
        }
    }
}
