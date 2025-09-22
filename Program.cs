using System;
using Tugas2;

public class Program
{
    public static void Main()
    {
        Pot potTanah = new Pot("Tanah Liat");
        Mawar mawarMerah = new Mawar("Mawar Merah", 32, potTanah, true);

        Console.WriteLine("Deskripsi Mawar:");
        mawarMerah.Deskripsi();
        mawarMerah.Siram();
        //mawarMerah.Siram("Kompos");
    }
}