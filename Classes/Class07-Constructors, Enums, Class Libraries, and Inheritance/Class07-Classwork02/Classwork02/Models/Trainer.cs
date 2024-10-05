using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork02.Models
{
    public class Trainer : Person
    {
        public int YearsOfExperience { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
