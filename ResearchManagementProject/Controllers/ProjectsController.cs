using PagedList;
using ResearchManagementProject.Bussiness_Layer.Repository;
using ResearchManagementProject.Models.ViewModels;
using ResearchManagementProject.Models.ViewModels.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchManagementProject.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        //public ActionResult Index()
        //{
        //    using (var DB = new Research_ManagementEntities())
        //    {
        //        var projects = DB.Projects.ToList();
        //        return View(projects);
        //    }    
        //}

        public ActionResult Index()
        {


            var ProjectRepository = new ProjectRepository();
            var StaffRepository = new StaffRepository();

            var model = new BrowseProjectsViewModel();
            model.ListOfProjects = ProjectRepository.GetList().ToPagedList(1, 10);
            var ListofStaff = StaffRepository.GetList();
            foreach (var item in ListofStaff)
            {
                model.Supervisors.Add(
                    
                    new Supervisor {

                        Id= item.Id,
                        Name = item.Staff_FirstName
                    });
            }




            return View(model);
  }


        // GET: Projects/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            var projectViewModel = new CreateProjectViewModel();
            return View(projectViewModel);
        }

        // POST: Projects/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, CreateProjectViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                using (var context = new Research_ManagementEntities())
                {
                    context.Projects.Add(new Project { Prj_Name = model.ProjectName, Prj_Desc = model.ProjectDesc, Prj_StageId = model.ProjectStageId, Prj_LevelId = model.ProjectLevelId });
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int id)
        {
            using (var context = new Research_ManagementEntities())
            {
                var project = context.Projects.FirstOrDefault(a => a.Id == id);
                return View(project);
            }
        }

        // POST: Projects/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                using (var context = new Research_ManagementEntities())
                {
                    var project = context.Projects.FirstOrDefault(a => a.Id == id);
                    //project
                    context.Projects.Remove(project);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int id)
        {
            using (var context = new Research_ManagementEntities())
            {
                var project = context.Projects.FirstOrDefault(a => a.Id == id);
                return View(project);
            }
        }

        // POST: Projects/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var context = new Research_ManagementEntities())
                {
                    var Project = context.Projects.FirstOrDefault(a => a.Id == id);
                    context.Projects.Remove(Project);
                    context.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
