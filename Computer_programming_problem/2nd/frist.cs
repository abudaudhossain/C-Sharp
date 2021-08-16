using System;
namespace Cpp{
	class frist{
		public static void Main(){
				Console.Write("Enter Your Line: ");
				int n=Convert.ToInt32(Console.ReadLine());
				string[] Instring=new string[n];
				for(int j=0;j<n;j++){
					Console.Write("Enter Your Element: ");
					Instring[j]=Console.ReadLine();
				}
				//string Instring=Console.ReadLine();
				for(int x=0;x<n;x++)
				{
					int i=1;
					/*while(i<Instring.Length)
					{	
						//Console.Write(Instring[i]+" ");
						
						i++;
					}*/
					for(int j=0;j<Instring[x].Length;j++)
					{
						if(Instring[x][j]==' '&&Instring[x][j+1]!=' ')
						{
							i++;
						}
						else
							continue;
						//else if
						//Console.Write(Instring[j]);
						//Console.Write(i);
					}
					Console.WriteLine("Number of Element: "+i);
				}
				Console.Read();
				
		}
	}
}