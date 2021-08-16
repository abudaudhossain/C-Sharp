using System;
namespace Read
{
  class Read
  {
    static void Main()
    {while(true){
 	int DecNum, Quotient,Count=0;
	int a,b,Temp,Result;
	Console.WriteLine("\n Enter Your Decimal Number:");
	DecNum=Convert.ToInt32(Console.ReadLine());
	Quotient=DecNum;
	for(a=Quotient;a>0;a=a/8)
	{
  	  Temp=a%8;
	
	  
	    Temp=Temp+48;
	 
	  
 	Count=(Count*100)+Temp;

	}
	Console.Write("The Equlivalent OctalNUm is:");
	for(b= Count;b>0;b=b/100)
	{
	  Result=b%100;
	  Console.Write("{0}",(char)Result);
	}}
 Console.ReadKey();
    }
  }
}