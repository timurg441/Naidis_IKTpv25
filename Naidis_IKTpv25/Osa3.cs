using System;
using System.Collections.Generic;

class Programm
{
    class Inimene
    {
        public string Nimi;
        public int Vanus;
    }

    static void Main()
    {
        Console.WriteLine("1. ARVUDE RUUDUD");

        Console.Write("Sisesta väikseim arv: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Sisesta suurim arv: ");
        int max = int.Parse(Console.ReadLine());

        Random juhuslik = new Random();
        int esimine = juhuslik.Next(min, max + 1);
        int teine = juhuslik.Next(min, max + 1);

        Console.WriteLine("Juhuslikud arvud on: " + esimine + " ja " + teine);

        int vaiksem;
        int suurem;

        if (esimine < teine)
        {
            vaiksem = esimine;
            suurem = teine;
        }
        else
        {
            vaiksem = teine;
            suurem = esimine;
        }

        Console.WriteLine("Arvud vahemikus " + vaiksem + " kuni " + suurem + ":");

        int praegune = vaiksem;
        while (praegune <= suurem)
        {
            int ruut = praegune * praegune;
            Console.WriteLine(praegune + " ruudus on " + ruut);
            praegune++;
        }

        Console.WriteLine("\n2. VIIE ARVU ANALÜÜS");

        double[] minuArvud = new double[5];

        int loendur = 0;
        while (loendur < 5)
        {
            Console.Write("Sisesta " + (loendur + 1) + ". arv: ");
            minuArvud[loendur] = double.Parse(Console.ReadLine());
            loendur++;
        }


