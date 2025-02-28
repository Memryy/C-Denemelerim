using System;

class Program
{
    static void Main()
    {
        // 5 öğrencilik diziler tanımlıyoruz
        string[] isimler = new string[5];
        int[] notlar = new int[5];

        // Öğrenci bilgilerini almak için for döngüsü
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Öğrenci {i + 1} adını giriniz: ");
            isimler[i] = Console.ReadLine();

            Console.Write($"Öğrenci {isimler[i]} notunu giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out notlar[i]))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            }
        }

        // Öğrenci listesini ekrana yazdıralım
        Console.WriteLine("\n📌 Öğrenci Not Listesi:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{isimler[i]} - Notu: {notlar[i]}");
        }

        // En yüksek ve en düşük notu bulalım
        int enYuksek = notlar[0];
        int enDusuk = notlar[0];

        for (int i = 1; i < 5; i++)
        {
            if (notlar[i] > enYuksek)
                enYuksek = notlar[i];

            if (notlar[i] < enDusuk)
                enDusuk = notlar[i];
        }

        Console.WriteLine($"\n🏆 En yüksek not: {enYuksek}");
        Console.WriteLine($"❌ En düşük not: {enDusuk}");
    }
}
