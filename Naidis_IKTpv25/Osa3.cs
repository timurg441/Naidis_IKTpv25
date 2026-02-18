using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("ÜLESANNE: Arvude ruudud\n");

        Console.Write("Sisesta minimaalne arv: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Sisesta maksimaalne arv: ");
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int a = rand.Next(min, max + 1);
        int b = rand.Next(min, max + 1);

        Console.WriteLine($"\nJuhuslikud arvud: {a} ja {b}");

        int algus, lõpp;
        if (a < b) { algus = a; lõpp = b; }
        else { algus = b; lõpp = a; }

        Console.WriteLine($"\nArvude ruudud {algus} kuni {lõpp}:");

        int number = algus;
        while (number <= lõpp)
        {
            Console.WriteLine(number + " ruudus = " + (number * number));
            number++;
        }

        Console.WriteLine("\n\nViie arvu analüüs\n");

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

        Console.WriteLine("\nTULEMUS");
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + keskmine);
        Console.WriteLine("Korrutis: " + korrutis);
    }
}

