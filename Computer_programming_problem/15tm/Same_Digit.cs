using System;
namespace Csharp
{
	class S_D_program{
		static void Main()
		{
			/*char a;
			int k=0;
		
			string[] i_Number=Console.ReadLine().Split(' ');
			foreach(string i in i_Number)
			{
				Console.Write("i_number{0}= {1} \n",k,i);
				k++;
			}
			for(int i=0;i<i_Number[0].Length;i++)
				
			{
				Console.WriteLine("i_Number[0][{0}]={1} ",i,i_Number[0][i]);
				for(int j=0;j<i_Number[1].Length;j++)
				{
					Console.WriteLine("i_Number[1][{0}]= {1}",j,i_Number[1][j]);
					if(i_Number[0][i]==i_Number[1][j])
					{
						a=i_Number[0][i];
						k++;
					}
					
				}
			}
			Console.WriteLine(a);
			if(a[0]==0)
			{
				Console.WriteLine("N");
			}*/
			string  i_val1=Console.ReadLine();
			string i_val2=Console.ReadLine();
			char[] a=new char[3];
			char temp;
			int k=0;
			for(int i=0;i<i_val1.Length;i++)
			{
				for(int j=0;j<i_val2.Length;j++)
				{
					//Console.WriteLine(i_val1[i]);
					//Console.WriteLine(i_val2[j]);
					if(i_val1[i]==i_val2[j])
					{
						//a[k]=i_val1[i];
						//k++;
						Console.WriteLine(i_val1[i]+" fff= {0}",a[k]);
					}
				}
			}
			if(a[k]<a[k-1])
			{
				temp=a[k];
				a[k]=a[k-1];
				a[k-1]=temp;
			}
			
			Console.Write(a[k-1]+a[k]);
		}
	}
}