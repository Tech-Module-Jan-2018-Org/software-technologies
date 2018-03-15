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
            //reading Input
                var rectangleSideA = double.Parse(Console.ReadLine());
                var rectangleSideB = double.Parse(Console.ReadLine());
            //calculating rectangle Area
                var rectangleArea = rectangleSideA * rectangleSideB;
            //printing the result
                Console.WriteLine("{0:F2}", rectangleArea);
            }
        }
    }

   
