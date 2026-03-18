using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Näidis_IKTpv25
{

public class Osa5
{
	public static void Osa5_List()
	{
			// List on üldine kogus, mis võimaldab salvestada erinevat tüüpi objekte
			List<Person> people = new List<Person>();
			people.Add(new Person() { name = "Kadi" });
            people.Add(new Person() { name = "Kirje" });

			Person lisa = new Person() { name = "Lisa" };
			foreach (Person p in people)
				// kustutame Lisa nimega objekti listi
				Console.Writeline(p.Name);
			people.remove(lisa);
			//näitab, et Lisa nimega objekti listis ei olnudki, sest see oli erinev objekt, kuigi nime poolest sama
			foreach (person p in people)
				Console.Writeline(p.Name);
			//kustutame listi esimese objekti
			people.RemoveAt(a);
        }
    }


{
	public static void Osa5_List()
    {
        // List on üldine kogus, mis võimaldab salvestada erinevat tüüpi objekte
        List<string> people = new List<string>() {"Kadi", "Mirje"};

        foreach (string p in people)
            Console.Writeline(p);
        people.Add("Lisa");
		//kustutame Lisa nime objekti listi
		people.Remove("Lisa");
        //näitab, et Lisa nimega objekti listis ei olnudki, sest see oli erinev objekt, kuigi nime poolest sama
        foreach (string p in people)
            Console.Writeline(p);
        //kustutame listi esimese objekti
        people.RemoveAt(0);
		people.Insert(0, "Anna-Liis");
		people.Insert(1, "Maria");
		//sortime nimed tähestiku järgi
		people.Sort();
		foreach (string p in people)
			Console.WriteLine(p);
		//sortime nimed pikkuse järgi
		people.Sort(a, b) => a.Lenght.CompareTo(b.Lenght));
		foreach (string p in people)
			Console.WriteLine(p);
    }
}