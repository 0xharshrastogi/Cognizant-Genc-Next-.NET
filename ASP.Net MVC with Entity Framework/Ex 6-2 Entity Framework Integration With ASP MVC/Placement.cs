//THIS IS FOR REFERENCE ONLY. YOU ARE NOT REQUIRED TO MAKE ANY CHANGES HERE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_EF_App1.Models
{
    public class Placement
    {
        public int PlacementId { get; set; }
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public String Company { get; set; }
        public String PlacementYear { get; set; }
    }
}