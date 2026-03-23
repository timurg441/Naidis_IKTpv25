using System;

class Start
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== VALI ÜLESANNE ===");
            Console.WriteLine("1 - Kalorite kalkulaator");
            Console.WriteLine("2 - Maakonnad ja pealinnad");
            Console.WriteLine("3 - Õpilased ja hinded");
            Console.WriteLine("4 - Filmid");
            Console.WriteLine("5 - Statistika");
            Console.WriteLine("6 - Lemmikloomad");
            Console.WriteLine("7 - Valuutakalkulaator");
            Console.WriteLine("0 - Välju");
            Console.Write("\nSinu valik: ");

            string valik = Console.ReadLine();
            Console.Clear();

            switch (valik)
            {
                case "1":
                    Ulesanne1.Run();
                    break;
                case "2":
                    Ulesanne2.Run();
                    break;
                case "3":
                    Ulesanne3.Run();
                    break;
                case "4":
                    Ulesanne4.Run();
                    break;
                case "5":
                    Ulesanne5.Run();
                    break;
                case "6":
                    Ulesanne6.Run();
                    break;
                case "7":
                    Ulesanne7.Run();
                    break;
                case "0":
                    Console.WriteLine("Head aega!");
                    return;
                default:
                    Console.WriteLine("Vale valik! Palun vali 0-7");
                    break;
            }

            Console.WriteLine("\n=================================");
            Console.WriteLine("Vajuta Enter, et naasta menüüsse...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}