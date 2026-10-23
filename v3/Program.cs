
using System;

class Program
{
    static void Main()
    {
        const int MAX_BALL = 100;
        int ball;
        string natija;

        Console.WriteLine("sistemai hisobkuni ");

        Console.Write("bahoi donishju=: ");
        ball = Convert.ToInt32(Console.ReadLine());
        if (ball < 0 || ball > MAX_BALL)
        {
            Console.WriteLine("xato baho az 0 to 100 qabul meshavad .");
            return;
        }
        else if (ball >= 90)
        {
            natija = "alo";
        }
        else if (ball >= 75)
        {
            natija = "xub";
        }
        else if (ball >= 50)
        {
            natija = "qanoatbaxsh";
        }
        else
        {
            natija = "nokom";
        }
        switch (natija)
        {
            case "alo":
                Console.WriteLine("natija alo");
                break;

            case "xub":
                Console.WriteLine("natija xub");
                break;

            case "qanoatbaxsh":
                Console.WriteLine(" natija qanoatbaxsh.");
                break;

            case "nokom":
                Console.WriteLine("natija nokom.shumo ba kridit galtidet");
                break;
        }

        Console.WriteLine("bahoi shumo: " + ball);
    }
}
