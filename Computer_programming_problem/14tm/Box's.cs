using System;
namespace Csharp
{
	class Box
	{
		static void Main()
		{
			int m=Convert.ToInt32(Console.ReadLine());
			for(int i=0;i<m;i++)
			{
				for(int j=0;j<m;j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}