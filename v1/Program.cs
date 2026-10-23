class Program
{
    static void Main()
    {
        const string TITLE = "Sistemai ba qaydgirri donishju";

        string nom, nasab, ihtisos;
        int sinnuSol;

        Console.WriteLine(TITLE);

        Console.Write("Nomi donishju= ");
        nom = Console.ReadLine() ?? "";

        Console.Write("Nasabi donishju: ");
        nasab = Console.ReadLine() ?? "";

        Console.Write("sinu solro vorid kuned: ");
        sinnuSol = Convert.ToInt32(Console.ReadLine());

        Console.Write("ixtisosro vorid kuned: ");
        ihtisos = Console.ReadLine() ?? "";

        // Намоиши маълумот
        Console.WriteLine("Malumoti donishju");
        Console.WriteLine("Nom: " + nom);
        Console.WriteLine("Nasab: " + nasab);
        Console.WriteLine("Sinu sol: " + sinnuSol);
        Console.WriteLine("Ixtisos: " + ihtisos);
    }
}
