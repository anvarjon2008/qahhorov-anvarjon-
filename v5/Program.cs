
using System;

class Program
{
    static void Main(string[] args)
    {
        const string message = "ruixati donishjuho!";
        Console.WriteLine(message);

        int donishjuho = 5;
        int ball, guzasht = 0, galtid = 0, xato = 0;

        for (int i = 0; i < donishjuho; i++)
        {
            Console.WriteLine("Nomi donishju:");
            string name = Console.ReadLine();

            Console.WriteLine("Balli donishju:");
            ball = int.Parse(Console.ReadLine());

            if (ball < 0 || ball > 100)
            {
                Console.WriteLine("Xato vorid shud!");
                xato++;
                continue;
            }

            if (ball >= 90)
            {
                Console.WriteLine(name + " A - A'lo");
                guzasht++;
            }
            else if (ball >= 80)
            {
                Console.WriteLine(name + " B - Xub");
                guzasht++;
            }
            else if (ball >= 70)
            {
                Console.WriteLine(name + " C - Qanoatbakhsh");
                guzasht++;
            }
            else if (ball >= 60)
            {
                Console.WriteLine(name + " D - Pas");
                guzasht++;
            }
            else
            {
                Console.WriteLine(name + " - Galtid F");
                galtid++;
            }
        }

        Console.WriteLine("Guzasht: " + guzasht + " donishju");
        Console.WriteLine("Galtid: " + galtid + " donishju");
        Console.WriteLine("Xato vorid shud: " + xato + " donishju");
    }
}
