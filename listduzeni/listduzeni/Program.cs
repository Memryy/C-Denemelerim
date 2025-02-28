using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sayılar = new List<int>();
        
        sayılar.add(10);
        sayılar.add(20);
        sayılar.add(30);
        sayılar.add(40);
        sayılar.add(50);

        foreach (int sayı in sayılar)
        {
            Console.WriteLine(sayı);
        }
        
    }
}