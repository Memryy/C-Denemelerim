using System;

class Program
{
    static void Main()
    {
        string [] alisverislistesi = {"Elma", "Yumurta", "Domates", "Ekmek", "Tavuk", "Tereyağı", "Kola"};

        Console.WriteLine("Alışveriş Listesi");
        foreach (var urun in alisverislistesi)
        {
            Console.WriteLine($"-{urun}");
        }        
    }
}