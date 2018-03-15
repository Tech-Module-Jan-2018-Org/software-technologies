using System;

namespace P05_CharacterStats
{
    public class P05_CharacterStats
    {
        public static void Main(string[] args)
        {
            //input
            var heroName = Console.ReadLine();
            var heroHp = int.Parse(Console.ReadLine());
            var maxHp = int.Parse(Console.ReadLine());
            var heroEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            // using the method
            string hpBar = buildStatBar(heroHp, maxHp);
            string energyBar = buildStatBar(heroEnergy, maxEnergy);
            //output
            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"Health: {hpBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }
        //Method about the helth and energy
        public static string buildStatBar(int statValue, int barMaxValue)
        {
            string statBar = "|" + new string('|', statValue) + new string('.', barMaxValue - statValue) + "|";
            return statBar;
        }
    }
}
