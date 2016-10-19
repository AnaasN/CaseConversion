using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char UserLowercaseInput;
            int LetterToAscii;
            const int ASCII_CONVERT = 32;
            char UppercaseLetter;

            while (true)
            {
               Console.WriteLine("Enter a lower case character, any alphabetical character, and I'll turn it into a uppercase.");
               UserLowercaseInput = Console.ReadLine()[0];
                    
               if (char.IsLower(UserLowercaseInput))
               {
                  LetterToAscii = (int)UserLowercaseInput - ASCII_CONVERT;
                  UppercaseLetter = (char)LetterToAscii;
                  Console.WriteLine(UppercaseLetter);
               }
               else Console.WriteLine("Incorrect Input. Make sure it is a lowercase letter.");
            }
        }
    }
}
