using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    interface iBase
    {
        Int32 Id { get; set; }
        bool Removed { get; set; }
        void Print();
    }
}
