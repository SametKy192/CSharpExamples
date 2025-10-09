using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    // _users: Kullanıcıların tutulduğu private liste.
    public class InMemoryUserRepository : IUserRepository   // Bellekte kullanıcıları tutan repository implementasyonu
    {
        private readonly List<User> _users = new List<User>();   // Kullanıcıların tutulduğu private liste

        public bool Add(User user)
        {
            // Aynı Id'ye sahip kullanıcı varsa ekleme
            if (_users.Any(u => u.Id == user.Id))
            {
                return false;
            }

            _users.Add(user);
            return true;
        }

        public bool Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return false;
            }

            _users.Remove(user);
            return true;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
