using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    public class Person : Base
    {
        public DateTime BirthDate { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }

        public static Person GetPerson()
        {
            return new Person
            { };
        }
    }
}
