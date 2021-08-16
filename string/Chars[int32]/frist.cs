using System;
namespace CSharp{
	class MyProgram{
		public static void Main(string[]args){
			string str="Abu Daud Hossain";
			for(int ctr=0;ctr<=str.Length-1;ctr++){
				Console.Write(" {0} ",str[ctr]);
			}
			int n=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("{0} ",str[n]);
			Console.Read();
		}
	}
}