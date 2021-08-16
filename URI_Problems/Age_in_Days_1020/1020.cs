using System;
namespace Csharp
{
	class Ages_Days
	{
		static void Main ()
		{
			int days,months,ages;
			 
			 days =Convert.ToInt32(Console.ReadLine());
			 
			 ages=days/365;
			 days=days%365;
			 months=days/30;
			 days=days%30;
			 
			 Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)",ages,months,days);
			
			 Console.ReadKey();
		}
	}
}