using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    // Kullanıcı verileri üzerinde temel işlemleri tanımlar (CRUD)
    public interface IUserRepository
    {
        bool Add(User user);            // Başarı durumunu döndürür
        bool Delete(int id);            // Silme başarılı mı?
        User GetById(int id);           // Tek kullanıcı döndürür
        IEnumerable<User> GetAll();     // Tüm kullanıcıları döndürür
    }
}
