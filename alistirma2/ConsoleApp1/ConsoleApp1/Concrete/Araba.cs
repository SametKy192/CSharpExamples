using ConsoleApp1.Models;
using System;

namespace ConsoleApp1.Concrete
{
    public class Araba : Arac
    {
        public override void ServisYap()
        {
            Console.WriteLine($"{Marka} için motor yağı değiştirildi.");
        }
    }
}
