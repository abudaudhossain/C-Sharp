using System;
namespace Fact_Value
{
	class Fact
	{
		public static void Main()
		{
			while(true)
			{
				int PrePre=0,Pre=1,Current,i,n;
				Console.Write("Enter Number of Trems to be Display:");
				n=int.parse(Console.ReadLine());
				Console.WriteLine("The Fibonacci Series Upto {0} Trems:",n);
				Console.Write("{0} {1}",PrePre,Pre);
				for(i=3;i<=n;i++)
				{
					Current=PrePre+Pre;
					Console.WriteLine("{}",Current);
					PrePre=Pre;
					Pre=Current;
				}
			}
				Console.ReadLine();
			
		}
	}
}