using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_EF_App1.DAL        //DO NOT change the namespace name
{
    public class ProjectContext : DbContext        //DO NOT change the class name
    {
        public DbSet<Project> Projects { get; set; }

        public ProjectContext() : base("ProjectDB")
        { }
    }
}