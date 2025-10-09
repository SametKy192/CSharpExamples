using ConsoleApp1.Repositories;
using ConsoleApp1.Logging;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{// Kullanıcı işlemlerini yöneten sınıf.
    // BaseManager’dan miras alır -> try/catch + loglama merkezi
    public class UserService : BaseService
    {
        private readonly IUserRepository _repository;

        // Constructor: Repository ve Logger dışarıdan alınır (Dependency Injection)
        public UserService(IUserRepository repository, ILogger logger) : base(logger)
        {
            _repository = repository;
        }

        // Yeni kullanıcı ekler
        public void AddUser(User user)
        {
            SafeExecute(() =>
            {
                if (_repository.Add(user))
                {
                    _logger.Log($"Kullanıcı eklendi: {user.UserName}");
                }
                else
                {
                    _logger.LogError($"Kullanıcı eklenemedi (Id zaten var): {user.UserName}");
                }
            });
        }

        // Kullanıcı siler
        public void DeleteUser(int id)
        {
            SafeExecute(() =>
            {
                if (_repository.Delete(id))
                {
                    _logger.Log($"Kullanıcı silindi: {id}");
                }
                else
                {
                    _logger.LogError($"Kullanıcı bulunamadı: {id}");
                }
            });
        }

        // Id’ye göre kullanıcıyı getirir
        public User GetUserById(int id)
        {
            User result = null;
            SafeExecute(() =>
            {
                result = _repository.GetById(id);
                if (result == null)
                    _logger.LogError($"Kullanıcı bulunamadı: {id}");
            });
            return result;
        }

        // Tüm kullanıcıları getirir
        public IEnumerable<User> GetAllUsers()
        {
            IEnumerable<User> result = null;
            SafeExecute(() =>
            {
                result = _repository.GetAll();
            });
            return result;
        }
    }
}