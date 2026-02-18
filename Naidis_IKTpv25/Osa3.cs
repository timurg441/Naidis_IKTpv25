using System;

public class Programm
{
    public static void Main()
    {
        Console.WriteLine("Programm numbrite ruutude jaoks");
        Console.Write("Sisestage minimaalne arv: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Sisestage maksimaalne arv: ");
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();

        int arv1 = rand.Next(min, max + 1);
        int arv2 = rand.Next(min, max + 1);

        Console.WriteLine($"\nJuhuslikud numbrid: {arv1} и {arv2}");

        int vaiksem;
        int suurem;

        if (arv1 < arv2)
        {
            vaiksem = arv1;
            suurem = arv2;
        }
        else
        {
            vaiksem = arv2;
            suurem = arv1;
        }

        Console.WriteLine($"\nNumbrite ruudud alates {vaiksem} kuni {suurem}:");

        int praegune = vaiksem;
        while (praegune <= suurem)
        {
            int ruut = praegune * praegune;
            Console.WriteLine($"{praegune} * {praegune} = {ruut}");
            praegune++;
        }
    }
}