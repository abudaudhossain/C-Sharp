using System;
namespace Csharp
{
	class Ages_in_Days
	{
		static void Main(string[] args)
		{
			int days,months,age;
			Console.Write("Enter Your Days: ");
			days=Convert.ToInt32(Console.ReadLine());
			if(days > 365)
			{
				age=days/365;
				days=days%365;
				Console.WriteLine("Your age is : Ages : {0}",age);
				if(days>30)
				{
					months=days / 30;
					days=days %30;
					Console.WriteLine("Your age is : Months : {0}\n Days : {1}",months,days);
				}
			}
			else if(days>30)
			{
				months=days / 30;
				days=days %30;
				Console.WriteLine("Your age is : Months : {0}\n Days : {1}",months,days);
				
			}
			else 
				Console.WriteLine("Your age is : Days {0}",days);
			
		}
	}
}