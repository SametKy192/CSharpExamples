using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen 10 basamaklı bir telefon numarası girin (0 ile 9 arasında): ");

            // Kullanıcıdan her bir basamağı almak için 10 kez döngü oluşturulur.
            string phoneNumber = "(";
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Basamak {0}: ", i + 1);
                phoneNumber += Console.ReadLine();

                // Parantez ve tireyi doğru konumlarına yerleştirir.
                if (i == 2)
                    phoneNumber += ") ";
                else if (i == 5)
                    phoneNumber += "-";
            }

            Console.WriteLine("Oluşturulan telefon numarası: " + phoneNumber);
            Console.ReadLine();
        }
    }
}
