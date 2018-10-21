using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace BusTicketLuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
              

      
            int luckyTicketsCount = 0;
            int unluckyTicketsCount = 0;

            
            for (int i = 0; i < 1000000; i++)
            {
                if ((i / 100000 + i % 100000 / 10000 + i % 100000 % 10000 / 1000) == (i % 100000 % 10000 % 1000 / 100 + i % 100000 % 10000 % 1000 % 100 / 10 + i % 10))
                {
                    Console.WriteLine(i);
                    luckyTicketsCount++;
                }
                else
                {
                    unluckyTicketsCount++;
                }
            }

          
            Console.WriteLine("The number of lucky tickets is: " + luckyTicketsCount);
            Console.WriteLine("The number of unlucky tickets is: " + unluckyTicketsCount);
            Console.WriteLine($"Total tickets: {luckyTicketsCount + unluckyTicketsCount}");
            Console.WriteLine("Press a key to continue: ");
            Console.ReadLine();
        }
    }
}
