using ConsoleApp1.Concrete;
using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;

class Program
{
    static void Main()
    {
        Arac araba = new Araba { Marka = "BMW" };
        Arac ucak = new Ucak { Marka = "Boeing" };

        var servis = new Servis();

        // Override
        servis.ServisYap(araba);
        servis.ServisYap(ucak);

        // Overload
        servis.ServisYap(araba, "Lastikler değiştirildi.");
        servis.ServisYap(ucak, "Yakıt deposu dolduruldu.");

        Console.ReadLine();
    }
}
