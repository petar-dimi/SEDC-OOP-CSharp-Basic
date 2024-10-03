using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectClasswork
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Fullname { get { return FirstName + " " + LastName; }  }

        //Default constructor
        public Human()
        {

        }

        //Custom constructor
        public Human(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //Method
        public string GetPersonStats()
        {
            return $"{Fullname} [{DateOfBirth}]";
        }



    }
}
