
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Osa3
    {
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
        public static (double summa, double keskmine, double korrutis) AnalüüsiArve1(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return (summa, keskmine, korrutis);
        }
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa=inimesed.Sum(i=>i.Vanus);
            double keskmine_vanus = inimesed.Average(i => i.Vanus);
            Inimene vanim = inimesed.OrderByDescending(i => i.Vanus).First();
            Inimene noorim = inimesed.OrderBy(i => i.Vanus).First();
            return Tuple.Create(summa, keskmine_vanus, noorim, vanim);
        }
    }
    
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("VALI ÜLESANNE (1-13)");
            Console.WriteLine("======================================");
            Console.WriteLine("1  - Juhuslike arvude ruudud");
            Console.WriteLine("2  - Viie arvu analüüs");
            Console.WriteLine("3  - Nimed ja vanused");
            Console.WriteLine("4  - Osta elevant ära!");
            Console.WriteLine("5  - Arvamise mäng");
            Console.WriteLine("6  - Suurim neljakohaline arv");
            Console.WriteLine("7  - Korrutustabel");
            Console.WriteLine("8  - Õpilastega mängimine");
            Console.WriteLine("9  - Arvude ruudud");
            Console.WriteLine("10 - Positiivsed ja negatiivsed");
            Console.WriteLine("11 - Keskmisest suuremad");
            Console.WriteLine("12 - Kõige suurema arvu otsing");
            Console.WriteLine("13 - Paari- ja paaritud");
            Console.WriteLine("0  - Lõpeta");
            Console.WriteLine("======================================");
            
            Console.Write("Sinu valik: ");
            string valik = Console.ReadLine();
            
            if (valik == "0")
            {
                Console.WriteLine("Head aega!");
                break;
            }
            
            Console.WriteLine("\n--------------------------------------\n");
            
            if (valik == "1") Ulesanne1();
            else if (valik == "2") Ulesanne2();
            else if (valik == "3") Ulesanne3();
            else if (valik == "4") Ulesanne4();
            else if (valik == "5") Ulesanne5();
            else if (valik == "6") Ulesanne6();
            else if (valik == "7") Ulesanne7();
            else if (valik == "8") Ulesanne8();
            else if (valik == "9") Ulesanne9();
            else if (valik == "10") Ulesanne10();
            else if (valik == "11") Ulesanne11();
            else if (valik == "12") Ulesanne12();
            else if (valik == "13") Ulesanne13();
            else Console.WriteLine("Vale valik! Vali 1-13 või 0");
            
            Console.WriteLine("\nVajuta Enter et jätkata...");
            Console.ReadLine();
        }
    }
    
    // 1. Juhuslike arvude ruudud
    static void Ulesanne1()
    {
        Console.WriteLine("1. JUHUSLIKE ARVUDE RUUDUD");
        
        Console.WriteLine("Sisesta esimene arv:");
        int esimene = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Sisesta teine arv:");
        int teine = int.Parse(Console.ReadLine());
        
        int algus, lõpp;
        if (esimene < teine)
        {
            algus = esimene;
            lõpp = teine;
        }
        else
        {
            algus = teine;
            lõpp = esimene;
        }
        
        Console.WriteLine("\nRuudud:");
        int praegune = algus;
        while (praegune <= lõpp)
        {
            int ruut = praegune * praegune;
            Console.WriteLine(praegune + " -> " + ruut);
            praegune++;
        }
    }
    
    // 2. Viie arvu analüüs
    static void Ulesanne2()
    {
        Console.WriteLine("--- 2. VIIE ARVU ANALÜÜS ---");
        
        double[] arvud = new double[5];
        
        Console.WriteLine("Sisesta 5 arvu:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write((i + 1) + ". arv: ");
            arvud[i] = double.Parse(Console.ReadLine());
        }
        
        double summa = 0;
        double korrutis = 1;
        for (int i = 0; i < 5; i++)
        {
            summa = summa + arvud[i];
            korrutis = korrutis * arvud[i];
        }
        
        double keskmine = summa / 5;
        
        Console.WriteLine("\nTULEMUSED");
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + keskmine);
        Console.WriteLine("Korrutis: " + korrutis);
    }
    
    // 3. Nimed ja vanused
    class Inimene
    {
        public string Nimi;
        public int Vanus;
    }
    
    static void Ulesanne3()
    {
        Console.WriteLine("3. NIMED JA VANUSED");
        
        List<Inimene> inimesed = new List<Inimene>();
        
        Console.WriteLine("Sisesta 5 inimese andmed:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("\n" + (i + 1) + ". inimene:");
            
            Inimene uus = new Inimene();
            
            Console.Write("Nimi: ");
            uus.Nimi = Console.ReadLine();
            
            Console.Write("Vanus: ");
            uus.Vanus = int.Parse(Console.ReadLine());
            
            inimesed.Add(uus);
        }
        
        int summa = 0;
        Inimene vanim = inimesed[0];
        Inimene noorim = inimesed[0];
        
        foreach (Inimene inimene in inimesed)
        {
            summa = summa + inimene.Vanus;
            
            if (inimene.Vanus > vanim.Vanus)
            {
                vanim = inimene;
            }
            
            if (inimene.Vanus < noorim.Vanus)
            {
                noorim = inimene;
            }
        }
        
        double keskmine = (double)summa / 5;
        
        Console.WriteLine("\nSTATISTIKA");
        Console.WriteLine("Vanuste summa: " + summa);
        Console.WriteLine("Keskmine vanus: " + keskmine);
        Console.WriteLine("Vanim: " + vanim.Nimi + " (" + vanim.Vanus + ")");
        Console.WriteLine("Noorim: " + noorim.Nimi + " (" + noorim.Vanus + ")");
    }
    
    // 4. "Osta elevant ära!"
    static void Ulesanne4()
    {
        Console.WriteLine("4. OSTA ELEVANT ÄRA!");
        
        List<string> koikSisestused = new List<string>();
        
        Console.WriteLine("Mäng: Osta elevant ära!");
        
        while (true)
        {
            Console.WriteLine("\nOsta elevant ära!");
            Console.Write("Sisesta sõna: ");
            string sisend = Console.ReadLine();
            
            koikSisestused.Add(sisend);
            
            if (sisend == "elevant")
            {
                break;
            }
        }
        
        Console.WriteLine("\nSisestasid:");
        foreach (string s in koikSisestused)
        {
            Console.WriteLine("- " + s);
        }
    }
    
    // 5. Arvamise mäng
    static void Ulesanne5()
    {
        Console.WriteLine("5. ARVAMISE MÄNG");
        
        bool mangUuesti = true;
        
        while (mangUuesti)
        {
            Random random = new Random();
            int oigeArv = random.Next(1, 101);
            
            Console.WriteLine("Arvuti valis arvu 1-100. Sul on 5 katset!");
            
            bool arvasidOigesti = false;
            
            for (int katse = 1; katse <= 5; katse++)
            {
                Console.Write("\n" + katse + ". katse: ");
                int pakkumine = int.Parse(Console.ReadLine());
                
                if (pakkumine == oigeArv)
                {
                    Console.WriteLine("ÕIGE! Tubli!");
                    arvasidOigesti = true;
                    break;
                }
                else if (pakkumine > oigeArv)
                {
                    Console.WriteLine("Liiga suur!");
                }
                else
                {
                    Console.WriteLine("Liiga väike!");
                }
            }
            
            if (arvasidOigesti == false)
            {
                Console.WriteLine("\nKahju! Õige arv oli " + oigeArv);
            }
            
            Console.Write("\nKas mängid uuesti? (jah/ei): ");
            string vastus = Console.ReadLine();
            
            if (vastus != "jah")
            {
                mangUuesti = false;
                Console.WriteLine("Head aega!");
            }
        }
    }
    
    // 6. Suurim neljakohaline arv
    static void Ulesanne6()
    {
        Console.WriteLine("6. SUURIM NELJAKOHALINE ARV");
        
        int[] arvud = new int[4];
        
        Console.WriteLine("Sisesta 4 numbrit (0-9):");
        for (int i = 0; i < 4; i++)
        {
            Console.Write((i + 1) + ". number: ");
            arvud[i] = int.Parse(Console.ReadLine());
            
            if (arvud[i] < 0 || arvud[i] > 9)
            {
                Console.WriteLine("Viga! Number peab olema 0-9 vahel.");
                return;
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = i + 1; j < 4; j++)
            {
                if (arvud[i] < arvud[j])
                {
                    int abi = arvud[i];
                    arvud[i] = arvud[j];
                    arvud[j] = abi;
                }
            }
        }
        
        int tulemus = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
        
        Console.WriteLine("\nSuurim võimalik arv: " + tulemus);
    }
    
    // 7. Korrutustabel
    static void Ulesanne7()
    {
        Console.WriteLine("7. KORRUTUSTABEL");
        
        Console.Write("Mitu rida? ");
        int read = int.Parse(Console.ReadLine());
        
        Console.Write("Mitu veergu? ");
        int veerud = int.Parse(Console.ReadLine());
        
        int[,] tabel = new int[read, veerud];
        
        for (int r = 0; r < read; r++)
        {
            for (int v = 0; v < veerud; v++)
            {
                tabel[r, v] = (r + 1) * (v + 1);
            }
        }
        
        Console.WriteLine("\nKORRUTUSTABEL:\n");
        for (int r = 0; r < read; r++)
        {
            for (int v = 0; v < veerud; v++)
            {
                Console.Write(tabel[r, v].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("\n--- OTSING ---");
        Console.Write("Sisesta esimene arv: ");
        int arv1 = int.Parse(Console.ReadLine());
        
        Console.Write("Sisesta teine arv: ");
        int arv2 = int.Parse(Console.ReadLine());
        
        if (arv1 <= read && arv2 <= veerud)
        {
            int vastus = tabel[arv1 - 1, arv2 - 1];
            Console.WriteLine(arv1 + " x " + arv2 + " = " + vastus);
        }
        else
        {
            Console.WriteLine("Need arvud on liiga suured!");
        }
    }
    
    // 8. Õpilastega mängimine
    static void Ulesanne8()
    {
        Console.WriteLine("8. ÕPILASTEGA MÄNGIMINE");
        
        string[] opilased = { "Anna", "Boris", "Karl", "Diana", "Erik", "Mati", "Gerli", "Helen", "Ivan", "Kati" };
        
        Console.WriteLine("Algne nimekiri:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(opilased[i] + " ");
        }
        
        opilased[2] = "Kati";
        opilased[5] = "Mati";
        
        Console.WriteLine("\n\nUus nimekiri:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(opilased[i] + " ");
        }
        
        Console.WriteLine("\n\nA-tähega algavad õpilased:");
        int j = 0;
        while (j < 10)
        {
            if (opilased[j][0] == 'A')
            {
                Console.WriteLine("Tere, " + opilased[j] + "!");
            }
            j++;
        }
        
        Console.WriteLine("\nKõik nimed indeksitega:");
        for (int k = 0; k < 10; k++)
        {
            Console.WriteLine(k + ". " + opilased[k]);
        }
        
        Console.WriteLine("\nVäikeste tähtedega:");
        foreach (string nimi in opilased)
        {
            Console.Write(nimi.ToLower() + " ");
        }
        
        Console.WriteLine("\n\nTervitame kuni Matini:");
        int m = 0;
        do
        {
            Console.WriteLine("Tere, " + opilased[m] + "!");
            m++;
        } while (m < 10 && opilased[m-1] != "Mati");
    }
    
    // 9. Arvude ruudud
    static void Ulesanne9()
    {
        Console.WriteLine("9. ARVUDE RUUDUD");
        
        int[] arvud = { 2, 4, 6, 8, 10, 12 };
        
        Console.WriteLine("Arvude ruudud:");
        for (int i = 0; i < 6; i++)
        {
            int ruut = arvud[i] * arvud[i];
            Console.WriteLine(arvud[i] + " ruut = " + ruut);
        }
        
        Console.WriteLine("\nArvude kahekordsed:");
        foreach (int arv in arvud)
        {
            int kahekordne = arv * 2;
            Console.WriteLine(arv + " kahekordne = " + kahekordne);
        }
        
        Console.WriteLine("\n3-ga jaguvad arvud:");
        int j = 0;
        int mitu = 0;
        while (j < 6)
        {
            if (arvud[j] % 3 == 0)
            {
                Console.WriteLine(arvud[j]);
                mitu++;
            }
            j++;
        }
        Console.WriteLine("Kokku " + mitu + " arvu");
    }
    
    // 10. Positiivsed ja negatiivsed
    static void Ulesanne10()
    {
        Console.WriteLine("10. POSITIIVSED JA NEGATIIVSED");
        
        int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
        
        int positiivseid = 0;
        int negatiivseid = 0;
        int nulle = 0;
        
        foreach (int arv in arvud)
        {
            if (arv > 0)
            {
                positiivseid++;
            }
            else if (arv < 0)
            {
                negatiivseid++;
            }
            else
            {
                nulle++;
            }
        }
        
        Console.WriteLine("Positiivseid: " + positiivseid);
        Console.WriteLine("Negatiivseid: " + negatiivseid);
        Console.WriteLine("Nulle: " + nulle);
    }
    
    // 11. Keskmisest suuremad
    static void Ulesanne11()
    {
        Console.WriteLine("11. KESKMISEST SUUREMAD");
        
        Random random = new Random();
        int[] arvud = new int[15];
        
        Console.WriteLine("Genereeritud arvud:");
        for (int i = 0; i < 15; i++)
        {
            arvud[i] = random.Next(1, 101);
            Console.Write(arvud[i] + " ");
        }
        
        int summa = 0;
        for (int i = 0; i < 15; i++)
        {
            summa = summa + arvud[i];
        }
        double keskmine = (double)summa / 15;
        
        Console.WriteLine("\n\nKeskmine: " + keskmine);
        
        Console.WriteLine("\nKeskmisest suuremad:");
        for (int i = 0; i < 15; i++)
        {
            if (arvud[i] > keskmine)
            {
                Console.Write(arvud[i] + " ");
            }
        }
        
        Console.WriteLine("\n\nArvud kuni esimese alla 10-ni:");
        int j = 0;
        do
        {
            Console.Write(arvud[j] + " ");
            j++;
        } while (j < 15 && arvud[j-1] >= 10);
    }
    
    // 12. Kõige suurema arvu otsing
    static void Ulesanne12()
    {
        Console.WriteLine("12. KÕIGE SUUREMA ARVU OTSING");
        
        int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
        
        int suurim = numbrid[0];
        int indeks = 0;
        
        for (int i = 1; i < 8; i++)
        {
            if (numbrid[i] > suurim)
            {
                suurim = numbrid[i];
                indeks = i;
            }
        }
        
        Console.WriteLine("Suurim arv on " + suurim);
        Console.WriteLine("See on kohal " + indeks);
    }
    
    // 13. Paari- ja paaritud
    static void Ulesanne13()
    {
        Console.WriteLine("13. PAARI- JA PAARITUD");
        
        Random random = new Random();
        List<int> arvud = new List<int>();
        
        for (int i = 0; i < 20; i++)
        {
            arvud.Add(random.Next(1, 101));
        }
        
        Console.WriteLine("Arvud:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(arvud[i] + " ");
        }
        
        int paarisSumma = 0;
        for (int i = 0; i < 20; i++)
        {
            if (arvud[i] % 2 == 0)
            {
                paarisSumma = paarisSumma + arvud[i];
            }
        }
        
        int paarituteSumma = 0;
        int paarituteArv = 0;
        foreach (int arv in arvud)
        {
            if (arv % 2 != 0)
            {
                paarituteSumma = paarituteSumma + arv;
                paarituteArv++;
            }
        }
        double paarituteKeskmine = (double)paarituteSumma / paarituteArv;
        
        int yle50 = 0;
        int j = 0;
        while (j < 20)
        {
            if (arvud[j] > 50)
            {
                yle50++;
            }
            j++;
        }
        
        Console.WriteLine("\n\nTULEMUSED");
        Console.WriteLine("Paarisarvude summa: " + paarisSumma);
        Console.WriteLine("Paaritute keskmine: " + paarituteKeskmine);
        Console.WriteLine("Üle 50: " + yle50);
    }
}
