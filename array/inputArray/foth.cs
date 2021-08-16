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
			
			while(int i=0;i<j)
			{
				if(element[i]==" ")
					continue;
				else
				{
					Number[i]=Convert.ToInt32(element[i]);
				}
				i++;
			}
			foreach(int i in Number){
				Console.Write(i+"\t");
			}
			
			//int[] array=Convert.ToInt32(element);
		}
	}
}