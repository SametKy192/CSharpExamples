using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    public class Gemi : Arac, IHareketEdebilir,ISesCikartabilir
    {
        public override void HareketEt()  // Gemi, hem hareket edebilir hem de ses çıkarabilir
        {
            Console.WriteLine($"{Marka} denizde yüzüyor.");
        }
        public void SesCikar()
        {
            Console.WriteLine($"{Marka} korna çaldı!");
        }
    }
}