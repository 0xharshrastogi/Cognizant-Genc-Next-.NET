//THIS IS FOR REFERENCE ONLY. YOU ARE NOT REQUIRED TO MAKE ANY CHANGES HERE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_EF_App1.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public String ProjectName { get; set; }
        public String Platform { get; set; }
        public String Client { get; set; }
        public int Duration { get; set; }
    }
}