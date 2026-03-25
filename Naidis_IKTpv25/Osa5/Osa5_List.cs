using System;
using System.Collections.Generic;

namespace Näidis_IKTpv25
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class Osa5
    {
        public static void Osa5_List_Person()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Kirje" });

            Person lisa = new Person() { Name = "Lisa" };

            Console.WriteLine("Kõik inimesed:");
            foreach (Person p in people)
                Console.WriteLine(p.Name);

            people.Remove(lisa);
            Console.WriteLine("Pärast Lisa eemaldamist (ei olnud listis):");
            foreach (Person p in people)
                Console.WriteLine(p.Name);

            people.RemoveAt(0);
            Console.WriteLine("Pärast esimese eemaldamist:");
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void Osa5_List_String()
        {
            List<string> people = new List<string>() { "Kadi", "Mirje" };

            Console.WriteLine("Kõik nimed:");
            foreach (string p in people)
                Console.WriteLine(p);

            people.Add("Lisa");
            people.Remove("Lisa");

            Console.WriteLine("Pärast Lisa eemaldamist:");
            foreach (string p in people)
                Console.WriteLine(p);

            people.RemoveAt(0);

            people.Insert(0, "Anna-Liis");
            people.Insert(1, "Maria");

            Console.WriteLine("Pärast lisamist ja järjestamist:");
            people.Sort();
            foreach (string p in people)
                Console.WriteLine(p);

            people.Sort((a, b) => a.Length.CompareTo(b.Length));
            Console.WriteLine("Pikkuse järgi sorteeritud:");
            foreach (string p in people)
                Console.WriteLine(p);
        }

        static void Main()
        {
            Console.WriteLine(" Person näide ");
            Osa5_List_Person();

            Console.WriteLine("\n String list näide ");
            Osa5_List_String();
        }
    }
}