using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kimlik kml=new kimlik();
            kml.AD = "Samet";
            kml.SOYAD = "Kaya";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.YAS);
            Console.Read();
        }
    }
}
