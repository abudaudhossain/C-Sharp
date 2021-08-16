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
			int j=0;
			//int n=Convert.ToInt32(Console.ReadLine());
			int[] array=Console.ReadLine().Replace(" " "").Split(' ',',').Select(str => int.Parse(str)).ToArray();
			Console.WriteLine();
			Console.WriteLine();
			foreach(int i in array)
			{
				Console.WriteLine(i+"");
				
				Console.WriteLine("array [{0}]:{1}",j,array[j]);
				j++;
			}
			Console.WriteLine("arry [3]:{0}",array[3]);
			/*for(int i=0;i<=n-1;i++)
			{
				Console.WriteLine(" "+array[i] +" ");
				
			}*/
			Console.Read();
		}
	}
}