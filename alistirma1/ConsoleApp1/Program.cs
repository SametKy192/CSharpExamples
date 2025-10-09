using ConsoleApp1.Concrete;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba araba= new Araba();
            // Ucak ucak= new Ucak();

            //Araba araba = new Araba { Marka = "BMW" };
            //Ucak ucak = new Ucak { Marka = "Boeing" }; Abstract üzerinden 

            // Interface üzerinden referans
            //IHareketEdebilir araba = new Araba { Marka = "BMW" };
            //IHareketEdebilir ucak = new Ucak { Marka = "Boeing" };

            //araba.Calistir();
            //araba.HareketEt();
            //ucak.Calistir();
            //ucak.HareketEt(); 
            //Console.ReadLine();



            // DIP: Interface'e bağımlılık
            List<IHareketEdebilir> araclar = new List<IHareketEdebilir>
        {
            new Araba { Marka = "BMW" },
            new Ucak { Marka = "Boeing" },
            new Gemi { Marka = "Titanic" }
        };

            // Polymorphism: Her araç kendi HareketEt davranışını çalıştırır
            foreach (var arac in araclar)
            {
                arac.HareketEt();
            }

            // Interface Segregation: sadece araba ses çıkarabilir
            ISesCikartabilir araba = new Araba { Marka = "Mercedes" };
            ISesCikartabilir gemi = new Gemi { Marka = "Titanic" };
            gemi.SesCikar();
            araba.SesCikar();

            Console.ReadLine();

        }  
    }
}