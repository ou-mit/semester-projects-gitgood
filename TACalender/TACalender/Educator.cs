using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACalender
{
    public abstract class Educator
    {
        public int EduID { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string PrefName { get; set; }
        public string PersonalEmail { get; set; }
        public string OUEmail { get; set; } 
        public int NumSection { get; set; }

    }
}
