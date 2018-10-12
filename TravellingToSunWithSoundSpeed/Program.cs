using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace TravellingToSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SpeedOfSound = 1225.04; // in km/h
            const long DistToSun = 149600000; // in km
            double TimeNeeded = Math.Round(DistToSun / SpeedOfSound); // in hours
            double TimeNeededInYears = Math.Floor(TimeNeeded / 8760);
            double LeftoverDays = Math.Floor(((TimeNeeded / 8760) - TimeNeededInYears) * 365);
            
                Console.WriteLine($"The time needed to travel from the Earth to the Sun is {TimeNeeded} hours, or " +
                    $"{TimeNeededInYears} years and {LeftoverDays} days.");
            Console.ReadKey(true);

        }
            
    }
}
 