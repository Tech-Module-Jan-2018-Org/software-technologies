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
                var FirstSide = double.Parse(Console.ReadLine());
                var SecondSide = double.Parse(Console.ReadLine());
            //calculating rectangle Area
                var rectangleArea = FirstSide * SecondSide;
            //printing the result
                Console.WriteLine("{0:F2}", rectangleArea);
            }
        }
    }

   
