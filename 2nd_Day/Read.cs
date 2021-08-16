using System;
namespace Read
{
  class Read
  {
    static void Main()
    {
 	int DecNum, Quotient,Count=0;
	int a,b,Temp,Rusult;
	Console.WriteLine("Enter Your Decimal Number:");
	DecNum=Convert.ToInt32(Console.ReadLine());
	Quotient=DecNum;
	for(a=Quotient;a>0;a=a/16)
	{
  	  Temp=a%16;
	  if(Temp>10)
	  {
	    Temp=Temp+55;
	  }
	 else
	  {
    	    Temp=Temp+48;
	  }
  	 
	}
	for(b=temp;b>0;b=Temp-1)
	{
	  Result=b;
	  Console.Write("0",(char)Result);
	}
 Console.ReadKey();
    }
  }
}