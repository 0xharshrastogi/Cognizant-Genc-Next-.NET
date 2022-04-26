using ASP_EF_App1.DAL;
using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ASP_EF_App1.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult ProjectDetail() => View("AddProjectDetails");

        [HttpPost]
        public ActionResult ProjectDetail(Project project)
        {
            project.ProjectId = 1;
            using (var context = new ProjectContext())
            {
                context.Projects.Add(project);
                context.SaveChanges();
            }

            return View("ViewProjectDetails", project);
        }
    }
}