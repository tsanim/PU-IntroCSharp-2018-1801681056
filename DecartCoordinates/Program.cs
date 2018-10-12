using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Let's do some calculations!");
            Console.Write("Enter Xa: -7");
            double xA = -7;
            Console.Write("Enter Ya: -4 ");
            double yA = -4;
            Console.Write("Enter Xb: 17 ");
            double xB = 17;
            Console.Write("Enter Yb: 6.5 ");
            double yB = 6.5;

            
            
            Console.WriteLine("The points have the following coordinates:");
            Console.WriteLine($"Point A({xA},{yA})");
            Console.WriteLine($"Point B({xB},{yB})");
           

            
            double distanceBetweenTwoPoints = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
            Console.WriteLine($"The distance between the two pints is {distanceBetweenTwoPoints}.");
            Console.ReadKey(true);
        }
    }
}
