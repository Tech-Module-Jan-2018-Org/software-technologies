using System;

namespace Test1
{
    class Min3Numbers
    {
        static void Main(string[] args)
        {

            String name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.Text.StringBuilder sb2 = new System.Text.StringBuilder();
            Console.WriteLine("Name: " + name);
            for (int i = 0; i < maxHealth + 2; i++)
            {

                sb.Append("|");


            }
            for (int i = maxHealth; i > health; i--)
            {
                sb[i] = '.';
            }
            Console.WriteLine("Health: " + sb);

            for (int i = 0; i < maxEnergy + 2; i++)
            {

                sb2.Append("|");


            }
            for (int i = maxEnergy; i > energy; i--)
            {
                sb2[i] = '.';
            }

            Console.WriteLine("Energy: " + sb2);





        }


    }
}