
using System;
using System.Collections.Generic;

class Student
{
    // Майдонҳо тавассути Property
    public string Nom { get; set; }
    public string Nasab { get; set; }
    public int SinnuSol { get; set; }
    public List<int> Bahohо { get; set; }

    // Конструктор
    public Student(string nom, string nasab, int sinnuSol)
    {
        Nom = nom;
        Nasab = nasab;
        SinnuSol = sinnuSol;
        Bahohо = new List<int>();
    }

    // Метод барои илова кардани баҳо
    public void IlovaBaho(int baho)
    {
        if (baho >= 0 && baho <= 100)
        {
            Bahohо.Add(baho);
            Console.WriteLine("Baho ilova shud!");
        }
        else
        {
            Console.WriteLine("Baho bояд аz 0 то 100 boshad!");
        }
    }

    // Метод барои ҳисоб кардани баҳои миёна
    public double BahoiMiyona()
    {
        if (Bahohо.Count == 0)
            return 0;

        double summa = 0;

        foreach (int baho in Bahohо)
        {
            summa += baho;
        }

        return summa / Bahohо.Count;
    }

    // Метод барои нишон додани маълумот
    public void Namoish()
    {
        Console.WriteLine("Malumoti donishju");
        Console.WriteLine("Nom: " + Nom);
        Console.WriteLine("Nasab: " + Nasab);
        Console.WriteLine("Sinu sol: " + SinnuSol);
        Console.WriteLine("Baho: " + string.Join(", ", Bahohо));
        Console.WriteLine("Bahoi  miyona: " + BahoiMiyona().ToString("F2"));
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nomro vorid kuned: ");
        string nom = Console.ReadLine() ?? "";

        Console.Write("Nasabro vorid kuned: ");
        string nasab = Console.ReadLine() ?? "";

        Console.Write("Sinu solro vorid kuned: ");
        int sinnuSol = int.Parse(Console.ReadLine()!);

        Student student = new Student(nom, nasab, sinnuSol);

        Console.Write("Shumorai bahohoro vorid kuned: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Bahoi {i + 1}-umro vorid kuned: ");
            int baho = int.Parse(Console.ReadLine()!);
            student.IlovaBaho(baho);
        }

        student.Namoish();

        Console.ReadKey();
    }
}
