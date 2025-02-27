using System;

class Program
{
    static void Main()
    {
        Console.Write("Adınızı Giriniz: ");
        string İsim = Console.ReadLine();

        Console.Write("Yaşınızı Giriniz: ");
        int Yas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Favori Oyununuzu Giriniz: ");
        string Oyun = Console.ReadLine();




        Console.WriteLine("\n--- Kullanıcı Bilgileri/Deneyimleri ---");  
        Console.WriteLine("Adı: " + İsim);
        Console.WriteLine("Yaşı: " + Yas);
        Console.WriteLine("Favori Oyunun İsmi: " + Oyun);

    }
}
