using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  
                double a, b, MEDIA;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            MEDIA = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = {0}", MEDIA.ToString("0.00000"));
        
            Console.ReadLine();
        }
    }
}
