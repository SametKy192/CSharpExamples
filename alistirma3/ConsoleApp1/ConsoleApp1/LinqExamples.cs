using System;
using System.Linq;

public class LinqExamples
{
    public void CiftSayilariBul()
    {
        int[] sayilar = { 1, 2, 3, 4, 5, 6 };
        var ciftler = sayilar.Where(s => s % 2 == 0);

        Console.WriteLine("Çift Sayılar:");
        foreach (var sayi in ciftler)
        {
            Console.WriteLine(sayi);
        }
    }

    public void KareleriAl()
    {
        int[] sayilar = { 1, 2, 3 };
        var kareler = sayilar.Select(s => s * s);

        Console.WriteLine("\nKareleri:");
        foreach (var k in kareler)
        {
            Console.WriteLine(k);
        }
    }
}
