using System;

class start_page
{
    static void Main()
    {
        Console.WriteLine("Vali ülesanne (1-7):");

        int valik = int.Parse(Console.ReadLine());

        if (valik == 1)
        {
            Osa5_Ulesanned.Ulesanne1();
        }
        else if (valik == 2)
        {
            Osa5_Ulesanned.Ulesanne2();
        }
        else if (valik == 3)
        {
            Osa5_Ulesanned.Ulesanne3();
        }
        else if (valik == 4)
        {
            Osa5_Ulesanned.Ulesanne4();
        }
        else if (valik == 5)
        {
            Osa5_Ulesanned.Ulesanne5();
        }
        else if (valik == 6)
        {
            Osa5_Ulesanned.Ulesanne6();
        }
        else if (valik == 7)
        {
            Osa5_Ulesanned.Ulesanne7();
        }
        else
        {
            Console.WriteLine("Vale valik");
        }
    }
}