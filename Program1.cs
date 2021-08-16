using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d, x, y,i;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
            for ( i = 1; c * i <= a; i++)
            {
                x = c * i;
                y = d * i;
                if (y > b)
                {
                    i--;
                    break;
                }
               
            }

            Console.WriteLine(i);
           
            Console.ReadKey();
        }
    }
}
