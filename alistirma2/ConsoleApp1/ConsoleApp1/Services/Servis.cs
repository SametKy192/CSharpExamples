using ConsoleApp1.Models;
using System;

namespace ConsoleApp1.Services
{
    public class Servis
    {
        // Overload 1
        public void ServisYap(Arac arac)
        {
            arac.ServisYap(); // Polymorphism burada devreye giriyor
        }

        // Overload 2
        public void ServisYap(Arac arac, string islem)
        {
            Console.WriteLine($"{arac.Marka} için özel işlem: {islem}");
        }
    }
}
