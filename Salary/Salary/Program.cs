using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c,d,e;
            a = convertToInt32(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            d = c * 0.15;
            e = d + b;
            Console.WriteLine("TOTAL = R$ {0}",e.ToString("0.00"));
        }
    }
}
