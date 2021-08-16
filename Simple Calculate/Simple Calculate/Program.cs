using System;

namespace Simple_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c,  A=0;
            for (int i = 0; i < 2; i++)
            {
                a = Convert.ToInt32(Console.Read());
                b = Convert.ToInt32(Console.Read());
                c = Convert.ToDouble(Console.Read());
                A += b * c;
            }
            Console.WriteLine("VALOR A PAGER = R$ {0}",A.ToString("0.00"));

        }
    }
}
