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
class DoorMachine
{
    public enum State { Terkunci, Terbuka, Keluar };

    
}

class Program
{
    static void Main()
    {
        //table driven
        Console.Write("Masukkan nama kelurahan: ");
        string input = Console.ReadLine();

        Enum.TryParse(input, out KodePos.Kelurahan kelurahan);

        int kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos untuk {kelurahan}: {kodePos}");

        //state based
        DoorMachine.State state = DoorMachine.State.Terkunci;
        string[] screenName = { "Terkunci", "Terbuka", "Exit" };
        while (state != DoorMachine.State.Keluar)
        {
            Console.WriteLine(screenName[(int)state] + " Screen");
            Console.Write("Enter Command: ");

            string command = Console.ReadLine();

            switch (state) 
            {
                case DoorMachine.State.Terkunci:
                    if (command == "BukaPintu")
                    {
                        state = DoorMachine.State.Terbuka;
                    } else if (command == "KunciPintu")
                    {
                        state = DoorMachine.State.Terkunci;
                    } else if (command == "Keluar")
                    {
                        state = DoorMachine.State.Keluar;
                    }
                    break;
                case DoorMachine.State.Terbuka:
                    if (command == "BukaPintu")
                    {
                        state = DoorMachine.State.Terbuka;
                    }
                    else if (command == "KunciPintu")
                    {
                        state = DoorMachine.State.Terkunci;
                    }
                    else if (command == "Keluar")
                    {
                        state = DoorMachine.State.Keluar;
                    }
                    break;
            }
        }
        Console.WriteLine(screenName[(int)state] + " Screen");
    }
}
