using System;
using System.Collections.Generic;

class Programm
{
    class Inimene
    {
        public string Nimi;
        public int Vanus;
    }

    static void Main()
    {
        Console.WriteLine("1. ARVUDE RUUDUD");

        Console.Write("Sisesta väikseim arv: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Sisesta suurim arv: ");
        int max = int.Parse(Console.ReadLine());

        Random juhuslik = new Random();
        int esimine = juhuslik.Next(min, max + 1);
        int teine = juhuslik.Next(min, max + 1);

        Console.WriteLine("Juhuslikud arvud on: " + esimine + " ja " + teine);

        int vaiksem;
        int suurem;

        if (esimine < teine)
        {
            vaiksem = esimine;
            suurem = teine;
        }
        else
        {
            vaiksem = teine;
            suurem = esimine;
        }

        Console.WriteLine("Arvud vahemikus " + vaiksem + " kuni " + suurem + ":");

        int praegune = vaiksem;
        while (praegune <= suurem)
        {
            int ruut = praegune * praegune;
            Console.WriteLine(praegune + " ruudus on " + ruut);
            praegune++;
        }

        Console.WriteLine("\n2. VIIE ARVU ANALÜÜS");

        double[] minuArvud = new double[5];

        int loendur = 0;
        while (loendur < 5)
        {
            Console.Write("Sisesta " + (loendur + 1) + ". arv: ");
            minuArvud[loendur] = double.Parse(Console.ReadLine());
            loendur++;
        }

        AnalüüsiArve(minuArvud);

        Console.WriteLine("\n3. NIMED JA VANUSED");

        List<Inimene> inimesteList = new List<Inimene>();

        int indeks = 0;
        while (indeks < 5)
        {
            Console.WriteLine("\nSisesta " + (indeks + 1) + ". inimese andmed:");

            Console.Write("Nimi: ");
            String nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Inimene uusInimene = new Inimene();
            uusInimene.Nimi = nimi;
            uusInimene.Vanus = vanus;

            inimesteList.Add(uusInimene);

            indeks++;
        }

        Statistika(inimesteList);

        Console.WriteLine("\n4. OSTA ELEVANT ÄRA!");

        KuniMärksõnani("elevant", "Osta elevant ära!");

        Console.WriteLine("\n5. ARVAMISE MÄNG");

        ArvaArv();

        Console.WriteLine("\n6. SUURIM NELJAKOHALINE ARV");

        SuurimNeliarv();

        Console.WriteLine("\n7. KORRUTUSTABEL");

        GenereeriKorrutustabel();

        Console.WriteLine("\n8. ÕPILASTEGA MÄNGIMINE");

        OppilasteMäng();

        Console.WriteLine("\nPROGRAMM LÕPPES");
        Console.ReadLine();
    }

    static void AnalüüsiArve(double[] arvud)
    {
        double summa = 0;
        double korrutis = 1;

        int i = 0;
        while (i < 5)
        {
            summa = summa + arvud[i];
            korrutis = korrutis * arvud[i];
            i++;
        }

        double keskmine = summa / 5;

        Console.WriteLine("\nTULEMUSED");
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + keskmine);
        Console.WriteLine("Korrutis: " + korrutis);
    }

    static void Statistika(List<Inimene> inimesed)
    {
        int summa = 0;

        Inimene vanim = inimesed[0];
        Inimene noorim = inimesed[0];

        int i = 0;
        while (i < inimesed.Count)
        {
            Inimene inimene = inimesed[i];

            summa = summa + inimene.Vanus;

            if (inimene.Vanus > vanim.Vanus)
            {
                vanim = inimene;
            }

            if (inimene.Vanus < noorim.Vanus)
            {
                noorim = inimene;
            }

            i++;
        }

        double keskmine = (double)summa / inimesed.Count;

        Console.WriteLine("\nSTATISTIKA");
        Console.WriteLine("Vanuste summa: " + summa);
        Console.WriteLine("Keskmine vanus: " + keskmine);
        Console.WriteLine("Vanim inimene: " + vanim.Nimi + ", " + vanim.Vanus + " aastat");
        Console.WriteLine("Noorim inimene: " + noorim.Nimi + ", " + noorim.Vanus + " aastat");
    }

    static void KuniMärksõnani(string märksõna, string fraas)
    {
        List<string> koikSisestused = new List<string>();

        string sisestus = "";

        Console.WriteLine("Kirjuta midagi. Kui kirjutad '" + märksõna + "', siis lõpetab.");
        Console.WriteLine();

        while (sisestus != märksõna)
        {
            Console.Write(fraas + " ");
            sisestus = Console.ReadLine();

            if (sisestus != märksõna)
            {
                koikSisestused.Add(sisestus);
            }
        }

        Console.WriteLine("\nSISESTASID NEED ASJAD");

        int i = 0;
        while (i < koikSisestused.Count)
        {
            Console.WriteLine((i + 1) + ". " + koikSisestused[i]);
            i++;
        }

        Console.WriteLine("\nLõpetasid sõnaga '" + märksõna + "'");
    }

    static void ArvaArv()
    {
        string uuesti = "jah";

        while (uuesti == "jah")
        {
            Random juhuslik = new Random();
            int oigeArv = juhuslik.Next(1, 101);

            Console.WriteLine("Ma mõtlen ühele arvule 1 ja 100 vahel.");
            Console.WriteLine("Sul on 5 katset, et see ära arvata!");
            Console.WriteLine();

            int katse = 1;
            int kasArvas = 0;

            while (katse <= 5 && kasArvas == 0)
            {
                Console.Write(katse + ". katse: ");
                int pakkumine = int.Parse(Console.ReadLine());

                if (pakkumine == oigeArv)
                {
                    Console.WriteLine("ÕIGE! Tubli!");
                    kasArvas = 1;
                }

                if (pakkumine < oigeArv)
                {
                    Console.WriteLine("Liiga väike!");
                }

                if (pakkumine > oigeArv)
                {
                    Console.WriteLine("Liiga suur!");
                }

                katse++;
            }

            if (kasArvas == 0)
            {
                Console.WriteLine("\nKatsed said otsa! Õige arv oli " + oigeArv);
            }

            Console.WriteLine();
            Console.Write("Kas tahad uuesti mängida? (jah/ei): ");
            uuesti = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Mäng läbi! Head aega!");
    }

    static void SuurimNeliarv()
    {
        int[] numbrid = new int[4];

        Console.WriteLine("Sisesta 4 ühekohalist arvu (0 kuni 9)");
        Console.WriteLine();

        int i = 0;
        while (i < 4)
        {
            Console.Write("Sisesta " + (i + 1) + ". arv: ");
            int arv = int.Parse(Console.ReadLine());

            if (arv >= 0 && arv <= 9)
            {
                numbrid[i] = arv;
                i++;
            }
            else
            {
                Console.WriteLine("VIGA! Arv peab olema 0 ja 9 vahel!");
            }
        }

        Console.WriteLine();
        Console.Write("Sisestasid: ");

        i = 0;
        while (i < 4)
        {
            Console.Write(numbrid[i] + " ");
            i++;
        }
        Console.WriteLine();

        if (numbrid[0] < numbrid[1])
        {
            int abi = numbrid[0];
            numbrid[0] = numbrid[1];
            numbrid[1] = abi;
        }

        if (numbrid[0] < numbrid[2])
        {
            int abi = numbrid[0];
            numbrid[0] = numbrid[2];
            numbrid[2] = abi;
        }

        if (numbrid[0] < numbrid[3])
        {
            int abi = numbrid[0];
            numbrid[0] = numbrid[3];
            numbrid[3] = abi;
        }

        if (numbrid[1] < numbrid[2])
        {
            int abi = numbrid[1];
            numbrid[1] = numbrid[2];
            numbrid[2] = abi;
        }

        if (numbrid[1] < numbrid[3])
        {
            int abi = numbrid[1];
            numbrid[1] = numbrid[3];
            numbrid[3] = abi;
        }

        if (numbrid[2] < numbrid[3])
        {
            int abi = numbrid[2];
            numbrid[2] = numbrid[3];
            numbrid[3] = abi;
        }

        Console.Write("Sorteeritud: ");

        i = 0;
        while (i < 4)
        {
            Console.Write(numbrid[i] + " ");
            i++;
        }
        Console.WriteLine();

        int tuhanded = numbrid[0] * 1000;
        int sajad = numbrid[1] * 100;
        int kümned = numbrid[2] * 10;
        int ühed = numbrid[3];

        int suurimArv = tuhanded + sajad + kümned + ühed;

        Console.WriteLine();
        Console.WriteLine("SUURIM ARV: " + suurimArv);
    }

    static void GenereeriKorrutustabel()
    {
        Console.Write("Mitu rida soovid? ");
        int ridadeArv = int.Parse(Console.ReadLine());

        Console.Write("Mitu veergu soovid? ");
        int veergudeArv = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[,] tabel = new int[ridadeArv, veergudeArv];

        int rida = 0;
        while (rida < ridadeArv)
        {
            int veerg = 0;
            while (veerg < veergudeArv)
            {
                tabel[rida, veerg] = (rida + 1) * (veerg + 1);
                veerg++;
            }
            rida++;
        }

        Console.WriteLine("KORRUTUSTABEL:");
        Console.WriteLine();

        Console.Write("    ");
        int v = 1;
        while (v <= veergudeArv)
        {
            if (v < 10)
            {
                Console.Write("   " + v + " ");
            }
            else
            {
                Console.Write("  " + v + " ");
            }
            v++;
        }
        Console.WriteLine();
        Console.WriteLine();

        rida = 0;
        while (rida < ridadeArv)
        {
            if (rida + 1 < 10)
            {
                Console.Write(" " + (rida + 1) + "  ");
            }
            else
            {
                Console.Write((rida + 1) + "  ");
            }

            int veerg = 0;
            while (veerg < veergudeArv)
            {
                int arv = tabel[rida, veerg];

                if (arv < 10)
                {
                    Console.Write("   " + arv + " ");
                }
                else if (arv < 100)
                {
                    Console.Write("  " + arv + " ");
                }
                else
                {
                    Console.Write(" " + arv + " ");
                }

                veerg++;
            }
            Console.WriteLine();
            rida++;
        }

        Console.WriteLine();
        Console.WriteLine("BOONUS: Otsi korrutustulemust");
        Console.Write("Sisesta esimene arv: ");
        int arv1 = int.Parse(Console.ReadLine());

        Console.Write("Sisesta teine arv: ");
        int arv2 = int.Parse(Console.ReadLine());

        if (arv1 >= 1 && arv1 <= ridadeArv && arv2 >= 1 && arv2 <= veergudeArv)
        {
            int tulemus = tabel[arv1 - 1, arv2 - 1];
            Console.WriteLine(arv1 + " x " + arv2 + " = " + tulemus);
        }
        else
        {
            Console.WriteLine("Viga! Arvud peavad olema 1 kuni " + ridadeArv + " ja 1 kuni " + veergudeArv);
        }
    }

    // 8. ülesanne - Õpilastega mängimine
    static void OppilasteMäng()
    {
        string[] oppilased = new string[10] {
            "Anna", "Bruno", "Carlos", "Diana", "Eva",
            "Fred", "Georg", "Hanna", "Ivan", "Julia"
        };

        Console.WriteLine("ALGNE NIMEDE MASSIIV:");
        int i = 0;
        while (i < oppilased.Length)
        {
            Console.WriteLine(i + ". " + oppilased[i]);
            i++;
        }
        Console.WriteLine();

        oppilased[2] = "Kati";
        oppilased[5] = "Mati";

        Console.WriteLine("PÄRAST MUUTMIST (Kati ja Mati lisatud):");
        i = 0;
        while (i < oppilased.Length)
        {
            Console.WriteLine(i + ". " + oppilased[i]);
            i++;
        }
        Console.WriteLine();

        Console.WriteLine("While tsükkel: Ainult A-ga algavad nimed");
        int j = 0;
        while (j < oppilased.Length)
        {
            string nimi = oppilased[j];
            string esimineTäht = nimi.Substring(0, 1);
            if (esimineTäht == "A")
            {
                Console.WriteLine("Tere, " + nimi + "!");
            }
            j++;
        }
        Console.WriteLine();

        Console.WriteLine("For tsükkel: Kõik nimed indeksitega");
        for (int k = 0; k < oppilased.Length; k++)
        {
            Console.WriteLine("Indeks " + k + ": " + oppilased[k]);
        }
        Console.WriteLine();

        Console.WriteLine("Foreach tsükkel: Kõik nimed väikeste tähtedega");
        foreach (string nimi in oppilased)
        {
            string vaikeTähtedega = nimi.ToLower();
            Console.WriteLine(vaikeTähtedega);
        }
        Console.WriteLine();

        Console.WriteLine("Do-while tsükkel: Tervitan kuni Matini");
        int m = 0;
        do
        {
            string nimi = oppilased[m];
            Console.WriteLine("Tere, " + nimi + "!");
            m++;
        } while (oppilased[m] != "Mati" && m < oppilased.Length);
        Console.WriteLine("Jõudsin Matini, lõpetan tervitamise.");
        Console.WriteLine();
    }
}
