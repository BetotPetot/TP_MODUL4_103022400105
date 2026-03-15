using System;
using TP_MODUL4_103022400105;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.Write("Masukkan Kelurahan: ");
        string kel = Console.ReadLine();

        int kode = kp.getKodePos(kel);

        Console.WriteLine("Kode Pos: " + kode);
    }
}