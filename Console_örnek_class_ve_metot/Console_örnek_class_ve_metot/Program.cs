using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_örnek_class_ve_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisisel_Bilgiler kslblg=new Kisisel_Bilgiler();
           
            string ad, soyad, meslek;
            Console.Write("Adinizi Giriniz:");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Girin:");
            soyad= Console.ReadLine();
            Console.Write("Mesleğinizi Giriniz:");
            meslek= Console.ReadLine();
            kslblg.kisisel_bilgi(ad,soyad , meslek);

            Console.Read();
        }
    }
}
