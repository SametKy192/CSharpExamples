using ConsoleApp1.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    // Ortak yöneticilerin temel sınıfı.
    // Burada try/catch ve loglama merkezi olarak yapılır.
    public abstract class BaseService
    {
        protected readonly ILogger _logger; //Her manager, hangi loglama sistemini kullanıyorsa onu buraya alır.
        //Bu değişken sadece constructor içinde set edilebilir, sonradan değiştirilemez.

        // Constructor: Her manager, hangi logger kullanılacaksa onu alır.
        protected BaseService(ILogger logger)
        {
            _logger = logger;
        }

        // Ortak güvenli çalışma metodu.
        // Hata olursa yakalar ve loglar.
        protected void SafeExecute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hata: {ex.Message}");
            }
        }
    }
}