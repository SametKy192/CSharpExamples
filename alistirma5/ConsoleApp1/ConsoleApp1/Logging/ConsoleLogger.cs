using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Logging
{   // Logları konsola yazan sınıf.
    public class ConsoleLogger : ILogger //ILogger’ı implemente ediyor.
    {
        public void Log(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
        }
    }
}