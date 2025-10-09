using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Logging
{
    // Loglama için arayüz.
    // Burada ne yapılacağı tanımlanır, nasıl yapılacağı değil.
    public interface ILogger
    {
        void Log(string message);       // Bilgi logları
        void LogError(string message);  // Hata logları
    }
}
// ILogger sayesinde UserManager doğrudan loglama sistemine bağlı olmaz.

// Yani istersek FileLogger ya da DatabaseLogger ekleyebiliriz.
// Bu intercafeyi neden yaptık? Burada bir sorun yok gibi görünüyor ama aslında bağımlılık (dependency) oluşur bunu yapmazsak.