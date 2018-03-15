using System;

namespace P03_MilesToKilometers
{
    public class P03_MilesToKilometers
    {
        public static void Main(string[] args)
        {
            //input
            var pathInMiles = double.Parse(Console.ReadLine());
            const double pathInKillometers = 1.60934;
            //calculating the distance in kikometers
            var distanceInKilometers = pathInMiles * pathInKillometers;
            //output
            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}