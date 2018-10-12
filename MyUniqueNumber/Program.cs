using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
           
            int myAge = 19;
            int AgeAfter10Years = myAge + 10;
            Console.WriteLine($"My age after 10 years will be {AgeAfter10Years}. ");
            int Last4Digits = 1056;
            Console.WriteLine($"My last digits of my faculty number are {Last4Digits}.");
            double MyUniqueNumber = Math.Round((AgeAfter10Years * Last4Digits) / pi);

            Console.WriteLine($"After 10 years I will be at {AgeAfter10Years} years old. And my unique number is {MyUniqueNumber}. ");
            Console.ReadKey(true);
        }
    }
}
