using System;
using System.Collections.Generic;
using System.Text;

namespace atm_app.Entity
{
    internal class User
    {
        public int Id { get; set; }
        public int CustomerCode { get; set; }
        public string NameSurname { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
    }
}
