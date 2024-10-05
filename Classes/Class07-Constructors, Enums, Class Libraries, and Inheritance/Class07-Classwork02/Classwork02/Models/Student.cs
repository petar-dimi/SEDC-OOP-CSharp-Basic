using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork02.Models
{
    public class Student : Person
    {
        public string Group { get; set; }
        public Student(string firstname,string lastname,string email,string phoneNumber,string group) : base(firstname, lastname, email, phoneNumber)
        {
            Group = group;
            
        }
    }
}
