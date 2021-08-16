using System;
namespace Sharp
{
	class String_B
	{
		static void Main(string [] args)
		{
			int j=0;
			string[] i_sen=Console.ReadLine().Split(' ');
			foreach(string i in i_sen)
			{
				//Console.Write(i+" ");
				j++;
			}
			//Console.Write(j+"\n");
			for(int a=j-1;a>=0;a--)
			{
				Console.Write(i_sen[a]+" ");
			}
			
			Console.ReadKey();
		}
	}
}