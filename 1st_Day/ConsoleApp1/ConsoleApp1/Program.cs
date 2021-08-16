// C# program to convert a decimal 
// number to hexadecimal number 
using System;

class GFG
{
    // function to convert decimal 
    // to hexadecimal 
    static void decToHexa(int n)
    {
        // char array to store 
        // hexadecimal number 
        char[] hexaDeciNum = new char[100];

        // counter for hexadecimal number array 
        int i = 0;
        while (n != 0)
        {
            // temporary variable to 
            // store remainder 
            int temp = 0;

            // storing remainder in temp 
            // variable. 
            temp = n % 16;

            // check if temp < 10 
            if (temp < 10)
            {
                hexaDeciNum[i] = (char)(temp + 48);
                i++;
            }
            else
            {
                hexaDeciNum[i] = (char)(temp + 55);
                i++;
            }

            n = n / 16;
        }

        // printing hexadecimal number 
        // array in reverse order 
        for (int j = i - 1; j >= 0; j--)
            Console.Write(hexaDeciNum[j]);
    }

    // Driver Code 
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        decToHexa(n);
    }
}
