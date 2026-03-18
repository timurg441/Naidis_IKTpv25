using System;
using System.Collections.Generic;

class Toode
{
    public string Nimi { get; set; }
    public int Kalorid100g { get; set; }
}

class Inimene
{
    public string Nimi { get; set; }
    public int Vanus { get; set; }
    public string Sugu { get; set; }
    public int Pikkus { get; set; }
    public double Kaal { get; set; }
    public double Aktiivsus { get; set; }
}

class Osa5_ulesanned
{
    static void Main()
    {
        Console.WriteLine("KALORITE KALKULAATOR\n");

        List<Toode> toidud = new List<Toode>();

        toidud.Add(new Toode() { Nimi = "Leib", Kalorid100g = 265 });
        toidud.Add(new Toode() { Nimi = "Piim", Kalorid100g = 42 });
        toidud.Add(new Toode() { Nimi = "Juust", Kalorid100g = 402 });
        toidud.Add(new Toode() { Nimi = "Kana", Kalorid100g = 165 });
        toidud.Add(new Toode() { Nimi = "Õun", Kalorid100g = 52 });
        toidud.Add(new Toode() { Nimi = "Kartul", Kalorid100g = 77 });

        Inimene kasutaja = new Inimene();

        Console.Write("Sisesta oma nimi: ");
        kasutaja.Nimi = Console.ReadLine();

        Console.Write("Sisesta vanus: ");
        kasutaja.Vanus = int.Parse(Console.ReadLine());

        Console.Write("Sisesta sugu (M/N): ");
        kasutaja.Sugu = Console.ReadLine().ToUpper();

        Console.Write("Sisesta pikkus (cm): ");
        kasutaja.Pikkus = int.Parse(Console.ReadLine());

        Console.Write("Sisesta kaal (kg): ");
        kasutaja.Kaal = double.Parse(Console.ReadLine());

        Console.Write("Sisesta aktiivsus (1.2 - vähe, 1.5 - keskmine, 1.9 - palju): ");
        kasutaja.Aktiivsus = double.Parse(Console.ReadLine());

        double energia = 0;

        if (kasutaja.Sugu == "M")
        {
            energia = 88.362 + (13.397 * kasutaja.Kaal) + (4.799 * kasutaja.Pikkus) - (5.677 * kasutaja.Vanus);
        }
        else
        {
            energia = 447.593 + (9.247 * kasutaja.Kaal) + (3.098 * kasutaja.Pikkus) - (4.330 * kasutaja.Vanus);
        }

        energia = energia * kasutaja.Aktiivsus;

        Console.WriteLine($"\n{kasutaja.Nimi}, sinu päevane energiavajadus on: {energia:F0} kcal");

        Console.WriteLine("\nSoovituslikud kogused päevas:");

        foreach (Toode toit in toidud)
        {
            double kogusGrammides = (energia / toit.Kalorid100g) * 100;

            Console.WriteLine($"{toit.Nimi}: {kogusGrammides:F0} grammi");
        }

        Console.WriteLine("\n500 kcal saamiseks vajalik kogus:");

        foreach (Toode toit in toidud)
        {
            double kogus500 = (500.0 / toit.Kalorid100g) * 100;
            Console.WriteLine($"{toit.Nimi}: {kogus500:F0} g (annab 500 kcal)");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
