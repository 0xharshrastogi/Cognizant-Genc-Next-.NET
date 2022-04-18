using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentManagement
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public CollegeContext() : base("name=StudentConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { }
    }
}
