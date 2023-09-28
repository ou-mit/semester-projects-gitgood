using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACalender
{
    public class TATask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TATaskID { get; set; }
        public int EduID { get; set; }
        public int TID { get; set; }
        public DateTime date { get; set; }
        public bool Cancel { get; set; }
    }
}
