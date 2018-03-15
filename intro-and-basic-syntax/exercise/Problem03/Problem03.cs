using System;

namespace P03_MilesToKilometers
{
    public class P03_MilesToKilometers
    {
        public static void Main(string[] args)
        {
            //input
            var distanceInMiles = double.Parse(Console.ReadLine());
            const double kilometersPerMile = 1.60934;
            //calculating the distance in kikometers
            var distanceInKilometers = distanceInMiles * kilometersPerMile;
            //output
            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}