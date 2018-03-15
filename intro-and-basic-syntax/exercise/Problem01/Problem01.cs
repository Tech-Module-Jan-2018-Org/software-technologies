using System;

namespace P01_DebitCardNumber
{
    public class P01_DebitCardNumber
    {
        public static void Main(string[] args)
        {
            //input
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());
            //Formating the numbers and printing them on the console
            Console.WriteLine("{0:D4} {1:D4} {2:0000} {3:0000}", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
    }
}