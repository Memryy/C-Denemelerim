using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Aldığınız notu giriniz:");
        int not = Convert.ToInt32(Console.ReadLine());

        if (not >= 85)
        {
            Console.WriteLine("Sınavda Yüksek Derece Yaptınız");
        }
        else if (not >= 50)
        {
            Console.WriteLine("Sınavdan Geçtiniz");
        }
        else
        {
            Console.WriteLine("Sınavdan Kaldınız");
        }
    }
}
