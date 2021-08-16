using System;
namespace Csharp
{
	class Distance{
		static void Main()
		{
			double x1,y1,x2,y2,Distance;
			Console.Write("x1:");
			x1=Convert.ToDouble(Console.ReadLine());
			Console.Write("y1:");
			y1=Convert.ToDouble(Console.ReadLine());
			Console.Write("x2:");
			x2=Convert.ToDouble(Console.ReadLine());
			Console.Write("y2:");
			y2=Convert.ToDouble(Console.ReadLine());
			Distance=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
			Console.Write("Distance: {0}",Distance.ToString("0.0000"));
			
			Console.ReadKey();
			Console.WriteLine("\n **Abu Daud Hossain**");
		}
	}
}