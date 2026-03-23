using System;
using System.Collections.Generic;
using System.Linq;

// Ülesanne 1 klassid
class Toode
{
    public string Nimi { get; set; }
    public double Kalorid100g { get; set; }

    public Toode(string nimi, double kalorid100g)
    {
        Nimi = nimi;
        Kalorid100g = kalorid100g;
    }
}

class Inimene
{
    public string Nimi { get; set; }
    public int Vanus { get; set; }
    public string Sugu { get; set; }
    public double Pikkus { get; set; }
    public double Kaal { get; set; }
    public double Aktiivsustase { get; set; }

    public double ArvutaKalorid()
    {
        double bmr;

        if (Sugu == "M")
        {
            bmr = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
        }
        else
        {
            bmr = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);
        }

        return bmr * Aktiivsustase;
    }
}

// Ülesanne 3 klass
class Opilane
{
    public string Nimi { get; set; }
    public List<int> Hinded { get; set; }

    public Opilane(string nimi, List<int> hinded)
    {
        Nimi = nimi;
        Hinded = hinded;
    }

    public double Keskmine()
    {
        if (Hinded.Count == 0) return 0;
        return Hinded.Average();
    }
}

// Ülesanne 4 klass
class Film
{
    public string Pealkiri { get; set; }
    public int Aasta { get; set; }
    public string Zanr { get; set; }

    public Film(string pealkiri, int aasta, string zanr)
    {
        Pealkiri = pealkiri;
        Aasta = aasta;
        Zanr = zanr;
    }
}

// Ülesanne 6 klass
class Lemmikloom
{
    public string Nimi { get; set; }
    public string Liik { get; set; }
    public int Vanus { get; set; }

    public Lemmikloom(string nimi, string liik, int vanus)
    {
        Nimi = nimi;
        Liik = liik;
        Vanus = vanus;
    }
}

// Ülesanne 7 klass
class Valuuta
{
    public string Nimetus { get; set; }
    public double KurssEurSuhte { get; set; }

    public Valuuta(string nimetus, double kurss)
    {
        Nimetus = nimetus;
        KurssEurSuhte = kurss;
    }
}