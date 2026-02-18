using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("TERE TULEMAST\n");

        Console.WriteLine("1. JUKU JA KINO");
        Console.Write("Sisesta oma eesnimi: ");
        string eesnimi = Console.ReadLine();

        string tulemus = Juku(eesnimi);
        Console.WriteLine(tulemus);

        Console.WriteLine("\n2. PINGINAABRID");
        Console.Write("Sisesta esimese inimese nimi: ");
        string nimi1 = Console.ReadLine();

        Console.Write("Sisesta teise inimese nimi: ");
        string nimi2 = Console.ReadLine();

        Console.WriteLine($"{nimi1} ja {nimi2} on tänasest pinginaabrid!");

        Console.WriteLine("\n3. TOA REMONT");
        Console.Write("Sisesta toa pikkus (meetrites): ");
        double pikkus = double.Parse(Console.ReadLine());

        Console.Write("Sisesta toa laius (meetrites): ");
        double laius = double.Parse(Console.ReadLine());

        double pindala = pikkus * laius;
        Console.WriteLine($"Toa põranda pindala on {pindala} m²");

        Console.Write("Kas soovid remonti teha? (jah/ei): ");
        string remont = Console.ReadLine();

        if (remont.ToLower() == "jah")
        {
            Console.Write("Kui palju maksab 1 m2 põrandakatet? ");
            double hind = double.Parse(Console.ReadLine());

            double koguhind = pindala * hind;
            Console.WriteLine($"Põranda vahetamise hind on {koguhind} eurot");
        }
        else
        {
            Console.WriteLine("Remonti ei tehta");
        }

        Console.WriteLine("\n4. SOODUSTUS");
        Console.Write("Sisesta soodushind (pärast 30% allahindlust): ");
        double soodushind = double.Parse(Console.ReadLine());

        double alghind = soodushind / 70 * 100;
        Console.WriteLine($"Alghind oli {alghind} eurot");

        Console.WriteLine("\n5. TEMPERATUUR");
        Console.Write("Sisesta temperatuur (kraadides): ");
        double temp = double.Parse(Console.ReadLine());

        if (temp >= 18)
        {
            Console.WriteLine("Temperatuur on üle 18 kraadi - hea toasoojus");
        }
        else
        {
            Console.WriteLine("Temperatuur on alla 18 kraadi - võiks olla soojem");
        }

        Console.WriteLine("\n6. PIKKUSE HINNANG");
        Console.Write("Sisesta oma pikkus sentimeetrites: ");
        int pikkus2 = int.Parse(Console.ReadLine());

        if (pikkus2 < 150)
        {
            Console.WriteLine("Sa oled lühike");
        }
        else if (pikkus2 >= 150 && pikkus2 < 170)
        {
            Console.WriteLine("Sa oled keskmist kasvu");
        }
        else
        {
            Console.WriteLine("Sa oled pikk");
        }

        Console.WriteLine("\n7. PIKKUS JA SUGU");
        Console.Write("Sisesta oma pikkus sentimeetrites: ");
        int pikkus3 = int.Parse(Console.ReadLine());

        Console.Write("Sisesta oma sugu (M/N): ");
        string sugu = Console.ReadLine();

        if (sugu.ToUpper() == "M")
        {
            Console.WriteLine("MEHED");
            if (pikkus3 < 165)
            {
                Console.WriteLine("Sa oled lühike mees");
            }
            else if (pikkus3 >= 165 && pikkus3 < 180)
            {
                Console.WriteLine("Sa oled keskmist kasvu mees");
            }
            else
            {
                Console.WriteLine("Sa oled pikk mees");
            }
        }
        else if (sugu.ToUpper() == "N")
        {
            Console.WriteLine("NAISED");
            if (pikkus3 < 155)
            {
                Console.WriteLine("Sa oled lühike naine");
            }
            else if (pikkus3 >= 155 && pikkus3 < 170)
            {
                Console.WriteLine("Sa oled keskmist kasvu naine");
            }
            else
            {
                Console.WriteLine("Sa oled pikk naine");
            }
        }
        else
        {
            Console.WriteLine("Tundmatu sugu");
        }

        Console.WriteLine("\n8. POEOST");
        double kogusumma = 0;
        string ostetud = "";

        Console.Write("Kas soovid osta piima? (jah/ei): ");
        string piim = Console.ReadLine();
        if (piim.ToLower() == "jah")
        {
            kogusumma = kogusumma + 1.20;
            ostetud = ostetud + "piim (1.20€), ";
        }

        Console.Write("Kas soovid osta saia? (jah/ei): ");
        string sai = Console.ReadLine();
        if (sai.ToLower() == "jah")
        {
            kogusumma = kogusumma + 1.50;
            ostetud = ostetud + "sai (1.50€), ";
        }

        Console.Write("Kas soovid osta leiba? (jah/ei): ");
        string leib = Console.ReadLine();
        if (leib.ToLower() == "jah")
        {
            kogusumma = kogusumma + 2.00;
            ostetud = ostetud + "leib (2.00€), ";
        }

        if (kogusumma > 0)
        {
            Console.WriteLine($"Ostetud: {ostetud}");
            Console.WriteLine($"Kogu summa: {kogusumma} eurot");
        }
        else
        {
            Console.WriteLine("Sa ei ostnud midagi");
        }

        Console.WriteLine("\nPROGRAMM LÕPPES");
        Console.ReadLine();
    }

    public static string Juku(string nimi)
    {
        if (nimi.ToLower() == "juku")
        {
            Console.Write("Kui vana sa oled? ");
            int vanus = int.Parse(Console.ReadLine());

            string pilet;

            if (vanus < 0 || vanus > 100)
            {
                pilet = "Viga andmetega! Vanus peab olema 0-100";
            }
            else if (vanus < 6)
            {
                pilet = "Sulle on kinopilet TASUTA!";
            }
            else if (vanus >= 6 && vanus <= 14)
            {
                pilet = "Sulle on LASTEPILET";
            }
            else if (vanus >= 15 && vanus <= 65)
            {
                pilet = "Sulle on TÄISPILET";
            }
            else
            {
                pilet = "Sulle on SOODUSPILET";
            }

            return "Tere Juku! Lähme kinno! " + pilet;
        }
        else
        {
            return "Tere " + nimi + ", täna mind kodus pole!";
        }
    }
}
