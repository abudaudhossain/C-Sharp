using System;
namespace Csharp{
	class Arry2D{
		static void Main(){
			int[,] array2D=new int[6,4];
			Console.WriteLine("Enter Array Element:");
			for(int r=0;r<=5;r++)
			{
				for(int c=0;c<=3;c++){
					array2D[r,c]=r+1*c+1;
					
				}
			}
			for(int r=0;r<=5;r++){
				for(int c=0;c<=3;c++){
					Console.Write("\t"+array2D[r,c]);
				}
				Console.WriteLine();
			}
			Console.Read();
			Console.WriteLine("Abu Daud");
			
		}
	}
}