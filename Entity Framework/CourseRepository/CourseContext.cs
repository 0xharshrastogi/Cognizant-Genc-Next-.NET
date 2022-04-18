using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Exercise1
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public CourseContext() : base("name=CourseConnectionString") { }
    }
}