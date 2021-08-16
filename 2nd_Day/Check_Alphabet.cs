using System;
namespace Check_Aphabet
{
  class VowelorConsonant
  {
    public static void Main(string[] args)
    {
     while(true)
     {
      Console.Write("Enter Your Aphabet :");
      char Litter=Convert.ToChar(Console.ReadLine().ToLower());
  
      switch(Litter)
      {
        case 'a':
           Console.WriteLine("It is Vowel");
 	   break;
	case 'e':
           Console.WriteLine("It is Vowel");
 	   break;
	case 'i':
           Console.WriteLine("It is Vowel");
 	   break;
	case 'o':
           Console.WriteLine("It is Vowel");
 	   break;
	case 'u':
           Console.WriteLine("It is Vowel");
 	   break;
	default:
           Console.WriteLine("It is Consonant");
 	   break;
	   	   
      }
     }
	Console.ReadKey();
     
    }
  }
}