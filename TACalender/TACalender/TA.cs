﻿using System;
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

        public TA ()
        {
            
        }

        public TA (string fname, string mname, string lname, string prefname, string personemail, string ouemail, int numsections)
        {
            this.FName = fname;
            this.MName = mname;
            this.LName = lname;
            this.PrefName = prefname;
            this.PersonalEmail = personemail;
            this.OUEmail = ouemail;
            this.NumSection = numsections;
        }

        public override string ToString()
        {
            if (this.PrefName.Length > 0)
            {
                return $"{PrefName} {LName}";
            }
            else
            {
                return $"{FName} {LName}";
            }
        }
    }
}
