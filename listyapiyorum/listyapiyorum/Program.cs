using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Öğrenci isimlerini ve notlarını saklamak için listeler
        List<string> isimler = new List<string>();
        List<int> notlar = new List<int>();

        // 5 öğrencinin isimlerini ve notlarını alalım
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Öğrenci {i + 1} adını giriniz: ");
            isimler.Add(Console.ReadLine());  // Öğrencinin adını listeye ekliyoruz

            Console.Write($"Öğrenci {isimler[i]} notunu giriniz: ");
            int not;
            while (!int.TryParse(Console.ReadLine(), out not)) // Geçerli bir not girilmesini sağlıyoruz
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
            notlar.Add(not);  // Öğrencinin notunu listeye ekliyoruz
        }

        // Öğrencilerin isimlerini ve notlarını yazdıralım
        Console.WriteLine("\n📋 Öğrenci Not Listesi:");
        for (int i = 0; i < isimler.Count; i++)  // Öğrenci sayısına göre döngü
        {
            Console.WriteLine($"{isimler[i]} - Notu: {notlar[i]}");
        }

        // En yüksek notu bulalım
        int enYuksekNot = notlar[0]; // İlk notu başlangıç olarak kabul edelim
        string enYuksekNotAlani = isimler[0];

        for (int i = 1; i < notlar.Count; i++)
        {
            if (notlar[i] > enYuksekNot)
            {
                enYuksekNot = notlar[i];
                enYuksekNotAlani = isimler[i];
            }
        }

        Console.WriteLine($"\n🏆 En yüksek not: {enYuksekNot} - Öğrenci: {enYuksekNotAlani}");
    }
}
