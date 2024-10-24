using Homework_10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class Admin : User
    {
        public Admin(string username, string password)
            : base(username, password, Role.Admin) { }

       
        public void AddUser(List<User> users, User newUser)
        {
            users.Add(newUser);
            Console.WriteLine($"{newUser.Username} has been added as a {newUser.UserRole}.");
        }

        
        public void RemoveUser(List<User> users, string username)
        {
            User userToRemove = users.Find(u => u.Username == username);
            if (userToRemove != null && userToRemove != this)
            {
                users.Remove(userToRemove);
                Console.WriteLine($"{userToRemove.Username} has been removed.");
            }
            else if (userToRemove == this)
            {
                Console.WriteLine("You cannot remove yourself.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
