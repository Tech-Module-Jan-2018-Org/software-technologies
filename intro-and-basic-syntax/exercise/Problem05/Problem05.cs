using System;

namespace P05_CharacterStats
{
    public class P05_CharacterStats
    {
        public static void Main(string[] args)
        {
            //input
            var characterName = Console.ReadLine();
            var characterHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var characterEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            // using the method
            string healthBar = buildStatBar(characterHealth, maxHealth);
            string energyBar = buildStatBar(characterEnergy, maxEnergy);
            //output
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {healthBar}");
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
