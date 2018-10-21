using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPiggyName1 = 0;
            int sumPiggyName2 = 0;
            int sumPiggyName3 = 0;

            
            Console.WriteLine("Hey, piggies! Enter your names:");
            Console.Write("Piggy 1: ");
            string piggyName1 = Console.ReadLine();
            Console.Write("Piggy 2: ");
            string piggyName2 = Console.ReadLine();
            Console.Write("Piggy 3: ");
            string piggyName3 = Console.ReadLine();

            
            foreach (char a in piggyName1)
            {
                sumPiggyName1 += a;
            }

            foreach (char b in piggyName2)
            {
                sumPiggyName2 += b;
            }

            foreach (char c in piggyName3)
            {
                sumPiggyName3 += c;
            }

           
            if (sumPiggyName1 > sumPiggyName2 && sumPiggyName1 > sumPiggyName3)
            {
                if (sumPiggyName2 > sumPiggyName3)
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName1} ({sumPiggyName1}) followed by " +
                        $"{piggyName2} ({sumPiggyName2}) and last is {piggyName3} ({sumPiggyName3}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName1} ({sumPiggyName1}) followed by " +
                        $"{piggyName3} ({sumPiggyName3}) and last is {piggyName2} ({sumPiggyName2}).");
                }
            }
            else if (sumPiggyName2 > sumPiggyName1 && sumPiggyName2 > sumPiggyName3)
            {
                if (sumPiggyName1 > sumPiggyName3)
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName2} ({sumPiggyName2}) followed by " +
                        $"{piggyName1} ({sumPiggyName1}) and last is {piggyName3} ({sumPiggyName3}).");
                }
                else
                {
                    Console.WriteLine($"The name-wealthiest pig is {piggyName2} ({sumPiggyName2}) followed by " +
                        $"{piggyName3} ({sumPiggyName3}) and last is {piggyName1} ({sumPiggyName1}).");
                }
            }
            else if (sumPiggyName1 > sumPiggyName2)
            {
                Console.WriteLine($"The name-wealthiest pig is {piggyName3} ({sumPiggyName3}) followed by " +
                    $"{piggyName1} ({sumPiggyName1}) and last is {piggyName2} ({sumPiggyName2}).");
            }
            else
            {
                Console.WriteLine($"The name-wealthiest pig is {piggyName3} ({sumPiggyName3}) followed by " +
                    $"{piggyName2} ({sumPiggyName2}) and last is {piggyName1} ({sumPiggyName1}).");
            }
            Console.WriteLine("Press a key to continue: ");
            Console.ReadLine();
        }
    }
}
