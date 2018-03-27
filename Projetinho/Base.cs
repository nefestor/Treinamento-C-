using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    public class Base : iBase
    {
        private string Title { get; set; }
        public string Comments { get; set; }
        public int Id { get; set; }
        public bool Removed { get; set; }

        public void Print()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Title);
            Console.WriteLine(Comments);
        }
        public bool SetRemoved()
        {
            Removed = true;
            return true;
        }
    }
}
