using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Programmer: Maxwell Winston
Program Description:  Prints out all Armstrong Numbers (numbers who's individual digits, raised to the power of the number of digits, added together equal
the original number) from 1 to 999999
*/
namespace ArmstrongProgram
{
    class Program
    {
        public static void Main()
        {
            int original;
            int remaining=0;
            int IndividualValue=0;
            int finalValue = 0;
            int expo;
            int count=0;
            System.Console.WriteLine("ARMSTRONG NUMBERS FOUND FROM 1 THROUGH 999999\n");
            for (original = 1; original <= 999999; original++)
            {
                /* Help with this part http://stackoverflow.com/questions/4483886/how-can-i-get-a-count-of-the-total-number-of-digits-in-a-number */
                expo = (int)Math.Floor(Math.Log10(original) + 1);
                remaining = original;
                finalValue = 0;
                while (remaining != 0)
                {
                    IndividualValue = remaining % 10;
                    finalValue = finalValue + (int)Math.Pow(IndividualValue, expo);
                    remaining = remaining / 10;
                }
                if (finalValue == original)
                {
                    count++;
                    System.Console.WriteLine(finalValue);

                }
                
            }
            System.Console.WriteLine("\nTOTAL NUMBER OF ARMSTRONG NUMBERS FOUND WAS " + count);
            System.Console.ReadLine();
        }
        
    }
}
