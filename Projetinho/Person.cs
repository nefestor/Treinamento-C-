using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    public class Person : Base
    {
        private DateTime BirthDate { get; set; }
        private Person FatherName { get; set; }
        private string Email { get; set; }

        public Person(DateTime birth, Person father, string email)
        {
            BirthDate = birth;
            FatherName = father;
            Email = email;
        }
        //public static void getPerson() => Person;
    }
}
