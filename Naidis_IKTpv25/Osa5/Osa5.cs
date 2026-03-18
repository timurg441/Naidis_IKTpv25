using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList nimed = new ArrayList();

        nimed.Add("Kati");
        nimed.Add("Mati");
        nimed.Add("Juku");

        if (nimed.Contains("Mati"))
        {
            Console.WriteLine("Mati on olemas");
        }

        Console.WriteLine("Nimesid kokku: " + nimed.Count);

        nimed.Insert(1, "Sass");

        Console.WriteLine("Mati asukoht: " + nimed.IndexOf("Mati"));

        Console.WriteLine("Mari asukoht: " + nimed.IndexOf("Mari"));

        Console.WriteLine("Kõik nimed:");
        foreach (string nimi in nimed)
        {
            Console.WriteLine(nimi);
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');

        Console.WriteLine($"Vahemaa: {route.Item1}");
        Console.WriteLine($"Suund: {route.Item2}");

        var inimene = new Tuple<string, int, string>("Jaan", 25, "Tallinn");
        Console.WriteLine($"Nimi: {inimene.Item1}, Vanus: {inimene.Item2}, Linn: {inimene.Item3}");

        var toode = new Tuple<string, double, int>("Piim", 0.89, 10);
        Console.WriteLine($"Toode: {toode.Item1}, Hind: {toode.Item2}, Kogus: {toode.Item3}");
    }
}

using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>(); 

        Person inimene1 = new Person();
        inimene1.Name = "Kadi";

        Person inimene2 = new Person();
        inimene2.Name = "Mirje";

        people.Add(inimene1);
        people.Add(inimene2);

        foreach (Person p in people)
        {
            Console.WriteLine(p.Name);
        }

        List<string> names = new List<string>();
        names.Add("Anna");
        names.Add("Maria");
        names.Add("Katrin");

        Console.WriteLine("\nNimed:");
        foreach (string nimi in names)
        {
            Console.WriteLine(nimi);
        }

        Console.WriteLine("\nEsimene nimi: " + names[0]);
        Console.WriteLine("Mitu nime: " + names.Count);

        names.Remove("Anna");
        Console.WriteLine("Pärast Anna eemaldamist: " + names.Count);
    }
}