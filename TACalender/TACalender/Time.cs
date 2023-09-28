using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACalender
{
    public class Time
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeID { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string AMorPM { get; set; }

        public Time()
        {
            Hours = 0;
            Minutes = 0;
        }
        public Time(int hours, int minutes, string ampm)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.AMorPM = ampm;
        }

        public override string ToString()
        {
            return $"{this.Hours}:{this.Minutes} {this.AMorPM}";
        }
    }
}
