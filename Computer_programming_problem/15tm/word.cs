using System;
namespace Cshap
{
	class program
	{
		static void Main()
		{int j=0;
			string[] word=Console.ReadLine().Split(' ','.','  ');
			foreach(string i in word)
			{
				Console.Write(i+" ");
				j++;
			}
			int amount=j*420;
			Console.Write(j+"\n Your need ={0} tk",amount);
		}
	}
}