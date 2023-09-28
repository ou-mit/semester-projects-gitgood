using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACalender
{
    public class DB:DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<SectionTA> SectionTAs { get; set; }
        public DbSet<TA> TAs { get; set; }
        public DbSet<TATask> TATasks { get; set; }
        public DbSet<Task> Tasks { get; set; }  
        public DbSet<Request> Requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlite("Data Source=TACalender.db");// Data Source=path to the database file
        }
    }
}
