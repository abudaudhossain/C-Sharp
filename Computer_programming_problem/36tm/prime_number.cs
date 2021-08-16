using System;
namespace Csharp
{
	class prime_Number
	{
		int i;
		public void Prime(double j)
		{
			double a=Math.Sqrt(j);
			for(i=2;i<=a;i++)
			{
				if(j%i==0)
				{	
				Console.WriteLine("From Mothed-{0} is not prime",j);
				break;
				}
			}
			if(i+1>a)
			{
				Console.WriteLine("From Mothed-- {0} is a prime",j);
			}
		}
		static void Main()
		{  
			double n=Convert.ToDouble(Console.ReadLine());

			int x=27;
			prime_Number obj=new prime_Number();
			obj.Prime(n);
			double a;
			int i;
			 a=Math.Sqrt(n);
			 Console.WriteLine(a);
			for(i=2;i<=a+1;i++)
			{
				double q=n%i;
				Console.Write(q +" ");
				if(n%i==0)
				{	
				Console.WriteLine("\n {0} is not prime-----{1}",n,i);
				break;
				}
			}
			if(i>a)
			{
				Console.WriteLine("\n{0} is a prime",n);
			}
			
		}
	
	}
}