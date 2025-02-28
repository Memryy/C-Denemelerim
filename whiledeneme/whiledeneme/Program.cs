using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Adınızı giriniz");
            string ad = Console.ReadLine();

            Console.WriteLine("Aldığınız notu giriniz");
            int not;

            while (!int.TryParse(Console.ReadLine(), out not))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz");
            }

            if (not >= 85)
            {
                Console.WriteLine($"{ad}, Sınavda Yüksek Derece Yaptınız");
            }
            else if (not >=50)
            {
                Console.WriteLine($"{ad}, Sınavdan Geçtiniz Tebrikler");
            }
            else
            {
                Console.WriteLine($"{ad}, Maalesef Kaldınız");
            }

            Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            string devam = Console.ReadLine().ToLower();

            if (devam == "h")
            {
                Console.WriteLine("Programdan Çıkılıyor...");
                break;
            }
        }
    }


}