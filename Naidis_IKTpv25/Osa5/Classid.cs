using System.Collections.Generic;

public class Toode
{
    public string Nimi;
    public double Kalorid100g;
}

public class Inimene
{
    public string Sugu;
    public int Vanus;
    public double Pikkus;
    public double Kaal;
    public double Aktiivsus;
}

public class Opilane
{
    public string Nimi;
    public List<int> Hinded = new List<int>();

    public double Keskmine()
    {
        double sum = 0;

        for (int i = 0; i < Hinded.Count; i++)
        {
            sum = sum + Hinded[i];
        }

        double keskmine = sum / Hinded.Count;
        return keskmine;
    }
}

public class Film
{
    public string Pealkiri;
    public int Aasta;
    public string Zanr;
}

public class Lemmikloom
{
    public string Nimi;
    public string Liik;
    public int Vanus;
}

public class Valuuta
{
    public string Nimi;
    public double Kurss;
}