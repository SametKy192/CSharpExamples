using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blg;
            Console.WriteLine("Ad - Soyad:");
            blg = Console.ReadLine();
            ogrenci ogr =new ogrenci(blg);




            //  ogrenci ogr = new ogrenci("Samet Kaya");
            Console.Read();  
        }
    }
}
