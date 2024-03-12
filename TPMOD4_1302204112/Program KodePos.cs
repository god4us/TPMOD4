using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePosDictionary;

    public KodePos()
    {
        kodePosDictionary = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"},
            {"A. Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    public string GetKodePos(string kelurahan)
    {
        if (kodePosDictionary.ContainsKey(kelurahan))
        {
            return kodePosDictionary[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        // Panggil method GetKodePos untuk mendapatkan kode pos
        Console.WriteLine("Kode Pos untuk Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos untuk A. Kujangsari: " + kodePos.GetKodePos("A. Kujangsari"));
        Console.WriteLine("Kode Pos untuk Mengger: " + kodePos.GetKodePos("Mengger"));
        Console.WriteLine("Kode Pos untuk Wates: " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos untuk Cijaura: " + kodePos.GetKodePos("Cijaura"));
        Console.WriteLine("Kode Pos untuk Jatisari: " + kodePos.GetKodePos("Jatisari"));
        Console.WriteLine("Kode Pos untuk Margasari: " + kodePos.GetKodePos("Margasari"));
        Console.WriteLine("Kode Pos untuk Sekejati: " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos untuk Kebonwaru: " + kodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode Pos untuk Maleer: " + kodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode Pos untuk Samoja: " + kodePos.GetKodePos("Samoja"));


    }
}