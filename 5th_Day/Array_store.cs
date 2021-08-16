using System;
	namespace array
	{
		public class Program
		{
			public static void Main()
			{
				int[] Team=new int[10];
				int i;
				Console.WriteLine("Enter Your Element in Array: ");
				for(i=0;i<=9;i++)
				{
					Console.WriteLine("Array Element {0}:",i);
					Team[i]=Convert.ToInt32(Console.ReadLine());
				}
				Console.Write("Element in Array are:");
				for(i=0;i<=9;i++)
				{
					Console.Write(" {0} ",Team[i]);
				}
				Console.ReadLine();
			}
		}
	}
