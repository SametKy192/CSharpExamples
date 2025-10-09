using System;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;
using ConsoleApp1.Logging;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Logger ve Repository oluşturuluyor
            ILogger logger = new ConsoleLogger();
            IUserRepository repository = new InMemoryUserRepository();

            // Service oluşturuluyor (Dependency Injection)
            var userService = new UserService(repository, logger);

            // Kullanıcı ekleme
            userService.AddUser(new User(1, "Ali", "ali@example.com"));
            userService.AddUser(new User(2, "Ayşe", "ayse@example.com"));
            userService.AddUser(new User(1, "Mehmet", "mehmet@example.com")); // Aynı Id => hata

            // Tüm kullanıcıları listeleme
            Console.WriteLine("\n--- Kullanıcı Listesi ---");
            foreach (var user in userService.GetAllUsers())
            {
                Console.WriteLine(user);
            }

            // Kullanıcı silme
            userService.DeleteUser(2); // Başarılı
            userService.DeleteUser(5); // Hata: yok

            // Tek kullanıcıyı bulma
            var found = userService.GetUserById(1);
            if (found != null)
                Console.WriteLine($"\nBulunan: {found}");
        }
    }
}
