using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> kitob = new Dictionary<string, string>();
        while (true)
        {
        Console.WriteLine("KItobi telefon");
            Console.WriteLine("1--ilova kardani raqam");
            Console.WriteLine("2--justujui raqam");
            Console.WriteLine("3-- tagyr dodani raqam ");
            Console.WriteLine("4-- nest kardani raqam");
            Console.WriteLine("5--namoishi hamai raqamho ");
            Console.WriteLine("--baromad");
            Console.Write("intixob kuned");
            string tanlov = Console.ReadLine();
            switch (tanlov)
            {
                case "1":
                    Console.Write("Nomi raqam va shaxsro doxil kuned ");
                    string nom = Console.ReadLine();
                    Console.Write("Raqamro doxil kuned ");
                    string raqam = Console.ReadLine();
                    if (kitob.ContainsKey(nom))
                    {
                        Console.WriteLine("Raqam alakay mavjud ast");
                    }
                    else
                    {
                        kitob.Add(nom, raqam);
                        Console.WriteLine("Raqam ilova shud");
                    }
                    break;
                    case "2":
                        Console.Write("Nomi raqamro baroi justuju ");
                       nom = Console.ReadLine();
                    if (kitob.TryGet_value(nom, out string raqam))
                    {
                        Console.WriteLine("Raqami telefon" +raqam);
                    }
                    else
                    {
                        Console.WriteLine("Raqam mavjud nist");
                    }
                    break;
                    case "3":
                    Console.Write("nomi shaxsro doxil kuned");
                    nom = Console.ReadLine();
                    if (kitob.ContainsKey(nom))
                    {
                       Console.Write("raqami navro doxil kuned");
                       raqam = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Raqam mavjud nist");
                    }
                    break;
                case "4":
                    Console.Write("Nomi shaxsro doxil kuned");
                    nom = Console.ReadLine();
                    if (kitob.Remove(nom))
                    {
                        Console.WriteLine("Raqam nest karda shud");
                    }
                    else
                    {
                        Console.WriteLine("Raqam mavjud nist");
                    }
                    break;
                    case "5":
                    if (kitob.Count == 0)
                    {
                        Console.WriteLine("kitob holi ast");
                    }
                    else 
                    { 
                    foreach (var person in kitob)
                        {
                            Console.WriteLine(person.Key + ":" + person.Value);
                        }
                    }
                    break;
                case "0":
                    Console.WriteLine("baromad");
                    return;
                default:
                    Console.WriteLine("intixobi nadorast ast");
                    break;

            }
            }

    }
}
