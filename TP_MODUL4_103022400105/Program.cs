using System;
using TP_MODUL4_103022400105;

class Program
{
    static void Main(string[] args)
    {
        // TABLE DRIVEN

        // Membuat objek dari class KodePos
        KodePos kp = new KodePos();

        Console.Write("Masukkan Kelurahan: ");
        string kel = Console.ReadLine();

        int kode = kp.getKodePos(kel);

        Console.WriteLine("Kode Pos: " + kode);
        // TABLE DRIVEN


        // SPACING
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        // SPACING


        // STATE BASED

        // Membuat objek dari class DoorMachine
        DoorMachine pintu = new DoorMachine();

        // Loop agar program terus berjalan sampai user memilih keluar
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Masukkan perintah:");
            Console.WriteLine("1. Buka Pintu");
            Console.WriteLine("2. Kunci Pintu");
            Console.WriteLine("3. Keluar");

            string input = Console.ReadLine();

            if (input == "1")
            {
                pintu.BukaPintu();
            }
            else if (input == "2")
            {
                pintu.KunciPintu();
            }
            else if (input == "3")
            {
                break;
            }
        }
        // STATE BASED
    }
}