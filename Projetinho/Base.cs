using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    public class Base : iBase
    {
        public string Title { get; set; }
        public string Comments { get; set; }

        public int Id { get; set; }
        public bool Removed { get; set; }

        public void Print()
        {
            //throw new NotImplementedException();
        }
    }
}
