using System;

public class Program
{
    public static void Main()
    {
        int damagePesho = int.Parse(Console.ReadLine());
        int damageGosho = int.Parse(Console.ReadLine());
        int healthGosho = 100;
        int healthPesho = 100;
        int heal = 10;
        int count = 0;

        for (int i = 1; i > 0; i++)
        {
            count++;

            if (i % 2 == 1)
            {

                if (healthGosho - damagePesho <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round.", count);
                    break;
                }
                healthGosho -= damagePesho;
                Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
            }
            else
            {

                if (healthPesho - damageGosho <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round.", count);
                    break;
                }
                healthPesho -= damageGosho;
                Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
            }
            if (i % 3 == 0)
            {
                healthGosho += heal;
                healthPesho += heal;
            }
        }
    }
}