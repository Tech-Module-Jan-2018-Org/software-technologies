using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_BeverageLabels
    {
        public class P04_BeverageLabels
        {
            public static void Main(string[] args)
            {
                var product = Console.ReadLine();
                var volume = int.Parse(Console.ReadLine());
                var energyPer100ml = int.Parse(Console.ReadLine());
                var sugarPer100ml = int.Parse(Console.ReadLine());

                double totalEnergy = energyPer100ml / 100.0 * volume;
                double totalSugar = sugarPer100ml * volume / 100.0;

                Console.WriteLine("{0}ml {1}:", volume, product);
                Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
            }
        }
    }
