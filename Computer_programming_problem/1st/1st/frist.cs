using System;
namespace Frist{
	class Program{
		public static void Main(){
			int n,i,j=0,k=0;
			n=Convert.ToInt32(Console.ReadLine());
			int[] inputValue = new int[n];
			/*int[] p = new int[];
			int[] N= new int[];*/
			for(i=0;i<=n-1;i++){
				inputValue[i]=Convert.ToInt32(Console.ReadLine());
			}
		for(i=0;i<=n-1;i++){
			//Console.Write(" {0} ",inputValue[i]);
			if(inputValue[i]>0){
				//p[j]=inputValue[i];
				j++;
			}
			else{
				//N[k]=inputValue[i];
				k++;
			}
		}
		Console.WriteLine("\n  {0}   {1}",j,k);
			
		}
	}
}