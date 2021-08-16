using System;
namespace Csharp{
	class arrya2D{
		static void Main(){
			int[,] array2D= new int[4,4];
			int r,c,n;
			Console.WriteLine("Enter Your Array Element:");
			for(r=0;r<=3;r++){
				for(c=0;c<=3;c++)
				{
					Console.Write("array [{0},{1}]:",r,c);
					array2D [r,c]=Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("Array Element:");
			for(r=0;r<=3;r++)
			{
				for(c=0;c<=3;c++)
				{
					Console.Write("\t "+array2D[r,c]);
				}
				Console.WriteLine("\n");
			}
			Console.Read();
		}
	}
}