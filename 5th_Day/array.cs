
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n, i, Max, Min;
            Console.WriteLine("How Many Elements you Want to be Stored in The Array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enteer {0}Element in the Array:",n);
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Max = a[0];
            Min = a[0];
            for (i = 1; i<n; i++)
            {
                if (a[i] > Max)
                {
                    Max = a[i];
                }
                if (a[i] < Min)
                {
                    Min = a[i];
                }

            }
                Console.WriteLine("Maxmum Element is : {0}! And \n Minimum Element is :{1}",Max,Min);
            Console.ReadLine();
        }
    }
}
