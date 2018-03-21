using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Project : Base
    {

        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime RealEndTime { get; set; }
        public Person Responsible { get; set; }

        public Project(string code, DateTime startDate, DateTime estimatedEndDate, DateTime<nullable> realEndTime, Person responsible)
        {
            Code = code;
            StartDate = startDate;
            EstimatedEndDate = estimatedEndDate;
            RealEndTime = realEndTime;
            Responsible = responsible;
        }

        public static void GetProject(){}
        public bool MarkFinished() => true;
    }
}

