using System;
namespace Csharp
{
	class Area
	{
		static void Main()
		{
			string[] i_val=Console.ReadLine().Split(' ');
			int j=0,n=0;
			foreach(string i in i_val){
				Console.Write(i+" ");
				j++;
			}
			int[] i_arr=new int[10];
			for(int i=0;i<j;i++)
			{
				/*if(i_val[i]==" "){
					//Console.Write("You use whatspase!");
					continue;
				}*/
				if(i_val[i]!=" "){
				Console.WriteLine("You not use whatspase");}
				else
					Console.Write("You use whatspase!");
				/*else{
					i_arr[n]=Convert.ToInt32(i_val[i]);
					n++;
				}*/
			}
			
		}
	}
}