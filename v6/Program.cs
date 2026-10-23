
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> donishjuyon = new List<string>();
        int intikhob;

        do
        {
            Console.WriteLine("Sistemai donishjuho");
            Console.WriteLine("1-- Ilova kardani donishju");
            Console.WriteLine("2--toza kardani malumotho");
            Console.WriteLine("3--justuju az rui nom");
            Console.WriteLine("4-- nishon dodani donishjuho");
            Console.WriteLine("0--baromadan");
            Console.Write("intixob kuned ");

            if (!int.TryParse(Console.ReadLine(), out intikhob))
            {
                Console.WriteLine("Intixobi nodurust!");
                continue;
            }

            switch (intikhob)
            {
                case 1:
                    Console.Write("Nomi donishjuro ilova kuned ");
                    string nom = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nom))
                    {
                        donishjuyon.Add(nom.Trim());
                        Console.WriteLine("Ilova karda shud");
                    }
                    else
                    {
                        Console.WriteLine("nom holi naeshavad");
                    }
                    break;

                case 2:
                    Console.Write("Toza karded");
                    string nomiNest = Console.ReadLine();

                    string student = donishjuyon.Find(
                        x => x.Equals(nomiNest?.Trim(),
                        StringComparison.OrdinalIgnoreCase));

                    if (student != null)
                    {
                        donishjuyon.Remove(student);
                        Console.WriteLine("donishju nest");
                    }
                    else
                    {
                        Console.WriteLine("donishju yofta nashud");
                    }
                    break;

                case 3:
                    Console.Write("Nomi donishjuro baroi justuju vorid kuned ");
                    string nomiJustiju = Console.ReadLine();

                    bool yoft = false;

                    foreach (string d in donishjuyon)
                    {
                        if (d.Contains(nomiJustiju ?? "",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Yoft shud " + d);
                            yoft = true;
                        }
                    }

                    if (!yoft)
                    {
                        Console.WriteLine("Yofta nashud");
                    }
                    break;

                case 4:
                    if (donishjuyon.Count == 0)
                    {
                        Console.WriteLine("ruixat holi ast");
                    }
                    else
                    {
                        Console.WriteLine("Ruixati donishjuho:");

                        for (int i = 0; i < donishjuyon.Count; i++)
                        {
                            Console.WriteLine(
                                (i + 1) + ". " + donishjuyon[i]);
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("baromadan");
                    break;

                default:
                    Console.WriteLine("Intixobi nodurust!");
                    break;
            }

        } while (intikhob != 0);
    }
}
