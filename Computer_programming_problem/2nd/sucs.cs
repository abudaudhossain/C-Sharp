using System;
namespace Csharp
{
	class Program
	{
		static void Main()
		{
			int n=Convert.ToInt32(Console.ReadLine());
			string[] InValue=new string[n];
			for(int ln=0;ln<n;ln++)
			{
				InValue[ln]=Console.ReadLine();

			}
			for(int l=0;l<n;l++)
			{
				int i=1;
				for(int j=0;j<InValue[l].Length;j++)
				{
					if(InValue[l][j]==' '&&InValue[l][j+1]!=' ')
						i++;
					continue;
				}
				Console.WriteLine(i);
			}
			Consoel.ReadKey();
		}
	}
}