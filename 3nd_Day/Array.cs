using System;
namespace Array_Value
{
	class Array
	{
		public static void Main()
		{
			while(true)
			{	
				int i,j;
				int[] array=new int[5];
				for( i=0;i<=4;i++)
				{
					Console.Write("Array Element {0}:",i);
					array [i]=Convert.ToInt32(Console.ReadLine());
				}
					Console.Write("Array Element are:");				
				for(j=0;j<=i;j++)
				{
					Console.Write("{0} \t",array[j]);
				}
			}
				Console.ReadLine();
			
		}
	}
}