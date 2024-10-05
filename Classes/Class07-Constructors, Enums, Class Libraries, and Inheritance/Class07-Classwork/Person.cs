using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_Classwork
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private long AccountNumber { get; set; }

        public Person()
        {
            AccountNumber = 7;
        }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
            AccountNumber = 8;
            
        }
        public void Talk(string text)
        {
            Console.WriteLine($"Human{Name} is saying {text}");
        }

    }
}
