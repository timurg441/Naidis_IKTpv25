using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid");
            // Console.BackgroundColor = ConsoleColor.Green;
            // Console.ForegroundColor = ConsoleColor.Blue;
            string tekst = "Tere tulemast C#-i maailma!";
            Console.WriteLine($"Oli loodud muutja tekst, mis võrdub : {tekst}");
            Console.WriteLine("Oli loodud muutja tekst, mis võrdub: {0}", tekst);
            Console.WriteLine("Mis on sinu nimi?: ");
            string nimi = Console.ReadLine();
            Console.Write("Kui vana sa oled?: ");
            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Console.Write("Arv 1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Arv 2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_Funktsioonid.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}