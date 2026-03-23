using System;
using System.Collections.Generic;

class Ulesanne1
{
    public static void Run()
    {
        List<Toode> tooted = new List<Toode>()
        {
            new Toode("Kana", 165),
            new Toode("Riis", 130),
            new Toode("Õun", 52),
            new Toode("Leib", 250),
            new Toode("Juust", 400)
        };

        Console.Write("Nimi: ");
        string nimi = Console.ReadLine();

        Console.Write("Vanus: ");
        int vanus = int.Parse(Console.ReadLine());

        Console.Write("Sugu (M/N): ");
        string sugu = Console.ReadLine().ToUpper();

        Console.Write("Pikkus (cm): ");
        double pikkus = double.Parse(Console.ReadLine());

        Console.Write("Kaal (kg): ");
        double kaal = double.Parse(Console.ReadLine());

        Console.WriteLine("Aktiivsustase:");
        Console.WriteLine("1.2 - Vähe aktiivne");
        Console.WriteLine("1.55 - Keskmine");
        Console.WriteLine("1.9 - Väga aktiivne");

        double aktiivsus = double.Parse(Console.ReadLine());

        Inimene inimene = new Inimene()
        {
            Nimi = nimi,
            Vanus = vanus,
            Sugu = sugu,
            Pikkus = pikkus,
            Kaal = kaal,
            Aktiivsustase = aktiivsus
        };

        double kalorid = inimene.ArvutaKalorid();

        Console.WriteLine($"\nPäevane kalorivajadus: {Math.Round(kalorid)} kcal\n");

        Console.WriteLine("Kui sööksid ainult ühte toodet päevas:\n");

        foreach (var t in tooted)
        {
            double grammid = kalorid / t.Kalorid100g * 100;

            Console.WriteLine($"{t.Nimi}: {Math.Round(grammid)} g");
        }
    }
}

using System;
using System.Collections.Generic;

class Ulesanne2
{
    public static void Run()
    {
        Dictionary<string, string> maakonnad = new Dictionary<string, string>()
        {
            {"Harjumaa", "Tallinn"},
            {"Tartumaa", "Tartu"},
            {"Pärnumaa", "Pärnu"},
            {"Ida-Virumaa", "Jõhvi"}
        };

        Dictionary<string, string> linnad = new Dictionary<string, string>();

        foreach (var kvp in maakonnad)
        {
            linnad[kvp.Value] = kvp.Key;
        }

        while (true)
        {
            Console.WriteLine("\n1 - Leia maakond pealinna järgi");
            Console.WriteLine("2 - Leia pealinn maakonna järgi");
            Console.WriteLine("3 - Lisa uus kirje");
            Console.WriteLine("4 - Mäng");
            Console.WriteLine("0 - Välju");

            string valik = Console.ReadLine();

            if (valik == "0") break;

            switch (valik)
            {
                case "1":
                    Console.Write("Sisesta pealinn: ");
                    string linn = Console.ReadLine();

                    if (linnad.ContainsKey(linn))
                        Console.WriteLine($"Maakond: {linnad[linn]}");
                    else
                        Console.WriteLine("Ei leitud!");
                    break;

                case "2":
                    Console.Write("Sisesta maakond: ");
                    string maakond = Console.ReadLine();

                    if (maakonnad.ContainsKey(maakond))
                        Console.WriteLine($"Pealinn: {maakonnad[maakond]}");
                    else
                        Console.WriteLine("Ei leitud!");
                    break;

                case "3":
                    Console.Write("Sisesta maakond: ");
                    string uusMaakond = Console.ReadLine();

                    Console.Write("Sisesta pealinn: ");
                    string uusLinn = Console.ReadLine();

                    if (!maakonnad.ContainsKey(uusMaakond))
                    {
                        maakonnad[uusMaakond] = uusLinn;
                        linnad[uusLinn] = uusMaakond;
                        Console.WriteLine("Lisatud!");
                    }
                    else
                    {
                        Console.WriteLine("Juba olemas!");
                    }
                    break;

                case "4":
                    Mang(maakonnad, linnad);
                    break;
            }
        }
    }

    static void Mang(Dictionary<string, string> maakonnad, Dictionary<string, string> linnad)
    {
        Random rnd = new Random();
        int oige = 0;
        int kokku = 5;

        List<string> keys = new List<string>(maakonnad.Keys);

        for (int i = 0; i < kokku; i++)
        {
            bool kysiMaakonda = rnd.Next(2) == 0;

            if (kysiMaakonda)
            {
                string maakond = keys[rnd.Next(keys.Count)];
                Console.Write($"Mis on {maakond} pealinn? ");
                string vastus = Console.ReadLine();

                if (vastus == maakonnad[maakond])
                {
                    Console.WriteLine("Õige!");
                    oige++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus: {maakonnad[maakond]}");
                }
            }
            else
            {
                List<string> linnList = new List<string>(linnad.Keys);
                string linn = linnList[rnd.Next(linnList.Count)];

                Console.Write($"Millises maakonnas asub {linn}? ");
                string vastus = Console.ReadLine();

                if (vastus == linnad[linn])
                {
                    Console.WriteLine("Õige!");
                    oige++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus: {linnad[linn]}");
                }
            }
        }

        double protsent = (double)oige / kokku * 100;
        Console.WriteLine($"\nTulemus: {protsent}%");
    }
}

class Ulesanne3
{
    public static void Run()
    {
        List<Opilane> opilased = new List<Opilane>()
        {
            new Opilane("Mari", new List<int>{5,4,5,3}),
            new Opilane("Jaan", new List<int>{3,4,2,3}),
            new Opilane("Kati", new List<int>{5,5,4,5})
        };

        Console.WriteLine("Õpilaste keskmised hinded:\n");

        foreach (var o in opilased)
        {
            Console.WriteLine($"{o.Nimi}: {o.Keskmine():0.00}");
        }

        var parim = opilased.OrderByDescending(o => o.Keskmine()).First();

        Console.WriteLine($"\nParim õpilane: {parim.Nimi} ({parim.Keskmine():0.00})");

        Console.WriteLine("\nÕpilased paremusjärjestuses:");

        var sorditud = opilased.OrderByDescending(o => o.Keskmine());

        foreach (var o in sorditud)
        {
            Console.WriteLine($"{o.Nimi}: {o.Keskmine():0.00}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Ulesanne4
{
    public static void Run()
    {
        List<Film> filmid = new List<Film>()
        {
            new Film("Inception", 2010, "Ulme"),
            new Film("Titanic", 1997, "Romantika"),
            new Film("Avengers", 2012, "Märul"),
            new Film("Interstellar", 2014, "Ulme"),
            new Film("The Dark Knight", 2008, "Märul")
        };

        Console.Write("Sisesta žanr: ");
        string zanr = Console.ReadLine();

        var tulemused = LeiaZanriJargi(filmid, zanr);

        Console.WriteLine("\nLeitud filmid:");
        foreach (var f in tulemused)
        {
            Console.WriteLine($"{f.Pealkiri} ({f.Aasta})");
        }

        var uusim = LeiaUusimFilm(filmid);
        Console.WriteLine($"\nUusim film: {uusim.Pealkiri} ({uusim.Aasta})");

        var grupid = GrupeeriZanriJargi(filmid);

        Console.WriteLine("\nFilmid žanrite kaupa:");
        foreach (var g in grupid)
        {
            Console.WriteLine($"\n{g.Key}:");
            foreach (var f in g.Value)
            {
                Console.WriteLine($"- {f.Pealkiri}");
            }
        }
    }


    static List<Film> LeiaZanriJargi(List<Film> filmid, string zanr)
    {
        return filmid
            .Where(f => f.Zanr.ToLower() == zanr.ToLower())
            .ToList();
    }

    static Film LeiaUusimFilm(List<Film> filmid)
    {
        return filmid
            .OrderByDescending(f => f.Aasta)
            .First();
    }

    static Dictionary<string, List<Film>> GrupeeriZanriJargi(List<Film> filmid)
    {
        return filmid
            .GroupBy(f => f.Zanr)
            .ToDictionary(g => g.Key, g => g.ToList());
    }
}

using System;
using System.Linq;

class Ulesanne5
{
    public static void Run()
    {
        Console.Write("Sisesta arvud (eralda tühikuga): ");
        string sisend = Console.ReadLine();

        double[] arvud = Tekstist_arvud(sisend);

        Statistika(arvud);

        Array.Sort(arvud);
        Console.WriteLine("\nSorteeritud arvud:");
        foreach (var a in arvud)
        {
            Console.Write(a + " ");
        }
    }

    static double[] Tekstist_arvud(string tekst)
    {
        return tekst
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToArray();
    }

    static void Statistika(double[] arvud)
    {
        double max = arvud.Max();
        double min = arvud.Min();
        double keskmine = arvud.Average();
        double summa = arvud.Sum();

        int suuremad = arvud.Count(x => x > keskmine);

        Console.WriteLine("\nStatistika:");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Keskmine: {keskmine:F2}");
        Console.WriteLine($"Summa: {summa}");
        Console.WriteLine($"Suuremad kui keskmine: {suuremad}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Ulesanne6
{
    public static void Run()
    {
        List<Lemmikloom> loomad = new List<Lemmikloom>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nSisesta lemmikloom {i + 1}:");

            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Liik (kass/koer/...): ");
            string liik = Console.ReadLine();

            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            loomad.Add(new Lemmikloom(nimi, liik, vanus));
        }

        Console.WriteLine("\nKassid:");
        Kuvakassid(loomad);

        double keskmine = KeskmineVanus(loomad);
        Console.WriteLine($"\nKeskmine vanus: {keskmine:F2}");

        var vanim = VanimLoom(loomad);
        Console.WriteLine($"\nVanim loom: {vanim.Nimi} ({vanim.Vanus} a)");

        Console.Write("\nSisesta otsitava looma nimi: ");
        string otsing = Console.ReadLine();

        OtsiNimeJargi(loomad, otsing);
    }


    static void Kuvakassid(List<Lemmikloom> loomad)
    {
        foreach (var l in loomad.Where(l => l.Liik.ToLower() == "kass"))
        {
            Console.WriteLine($"{l.Nimi}, {l.Vanus} a");
        }
    }

    static double KeskmineVanus(List<Lemmikloom> loomad)
    {
        return loomad.Average(l => l.Vanus);
    }

    static Lemmikloom VanimLoom(List<Lemmikloom> loomad)
    {
        return loomad.OrderByDescending(l => l.Vanus).First();
    }

    static void OtsiNimeJargi(List<Lemmikloom> loomad, string nimi)
    {
        var leitud = loomad
            .Where(l => l.Nimi.ToLower() == nimi.ToLower())
            .ToList();

        if (leitud.Count > 0)
        {
            Console.WriteLine("Leitud:");
            foreach (var l in leitud)
            {
                Console.WriteLine($"{l.Nimi} ({l.Liik}, {l.Vanus} a)");
            }
        }
        else
        {
            Console.WriteLine("Looma ei leitud.");
        }
    }
}

using System;
using System.Collections.Generic;

class Ulesanne7
{
    public static void Run()
    {
        Dictionary<string, Valuuta> valuutad = new Dictionary<string, Valuuta>()
        {
            {"USD", new Valuuta("USD", 0.92)},
            {"GBP", new Valuuta("GBP", 1.17)},
            {"SEK", new Valuuta("SEK", 0.089)}
        };

        Console.WriteLine("1 - Valuuta -> EUR");
        Console.WriteLine("2 - EUR -> Valuuta");

        string valik = Console.ReadLine();

        Console.Write("Sisesta valuuta (nt USD): ");
        string nimi = Console.ReadLine().ToUpper();

        if (!valuutad.ContainsKey(nimi))
        {
            Console.WriteLine("Valuutat ei leitud!");
            return;
        }

        Valuuta v = valuutad[nimi];

        Console.Write("Sisesta summa: ");
        double summa = double.Parse(Console.ReadLine());

        if (valik == "1")
        {
            double eur = summa * v.KurssEurSuhte;
            Console.WriteLine($"{summa} {nimi} = {eur:F2} EUR");
        }
        else if (valik == "2")
        {
            double tulemus = summa / v.KurssEurSuhte;
            Console.WriteLine($"{summa} EUR = {tulemus:F2} {nimi}");
        }
    }
}