using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TACalender
{
    public class Instructor : Educator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstructorID { get; set; }
        public List<Section> sections;

        public void setInstructorID()
        {
            this.InstructorID = base.EduID;
        }
    }
}
