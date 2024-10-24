using Homework_10.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            UserRole = role;
        }
    }
}
