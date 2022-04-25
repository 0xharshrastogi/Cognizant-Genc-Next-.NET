using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_EF_App1.DAL
{
    public class CollegeContext : DbContext
    {
        public DbSet<Placement> Placements { get; set; }

        public CollegeContext() : base("CollegeContext") { }
    }
}