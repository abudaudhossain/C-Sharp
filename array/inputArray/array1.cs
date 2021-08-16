using System;
namespace Csharp
{
	class Array{
		static void Main(string [] args)
		{
			int j=0;
			Console.Write("Enter Your Element: ");
			string[] element=Console.ReadLine().Split(' ');
			foreach( string i in element)
			{
				j++;
				Console.Write(i+"\t");
			}
			Console.Write("Number of Element:{0}\n",j);
			int[] Number=new int[j];
			int n=0;
			while(n<j)
			{
				if(element[n]==" ")
					continue;
				else
				{
					int i=0;
					Number[i]=Convert.ToInt32(element[n]);
					i++;
				}
				n++;
			}
			foreach(int i in Number){
				Console.Write(i+"\t");
			}
			
			//int[] array=Convert.ToInt32(element);
		}
	}
}