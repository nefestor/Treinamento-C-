﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projetinho;

namespace Activity.ConUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Project p = new Project();
            p.Id = 10;
            Console.WriteLine(p.MarkFinished());
            Console.ReadKey();
            
        }
    }
}