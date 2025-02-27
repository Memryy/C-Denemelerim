using System;

class Program
{
    static void Main ()
    {
        Console.WriteLine("Aldığınız notu giriniz");
        int not = Convert.ToInt32(Console.ReadLine());

        if (not <= 50)
        {
            Console.WriteLine("Sınavdan Kaldınız");
            return;
        }
        if (not >= 80)
        {
            Console.WriteLine("Sınavda Yüksek Derece Yaptınız");
            return;

        }
        if (not >= 51)
        {
            Console.WriteLine("Sınavdan Geçtiniz");
            return;
        }
        
    }

}

