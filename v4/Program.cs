using System;
class Program
{
    static void Main(string[] args)
    {
        const string message = "maosh barroi kor yak soat kor  20 somoni dar yak ruz baroi  8 soat baroi kori ziyodati soatash 30 somoni ";
        Console.WriteLine(message);
        int soat,maosh;
        Console.Write("Soati kori dar yak ruz: ");
        soat = int.Parse(Console.ReadLine());
      if (soat > 8)
        {
            maosh = 20*8+(soat-8)*30;
        }
        else
        {
            maosh = 20*8;
        }
        Console.WriteLine("Maoshi shumo baroi yak ruz: " + maosh + " somoni");
    }
}