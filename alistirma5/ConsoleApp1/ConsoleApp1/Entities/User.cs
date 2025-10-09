using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class User
    {
        #region Properties
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public string Email { get; set; } = ""; //boş string
        #endregion

        #region Constructors
        public User() { }
        public User(int id, string userName, string email)
        {
            Id = id;
            UserName = userName;
            Email = email;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{Id} - {UserName} ({Email})";
        }
        #endregion
    }
}
/// <summary>
/// User sınıfı: Sistemdeki kullanıcıları temsil eder.
/// Bu sınıfta sadece kullanıcıya ait temel bilgiler bulunur.
/// (Id, UserName, Email)
/// </summary>