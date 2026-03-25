using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ArrayList ");
        ArrayList nimedArrayList = new ArrayList();

        nimedArrayList.Add("Kati");
        nimedArrayList.Add("Mati");
        nimedArrayList.Add("Juku");

        if (nimedArrayList.Contains("Mati"))
            Console.WriteLine("Mati on olemas");

        Console.WriteLine("Nimesid: " + nimedArrayList.Count);

        nimedArrayList.Insert(1, "Sass");

        Console.WriteLine("Mati indeks: " + nimedArrayList.IndexOf("Mati"));

        Console.WriteLine("Kõik nimed:");
        foreach (string nimi in nimedArrayList)
            Console.WriteLine(nimi);

        Console.WriteLine();

        Console.WriteLine("Tuple");
        Tuple<float, char> teekond = new Tuple<float, char>(2.5f, 'N');

        Console.WriteLine("Vahemaa: " + teekond.Item1);
        Console.WriteLine("Suund: " + teekond.Item2);

        Tuple<string, int> inimene = new Tuple<string, int>("Jaan", 25);
        Console.WriteLine("Nimi: " + inimene.Item1);
        Console.WriteLine("Vanus: " + inimene.Item2);

        Console.WriteLine();

        Console.WriteLine("List<string>");
        List<string> nimedList = new List<string>();

        nimedList.Add("Kadi");
        nimedList.Add("Mirje");
        nimedList.Add("Lisa");

        Console.WriteLine("Kõik nimed:");
        foreach (string nimi in nimedList)
            Console.WriteLine(nimi);

        Console.WriteLine("Kokku: " + nimedList.Count);
        Console.WriteLine("Esimene: " + nimedList[0]);

        nimedList.Remove("Lisa");
        Console.WriteLine("Pärast Lisa eemaldamist:");
        foreach (string nimi in nimedList)
            Console.WriteLine(nimi);

        Console.WriteLine();

        Console.WriteLine("LinkedList<int>");
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
        Console.WriteLine("\n");

        Console.WriteLine("=== Dictionary<int, string> пример ===");
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