using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pcparcalari = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        pcparcalari.Add("Anakart", 100);
        pcparcalari.Add("Ram", 75);
        pcparcalari.Add("Monitor", 50);
        pcparcalari.Add("İşlemci", 30);
        pcparcalari.Add("SSD", 15);

        Console.Write("Bilgisayar parçalarını giriniz: ");
        string parca = Console.ReadLine();

        if (pcparcalari.TryGetValue(parca, out int fiyat))
        {
            Console.WriteLine($"{parca} parçasının fiyatı: {fiyat}");
        }
        else
        {
            Console.WriteLine("Bilgisayar parçası bulunamadı.");
        }
    }
}
