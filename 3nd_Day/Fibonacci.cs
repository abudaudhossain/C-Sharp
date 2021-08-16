using System;
namespace Fibo_Value
{
	class Fibonacci
	{
		public static void Main()
		{
			while(true)
			{
				int PrePre=0,Pre=1,Current,i,n;
				Console.Write("Enter Number of Trems to be Display:");
				n=Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("The Fibonacci Series Upto {0} Trems:",n);
				Console.Write("{0}\t{1} ",PrePre,Pre);
				for(i=3;i<=n;i++)
				{
					Current=PrePre+Pre;
					Console.Write("\t{0} ",Current);
					PrePre=Pre;
					Pre=Current;
				}
				Console.Write("\n");
			}
				Console.ReadLine();
			
		}
	}
}