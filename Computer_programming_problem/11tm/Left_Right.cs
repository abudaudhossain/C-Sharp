using System;
namespace Csharp
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter Your string: ");
			string i_val=Console.ReadLine();
			int i;
			//char temp;
			Console.Write("Your string : ");
			for(i=0;i<i_val.Length;i++)
			{
				if(i_val[i]=='L')
				{
					//temp=i_val[i+1];
					//i_val[i]=temp;
					i--;//>
					Console.Write(i_val[i]);
					i++;
					
				}
				else if(i_val[i]=='R')
				{
					i++;
					//i_val[i]=i_val[i];
					Console.Write(i_val[i]);
					i--;
				}
				else{
				
				Console.Write(i_val[i]);
				
				}
				
			}
		Console.Read();	
		}
	}
}