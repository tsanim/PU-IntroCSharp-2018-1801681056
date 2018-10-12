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

            Console.WriteLine("Enter your weight in kgs as measured on Earth:");
            byte weight = byte.Parse(Console.ReadLine());


            Console.WriteLine("1: Mercury");
            Console.WriteLine("2: Venus");
            Console.WriteLine("3: Earth (You already know the answer)");
            Console.WriteLine("4: Mars");


            byte option = byte.Parse(Console.ReadLine());

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
                case 5:
                    gravitationalRatio = 2.34;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Jupiter.");
                    break;
                case 6:
                    gravitationalRatio = 1.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Saturn.");
                    break;
                case 7:
                    gravitationalRatio = 0.92;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Uranus.");
                    break;
                case 8:
                    gravitationalRatio = 1.19;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Neptune.");
                    break;
                case 9:
                    gravitationalRatio = 0.06;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Pluto.");
                    break;

                default:
                    Console.WriteLine("Enter a valid code."); break;
                    Console.ReadKey(true);

            }
        }
    }
}
    

