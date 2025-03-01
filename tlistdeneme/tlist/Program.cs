using System;
using System.Collections.Generic; // List<T> kullanmak için gerekli

class Program
{
    static void Main()
    {
        List<string> alisverisListesi = new List<string>(); // Boş bir liste oluşturduk

        alisverisListesi.Add("Ekmek");
        alisverisListesi.Add("Süt");
        alisverisListesi.Add("Yumurta");
        alisverisListesi.Add("Makarna");

        Console.WriteLine("📌 Alışveriş Listesi:");
        foreach (var urun in alisverisListesi)
        {
            Console.WriteLine($"- {urun}");
        }

        // Listenin boyutunu yazdıralım
        Console.WriteLine($"Liste toplam {alisverisListesi.Count} ürün içeriyor.");
    }
}
