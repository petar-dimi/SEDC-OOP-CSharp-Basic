using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork02.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstname, string lastname, string email,string phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            
        }
        public Person()
        {
            

        }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} - email: {Email} phone number: {PhoneNumber}";
        }

    }
}
