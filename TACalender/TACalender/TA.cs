using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACalender
{
    public class TA:Educator
    {
        public List<SectionTA> SectionTAList { get; set; }
        public List<TATask> TATask { get; set; }
        public List<Request> Requests { get; set; }
    }
}
