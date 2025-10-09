using ConsoleApp1.Models;
using System;

namespace ConsoleApp1.Concrete
{
    public class Ucak : Arac
    {
        public override void ServisYap()
        {
            Console.WriteLine($"{Marka} için uçuş sistemleri kontrol edildi.");
        }
    }
}
