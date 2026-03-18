using System;
using System.Collections;

class Osa5
{
    static void Main()
    {
        ArrayList nimed = new ArrayList();

        nimed.Add("Kati");
        nimed.Add("Mati");
        nimed.Add("Juku");

        if (nimed.Contains("Mati"))
            Console.WriteLine("Mati on olemas");

        Console.WriteLine("Nimesid: " + nimed.Count);

        nimed.Insert(1, "Sass");

        Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));

        Console.WriteLine("Kõik nimed:");
        foreach (string nimi in nimed)
            Console.WriteLine(nimi);
    }
}

using System;

class Osa5
{
    static void Main()
    {
        Tuple<float, char> teekond = new Tuple<float, char>(2.5f, 'N');

        Console.WriteLine("Vahemaa: " + teekond.Item1);
        Console.WriteLine("Suund: " + teekond.Item2);

        Tuple<string, int> inimene = new Tuple<string, int>("Jaan", 25);
        Console.WriteLine("Nimi: " + inimene.Item1);
        Console.WriteLine("Vanus: " + inimene.Item2);
    }
}

using System;
using System.Collections.Generic;

class Osa5
{
    static void Main()
    {
        List<string> nimed = new List<string>();

        nimed.Add("Kadi");
        nimed.Add("Mirje");
        nimed.Add("Lisa");

        Console.WriteLine("Kõik nimed:");
        foreach (string nimi in nimed)
            Console.WriteLine(nimi);

        Console.WriteLine("Kokku: " + nimed.Count);

        Console.WriteLine("Esimene: " + nimed[0]);

        nimed.Remove("Lisa");
        Console.WriteLine("Pärast Lisa eemaldamist:");
        foreach (string nimi in nimed)
            Console.WriteLine(nimi);
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> numbrid = new LinkedList<int>();

        numbrid.AddLast(5);
        numbrid.AddLast(3);
        numbrid.AddFirst(0);

        Console.WriteLine("Arvud:");
        foreach (int arv in numbrid)
            Console.Write(arv + " ");

        Console.WriteLine();

        numbrid.RemoveFirst();
        Console.WriteLine("Pärast esimese eemaldamist:");
        foreach (int arv in numbrid)
            Console.Write(arv + " ");

        Console.WriteLine();

        numbrid.AddLast(555);
        Console.WriteLine("Pärast 555 lisamist:");
        foreach (int arv in numbrid)
            Console.Write(arv + " ");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> riigid = new Dictionary<int, string>();

        riigid.Add(1, "Hiina");
        riigid.Add(2, "Eesti");
        riigid.Add(3, "Itaalia");

        Console.WriteLine("Riigid:");
        foreach (var paar in riigid)
            Console.WriteLine(paar.Key + " - " + paar.Value);

        Console.WriteLine("Võti 2: " + riigid[2]);

        riigid[2] = "Eestimaa";
        Console.WriteLine("Uus: " + riigid[2]);

        riigid.Remove(3);

        Console.WriteLine("Pärast eemaldamist:");
        foreach (var paar in riigid)
            Console.WriteLine(paar.Key + " - " + paar.Value);
    }
}