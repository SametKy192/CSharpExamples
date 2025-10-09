using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Arac // Soyut (abstract) temel sınıf: Ortak özellikler burada
    {
        private string _marka;  // Encapsulation

        public string Marka
        {
            get // Marka property: get/set ile kontrollü erişim
            {
                return _marka;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Marka boş olamaz!");
                }
                _marka = value;
            }
        }

        public void Calistir()  // Ortak davranış: Her araç çalıştırılabilir
        {
            Console.WriteLine($"{Marka} çalıştırıldı.");
        }

        public abstract void HareketEt(); // Alt sınıflar zorunlu dolduracak
    }
}
