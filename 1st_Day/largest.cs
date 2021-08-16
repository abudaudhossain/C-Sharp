using System;
namespace Daud
{
 public class abu
 {
   public int a;
   public int b;
   public int c;
   public void Input()
   {

    
     Console.Write("Enter Your Frist Number:");
     a=Convert.ToInt16(Console.ReadLine());
     Console.Write("Enter Your Second Number:");
     b=Convert.ToInt16(Console.ReadLine());
     Console.Write("Enter Your Thrid Number:");
     c=Convert.ToInt16(Console.ReadLine());
    }
    static void largest()	
    {
    if(a>b && a>b)
    {
     Console.WriteLine("Result \t:Largest Number is {0}",a);
    }
    else if(b>c)
    {
     Console.WriteLine("Result \t:Largest Number is {0}",y);
      
    }
    else
    {
     Console.WriteLine("Result \t:Largest Number is {0}",c);
    }
   }
  static void Main()
  {
 while(true){ 
 
   
   abu obj=new abu();
   obj.Input();

   abu.largest();
    Console.ReadKey();}
   
  }
 } 
}