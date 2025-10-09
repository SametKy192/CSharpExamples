using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Concrete
{
    public class Ucak : Arac, IHareketEdebilir
    {
        public override void HareketEt() // Uçak, Arac sınıfından türedi ve sadece hareket etme interface’ini aldı
        {
            Console.WriteLine($"{Marka} havada uçuyor.");
        }
    }
}