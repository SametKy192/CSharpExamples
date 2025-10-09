using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Concrete
{
    // Araba, Arac sınıfından türedi (Inheritance) ve 2 interface’i implement etti
    public class Araba : Arac, IHareketEdebilir, ISesCikartabilir
    {
        public override void HareketEt()// Hareket etme davranışını araba için özelleşti (Polymorphism)
        {
            Console.WriteLine($"{Marka} yolda gidiyor.");
        }

        public void SesCikar()  // Arabaya özel yetenek: korna çalmak
        {
            Console.WriteLine($"{Marka} korna çaldı!");
        }
    }
}