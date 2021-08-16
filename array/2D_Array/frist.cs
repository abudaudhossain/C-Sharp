using System;
namespace Csharp{
	 class DArray{
		 static void Main(string[] args){
			int[,] array2D=new int[4,2]{{1,2},{3,5},{4,5},{5,8}};
			for(int i=0;i<=3;i++){
				for(int j=0;j<=1;j++){
					array2D [i,j]=Convert.ToInt32(Console.ReadLine());
				}
			}
			
			for(int i=0;i<=3;i++){
				for(int j=0;j<=1;j++){
					Console.Write("   "+array2D[i,j]);
			}Console.WriteLine("\n");
			}
			Console.Read();
			Console.WriteLine("Abu Daud Hossain");
			
		}
	}
}