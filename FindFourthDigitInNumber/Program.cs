using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace FindFourthDigitInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 7-DigitNumber: 9876543 ");
            int number = 9876543;
                
            if (number < 1000000 || number > 9999999)
            {
                Console.WriteLine("The number I entered is not 7-DigitNumber");
            }
            else
            {
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;

                Console.WriteLine($"The fourth digit of {number} is {fourthDigit}");
                Console.ReadKey(true);

            }
           
        }
    }
}
