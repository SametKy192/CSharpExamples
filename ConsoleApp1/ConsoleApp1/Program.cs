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
        {   // Mesaj msj = new Mesaj();
            // msj.metin();
             // Console.ReadLine();

            Kisiler kisi=new Kisiler();
            // kisi.kisi_listesi("Samet Kaya");
            //kisi.kisi_listesi("Naz Sena");

            string ads;
            Console.Write("İsim Gİrin:");
            ads=Console.ReadLine();
            kisi.kisi_listesi(ads);
            Console.Read();

        }
    }
}
