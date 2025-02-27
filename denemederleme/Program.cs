using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0)
        {
            Console.WriteLine("Sayı Pozitiftir");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Sayı Negatiftir");
        }
        else
        {
            Console.WriteLine("Sayıyı Sıfır Girdiniz");
        }
    }
}