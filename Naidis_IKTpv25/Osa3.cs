using System;
using System.Collections.Generic;

public class Osa3
{
    class Inimene
    {
        public string Nimi;
        public int Vanus;
    }

    static void Main()
    {
        Console.WriteLine("1. ARVUDE RUUDUD\n");

        Console.Write("Sisesta minimaalne arv: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Sisesta maksimaalne arv: ");
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int a = rand.Next(min, max + 1);
        int b = rand.Next(min, max + 1);

        Console.WriteLine($"\nJuhuslikud arvud: {a} ja {b}");

        int algus, lõpp;
        if (a < b)
        {
            algus = a;
            lõpp = b;
        }
        else
        {
            algus = b;
            lõpp = a;
        }

        Console.WriteLine($"\nArvude ruudud {algus} kuni {lõpp}:");

        int number = algus;
        while (number <= lõpp)
        {
            Console.WriteLine(number + " ruudus = " + (number * number));
            number++;
        }

        Console.WriteLine("\n\n2. VIIE ARVU ANALÜÜS\n");

        double[] arvud = new double[5];

        int indeks = 0;
        while (indeks < 5)
        {
            Console.Write("Arv " + (indeks + 1) + ": ");
            arvud[indeks] = double.Parse(Console.ReadLine());
            indeks++;
        }

        double summa = 0;
        double korrutis = 1;
        indeks = 0;

        while (indeks < 5)
        {
            summa = summa + arvud[indeks];
            korrutis = korrutis * arvud[indeks];
            indeks++;
        }

        double keskmine = summa / 5;

        Console.WriteLine("\nTULEMUS:");
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + keskmine);
        Console.WriteLine("Korrutis: " + korrutis);

        Console.WriteLine("\n\n3. NIMED JA VANUSED\n");

        List<Inimene> inimesed = new List<Inimene>();

        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("\nSisesta " + (i + 1) + ". inimese andmed:");

            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Inimene uus = new Inimene();
            uus.Nimi = nimi;
            uus.Vanus = vanus;

            inimesed.Add(uus);

            i++;
        }

        var tulemus = Statistika(inimesed);

        Console.WriteLine("\nSTATISTIKA");
        Console.WriteLine("Vanuste summa: " + tulemus.Item1);
        Console.WriteLine("Keskmine vanus: " + tulemus.Item2);
        Console.WriteLine("Vanim: " + tulemus.Item3.Nimi + " (" + tulemus.Item3.Vanus + ")");
        Console.WriteLine("Noorim: " + tulemus.Item4.Nimi + " (" + tulemus.Item4.Vanus + ")");

        Console.WriteLine("\n\n4. OSTA ELEVANT ÄRA!\n");

        KuniMärksõnani("elevant", "Osta elevant ära!");

        Console.WriteLine("\nPROGRAMM LÕPPES");
        Console.ReadLine();
    }

    static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
    {
        int summa = 0;

        Inimene vanim = inimesed[0];
        Inimene noorim = inimesed[0];

        int i = 0;
        while (i < inimesed.Count)
        {
            Inimene inimene = inimesed[i];

            summa = summa + inimene.Vanus;

            if (inimene.Vanus > vanim.Vanus)
            {
                vanim = inimene;
            }

            if (inimene.Vanus < noorim.Vanus)
            {
                noorim = inimene;
            }

            i++;
        }

        double keskmine = (double)summa / inimesed.Count;

        return Tuple.Create(summa, keskmine, vanim, noorim);
    }

    static void KuniMärksõnani(string märksõna, string fraas)
    {
        List<string> sisestused = new List<string>();

        string sisend = "";

        Console.WriteLine("Kirjuta midagi. Kui kirjutad '" + märksõna + "', siis lõpetab.");
        Console.WriteLine();

        while (sisend != märksõna)
        {
            Console.Write(fraas + " ");
            sisend = Console.ReadLine();

            if (sisend != märksõna)
            {
                sisestused.Add(sisend);
            }
        }

        Console.WriteLine("\nSISESTASID NEED ASJAD");

        int i = 0;
        while (i < sisestused.Count)
        {
            Console.WriteLine((i + 1) + ". " + sisestused[i]);
            i++;
        }

        Console.WriteLine("\nAitäh! Lõpetasid sõnaga '" + märksõna + "'");
    }
}
