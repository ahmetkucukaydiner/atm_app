using atm_app.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace atm_app.Database
{
    internal class DB
    {
        private static List<User> _users;

        static DB()
        {
            _users = new List<User>()
            {
                new User {Id = 1, CustomerCode= 100, NameSurname = "Murat Küçük", Password = "1234", Balance = 5000},
                new User {Id = 2, CustomerCode= 200, NameSurname = "Meltem Küçük", Password = "4567", Balance = 7500},
                new User {Id = 3, CustomerCode= 300, NameSurname = "Ayfer Küçük", Password = "2345", Balance = 10000},
                new User {Id = 4, CustomerCode= 400, NameSurname = "Gülşah Küçük", Password = "3456", Balance = 6000},
            };
        }

        public List<User> GetUsers()
        {
            return _users;
        }
        
        public User GetCustomerCode(int customerCode)
        {
            return _users.Find(x=> x.CustomerCode == customerCode);
        }
        public User GetBalance(int balance)
        {
            return _users.Find(x => x.Balance == balance);
        }

    }
}
