using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace CalculateWeightInTheSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravitationalRatio;
            double weightOnPlanet;

            Console.WriteLine("Enter your weight in kgs as measured on Earth: 70");
            byte weight = 70;


            Console.WriteLine("1: Mercury");
            Console.WriteLine("2: Venus");
            Console.WriteLine("3: Earth (You already know the answer)");
            Console.WriteLine("4: Mars");

            
            byte option = 70;

            switch (option)

            {

                case 1:
                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Mercury.");
                    break;
                case 2:
                    gravitationalRatio = 0.91;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Venus.");
                    break;
                case 3:
                    gravitationalRatio = 1;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Earth.");
                    break;
                case 4:
                    gravitationalRatio = 0.38;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Mars.");
                    break;
               
              

                default:
                    Console.WriteLine("Enter a valid code."); break;
                    

            }
        }
    }
}
    

