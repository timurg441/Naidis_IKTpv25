using System;
using System.Collections.Generic;

public class Osa5_Ulesanned
{
    public static void Ulesanne1()
    {
        List<Toode> list = new List<Toode>();

        Toode t1 = new Toode();
        t1.Nimi = "Õun";
        t1.Kalorid100g = 50;

        Toode t2 = new Toode();
        t2.Nimi = "Kana";
        t2.Kalorid100g = 200;

        list.Add(t1);
        list.Add(t2);

        Inimene i = new Inimene();

        Console.WriteLine("Sugu (M/N):");
        i.Sugu = Console.ReadLine();

        Console.WriteLine("Kaal:");
        i.Kaal = double.Parse(Console.ReadLine());

        Console.WriteLine("Pikkus:");
        i.Pikkus = double.Parse(Console.ReadLine());

        Console.WriteLine("Vanus:");
        i.Vanus = int.Parse(Console.ReadLine());

        Console.WriteLine("Aktiivsus (1.2-1.9):");
        i.Aktiivsus = double.Parse(Console.ReadLine());

        double bmr = 0;

        if (i.Sugu == "M")
        {
            bmr = 88.36 + 13.4 * i.Kaal + 4.8 * i.Pikkus - 5.7 * i.Vanus;
        }
        else
        {
            bmr = 447.6 + 9.2 * i.Kaal + 3.1 * i.Pikkus - 4.3 * i.Vanus;
        }

        double kalorid = bmr * i.Aktiivsus;

        for (int j = 0; j < list.Count; j++)
        {
            Toode t = list[j];
            double gramm = kalorid / t.Kalorid100g * 100;
            Console.WriteLine(t.Nimi + " " + gramm + " g");
        }
    }

    public static void Ulesanne2()
    {
        Dictionary<string, string> d = new Dictionary<string, string>();

        d.Add("Harjumaa", "Tallinn");
        d.Add("Tartumaa", "Tartu");

        Console.WriteLine("1 - Leia pealinn");
        Console.WriteLine("2 - Leia maakond");
        Console.WriteLine("3 - Mäng");

        int valik = int.Parse(Console.ReadLine());

        if (valik == 1)
        {
            Console.WriteLine("Sisesta maakond:");
            string m = Console.ReadLine();

            if (d.ContainsKey(m))
            {
                Console.WriteLine("Pealinn: " + d[m]);
            }
            else
            {
                Console.WriteLine("Pole olemas, lisa:");
                string linn = Console.ReadLine();
                d.Add(m, linn);
            }
        }

        if (valik == 2)
        {
            Console.WriteLine("Sisesta linn:");
            string linn = Console.ReadLine();

            foreach (KeyValuePair<string, string> x in d)
            {
                if (x.Value == linn)
                {
                    Console.WriteLine("Maakond: " + x.Key);
                }
            }
        }

        if (valik == 3)
        {
            int correct = 0;

            foreach (KeyValuePair<string, string> x in d)
            {
                Console.WriteLine("Mis on " + x.Key + " pealinn?");
                string vastus = Console.ReadLine();

                if (vastus == x.Value)
                {
                    correct = correct + 1;
                }
            }

            int protsent = correct * 100 / d.Count;
            Console.WriteLine("Tulemus: " + protsent + "%");
        }
    }

    public static void Ulesanne3()
    {
        List<Opilane> list = new List<Opilane>();

        for (int i = 0; i < 3; i++)
        {
            Opilane o = new Opilane();

            Console.WriteLine("Nimi:");
            o.Nimi = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Hinne:");
                int h = int.Parse(Console.ReadLine());
                o.Hinded.Add(h);
            }

            list.Add(o);
        }

        double max = 0;
        string parim = "";

        for (int i = 0; i < list.Count; i++)
        {
            double k = list[i].Keskmine();
            Console.WriteLine(list[i].Nimi + " " + k);

            if (k > max)
            {
                max = k;
                parim = list[i].Nimi;
            }
        }

        Console.WriteLine("Parim: " + parim);
    }

    public static void Ulesanne4()
    {
        List<Film> list = new List<Film>();

        list.Add(new Film() { Pealkiri = "A", Aasta = 2000, Zanr = "Action" });
        list.Add(new Film() { Pealkiri = "B", Aasta = 2020, Zanr = "Drama" });
        list.Add(new Film() { Pealkiri = "C", Aasta = 2010, Zanr = "Action" });
        list.Add(new Film() { Pealkiri = "D", Aasta = 2015, Zanr = "Drama" });
        list.Add(new Film() { Pealkiri = "E", Aasta = 2022, Zanr = "Action" });

        Console.WriteLine("Sisesta žanr:");
        string z = Console.ReadLine();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Zanr == z)
            {
                Console.WriteLine(list[i].Pealkiri);
            }
        }

        Film uusim = list[0];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Aasta > uusim.Aasta)
            {
                uusim = list[i];
            }
        }

        Console.WriteLine("Uusim film: " + uusim.Pealkiri);

        Dictionary<string, List<Film>> dict = new Dictionary<string, List<Film>>();

        for (int i = 0; i < list.Count; i++)
        {
            Film f = list[i];

            if (!dict.ContainsKey(f.Zanr))
            {
                dict.Add(f.Zanr, new List<Film>());
            }

            dict[f.Zanr].Add(f);
        }

        foreach (KeyValuePair<string, List<Film>> x in dict)
        {
            Console.WriteLine("Žanr: " + x.Key);

            for (int i = 0; i < x.Value.Count; i++)
            {
                Console.WriteLine(" - " + x.Value[i].Pealkiri);
            }
        }
    }

    public static void Ulesanne5()
    {
        Console.WriteLine("Sisesta arvud:");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        double[] a = new double[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            a[i] = double.Parse(parts[i]);
        }

        Array.Sort(a);

        double sum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            sum = sum + a[i];
        }

        double avg = sum / a.Length;

        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > avg)
            {
                count = count + 1;
            }
        }

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Avg: " + avg);
        Console.WriteLine("Min: " + a[0]);
        Console.WriteLine("Max: " + a[a.Length - 1]);
        Console.WriteLine("Count: " + count);
    }

    public static void Ulesanne6()
    {
        List<Lemmikloom> list = new List<Lemmikloom>();

        for (int i = 0; i < 5; i++)
        {
            Lemmikloom l = new Lemmikloom();

            Console.WriteLine("Nimi:");
            l.Nimi = Console.ReadLine();

            Console.WriteLine("Liik:");
            l.Liik = Console.ReadLine();

            Console.WriteLine("Vanus:");
            l.Vanus = int.Parse(Console.ReadLine());

            list.Add(l);
        }

        int sum = 0;
        Lemmikloom vanim = list[0];

        for (int i = 0; i < list.Count; i++)
        {
            sum = sum + list[i].Vanus;

            if (list[i].Vanus > vanim.Vanus)
            {
                vanim = list[i];
            }

            if (list[i].Liik == "kass")
            {
                Console.WriteLine("Kass: " + list[i].Nimi);
            }
        }

        Console.WriteLine("Keskmine vanus: " + sum / list.Count);
        Console.WriteLine("Vanim: " + vanim.Nimi);
    }

    public static void Ulesanne7()
    {
        List<Valuuta> list = new List<Valuuta>();

        Valuuta v1 = new Valuuta();
        v1.Nimi = "USD";
        v1.Kurss = 1.1;

        Valuuta v2 = new Valuuta();
        v2.Nimi = "GBP";
        v2.Kurss = 0.8;

        list.Add(v1);
        list.Add(v2);

        Console.WriteLine("Sisesta summa:");
        double summa = double.Parse(Console.ReadLine());

        Console.WriteLine("Sisesta valuuta:");
        string nimi = Console.ReadLine();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Nimi == nimi)
            {
                double eur = summa / list[i].Kurss;
                Console.WriteLine("EUR: " + eur);

                double tagasi = eur * list[i].Kurss;
                Console.WriteLine("Tagasi: " + tagasi);
            }
        }
    }
}

