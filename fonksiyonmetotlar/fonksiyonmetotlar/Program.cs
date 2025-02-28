using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Adınızı giriniz:");
            string ad = Console.ReadLine();

            Console.WriteLine("Aldığınız notu giriniz:");
            int not;

            while (!int.TryParse(Console.ReadLine(), out not))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz:");
            }

            string sonuc = NotDegerlendir(not);
            Console.WriteLine($"{ad}, {sonuc}");

            // Kullanıcının doğru giriş yapmasını bekleyen do-while döngüsü
            string devam;
            do
            {
                Console.WriteLine("Devam etmek ister misiniz? (E/H)");
                devam = Console.ReadLine().ToLower();

                if (devam != "e" && devam != "h")
                {
                    Console.WriteLine("Lütfen sadece 'E' (Evet) veya 'H' (Hayır) giriniz!");
                }

            } while (devam != "e" && devam != "h"); // Hatalı giriş yaparsa tekrar sor

            if (devam == "h")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }
        }
    }

    static string NotDegerlendir(int not)
    {
        if (not >= 85)
        {
            return "Sınavda Yüksek Derece Yaptınız Tebrikler! 🎉";
        }
        else if (not >= 50)
        {
            return "Sınavda İyi Derece Yaptınız ✅";
        }
        else
        {
            return "Sınavda Kaldınız ❌";
        }
    }
}
