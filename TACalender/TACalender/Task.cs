using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACalender
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TID { get; set; }
        public Time StartTime { get; set; }
        public Time EndTime { get; set; }
        public string Weekday {get; set;}
        public List<TATask> TATask { get; set; }
    }
}
