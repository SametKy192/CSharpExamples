using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.Models
{
    public class Arac
    {
        public string Marka { get; set; }

        // Virtual → alt sınıflar isterse override edebilir
        public virtual void ServisYap()
        {
            Console.WriteLine($"{Marka} genel bakıma alındı.");
        }
    }
}