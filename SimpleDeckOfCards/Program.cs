using System;
using System.Text;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace SimpleDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;

            
            Console.WriteLine("Do you want to see a full deck of cards? (yes or no)");
            string answer = Console.ReadLine();

            while (answer != "yes")
            {
                Console.WriteLine("Do you want to see a full deck of cards? (yes or no)");
                answer = Console.ReadLine();
            }

            
            Console.WriteLine($"A {'\u2660'}, A {'\u2665'}, A {'\u2666'}, A {'\u2663'}");
            Console.WriteLine($"2 {'\u2660'}, 2 {'\u2665'}, 2 {'\u2666'}, 2 {'\u2663'}");
            Console.WriteLine($"3 {'\u2660'}, 3 {'\u2665'}, 3 {'\u2666'}, 3 {'\u2663'}");
            Console.WriteLine($"4 {'\u2660'}, 4 {'\u2665'}, 4 {'\u2666'}, 4 {'\u2663'}");
            Console.WriteLine($"5 {'\u2660'}, 5 {'\u2665'}, 5 {'\u2666'}, 5 {'\u2663'}");
            Console.WriteLine($"6 {'\u2660'}, 6 {'\u2665'}, 6 {'\u2666'}, 6 {'\u2663'}");
            Console.WriteLine($"7 {'\u2660'}, 7 {'\u2665'}, 7 {'\u2666'}, 7 {'\u2663'}");
            Console.WriteLine($"8 {'\u2660'}, 8 {'\u2665'}, 8 {'\u2666'}, 8 {'\u2663'}");
            Console.WriteLine($"9 {'\u2660'}, 9 {'\u2665'}, 9 {'\u2666'}, 9 {'\u2663'}");
            Console.WriteLine($"10 {'\u2660'}, 10 {'\u2665'}, 10 {'\u2666'}, 10 {'\u2663'}");
            Console.WriteLine($"J {'\u2660'}, J {'\u2665'}, J {'\u2666'}, J {'\u2663'}");
            Console.WriteLine($"Q {'\u2660'}, Q {'\u2665'}, Q {'\u2666'}, Q {'\u2663'}");
            Console.WriteLine($"K {'\u2660'}, K {'\u2665'}, K {'\u2666'}, K {'\u2663'}");
            
            Console.ReadKey(true);
        }
    }
}
