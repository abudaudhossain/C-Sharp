using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp
{
	class input
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the value of x:");
			string[] x=Console.ReadLine().Split(' ');
			int[] number=new int[5];
			for(int i=0;i<5;i++)
			{
				number[i]=Convert.ToInt32(x[i]);
			}
			foreach(int i in number){
				Console.Write(i+"  ");
			}
			
			Console.ReadKey();
		}
	}
}