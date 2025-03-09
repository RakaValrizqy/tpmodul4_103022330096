using System;
using System.Collections.Generic;
using static KodePos;

class KodePos
{
    public enum Kelurahan { Batunuggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }

    public static int GetKodePos(Kelurahan kelurahan)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        return kodePos[(int)kelurahan];
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string input = Console.ReadLine();

        Enum.TryParse(input, out KodePos.Kelurahan kelurahan);

        int kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos untuk {kelurahan}: {kodePos}");
    }
}
