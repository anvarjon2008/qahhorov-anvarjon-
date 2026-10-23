using System;
    class Program
{
    static void Main(string[] args)
    {
        const string tittle= "Kalkulyator";
        double a, b;
        char operation;
        Console.WriteLine(tittle);
        Console.Write("qimqti a=");
        a=double.Parse(Console.ReadLine());
        Console.Write("qimqti b=");
        b = double.Parse(Console.ReadLine());
        Console.Write("amalro intixob kun (+, -, *,/,%): ");
        operation = char.Parse(Console.ReadLine());
        switch (operation)
        {
            case '+':
                Console.WriteLine($"natija: {a + b}");
                break;
            case '-':
                Console.WriteLine($"natija: {a - b}");
                break;
            case '*':
                Console.WriteLine($"natija: {a * b}");
                break;
            case '/':
                if (b != 0)
                    Console.WriteLine($"natija: {a / b}");
                else
                    Console.WriteLine("Xatogi 0 vujud nadorad.");
                break;
            case '%':
                if (b != 0)
                    Console.WriteLine($"natija: {a % b}");
                else
                    Console.WriteLine("Xatogi 0 vujud nadorad.");
                break;
            default:
                Console.WriteLine("Xatogi 0 vujud nadorad.");
                break;
        }
    }
}


