using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  
            int a, b, c,d, DIFERENCA;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

           DIFERENCA = (a*b)-(c*d);
            Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
        
            Console.ReadLine();
        }
    }
}
