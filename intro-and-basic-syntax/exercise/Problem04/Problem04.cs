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
                //reading the Input
                var Product = Console.ReadLine();
                var Volume = int.Parse(Console.ReadLine());
                var ebPer100ml = int.Parse(Console.ReadLine());
                var sugPer100ml = int.Parse(Console.ReadLine());
                //calculating total energy and sugar
                double totalEnergy = ebPer100ml / 100.0 * Volume;
                double totalSugar = sugPer100ml * Volume / 100.0;
                //printing result
                Console.WriteLine("{0}ml {1}:", Volume, Product);
                Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
            }
        }
    }
