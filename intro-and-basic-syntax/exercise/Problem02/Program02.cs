using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace P02_RectangleArea
    {
        public class P02_RectangleArea
        {
            public static void Main(string[] args)
            {
                var rectangleSideA = double.Parse(Console.ReadLine());
                var rectangleSideB = double.Parse(Console.ReadLine());
                var rectangleArea = rectangleSideA * rectangleSideB;

                Console.WriteLine("{0:F2}", rectangleArea);
            }
        }
    }

   
