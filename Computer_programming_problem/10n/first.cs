using System;
namespace Csharp
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter Your Number: ");
			string in_Number=Console.ReadLine();
			Console.Write("You Decimal Number: ");
			int i=0;
			int n=0;
			int j=0;
			while(i<in_Number.Length)
			{
				//int n=0;
				if(in_Number[n]=='0')
				{
					n++;
					
					//continue;
				}

				else{
					//Console.Write("You Decimal Number: ");
					Console.Write(in_Number[i]);
					j++;
				}
				i++;
			}
			if(j==0)
			{
				j++;
			}
			Console.WriteLine("\nNumber of Decimal: "+j);
		}
	}
}