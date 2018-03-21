using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    public class Project : Base
    {
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime RealEndTime { get; set; }
        public Person Responsible { get; set; }
        public static Project GetProject() {
            return new Project
            {

            };
        }
        public bool MarkFinished()
        {
            RealEndTime = DateTime.Now;
            Console.WriteLine(RealEndTime);
            return true;
        }
    }
}
