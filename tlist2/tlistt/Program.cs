using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> alisverisListesi = new List<string>(); // Boş liste oluşturduk

        while (true)
        {
            Console.WriteLine("\n📌 Alışveriş Listesi Yönetimi");
            Console.WriteLine("1 - Ürün Ekle");
            Console.WriteLine("2 - Ürün Çıkar");
            Console.WriteLine("3 - Listeyi Göster");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Seçiminizi yapın: ");
            
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Eklemek istediğiniz ürünü girin: ");
                string urun = Console.ReadLine();
                alisverisListesi.Add(urun);
                Console.WriteLine($"{urun} listeye eklendi! ✅");
            }
            else if (secim == "2")
            {
                Console.Write("Çıkarmak istediğiniz ürünü girin: ");
                string urun = Console.ReadLine();
                
                if (alisverisListesi.Remove(urun))
                {
                    Console.WriteLine($"{urun} listeden çıkarıldı! ❌");
                }
                else
                {
                    Console.WriteLine("Bu ürün listede bulunamadı!");
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("\n📜 Güncel Alışveriş Listesi:");
                foreach (var urun in alisverisListesi)
                {
                    Console.WriteLine($"- {urun}");
                }
            }
            else if (secim == "4")
            {
                Console.WriteLine("Programdan çıkılıyor... 🚪");
                break;
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir seçenek girin! ❌");
            }
        }
    }
}
