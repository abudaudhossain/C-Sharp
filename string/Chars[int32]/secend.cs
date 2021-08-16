using System;
namespace CSharp{
	class MyProgram{
		public static void Main(string[]args){
			Console.Write("Type a String: ");
			string myString=Console.ReadLine();
			for(int i=0;i<myString.Length;i++){
				if(Uri.IsHexDigit(myString[i]))
					Console.WriteLine("{0} is a hexadecimal Digit",myString[i]);
				else
					Console.WriteLine("{0} is not a hexadecimal Digit",myString[i]);
			}
		}
	}
}