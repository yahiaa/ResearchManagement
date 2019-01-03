using ResearchManagementProject.Bussiness_Layer.Repository;
using ResearchManagementProject.Models.ViewModels;
using ResearchManagementProject.Models.ViewModels.Majors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchManagementProject.Controllers
{
    public class StudentsController : Controller
    {
        StudentRepository repo = new StudentRepository();
        // GET: Students
        public ActionResult Index()
        {            
            return View(repo.GetList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.Get(id));
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            //var db = new Research_ManagementEntities();
            //var MAjorList =  db.Majors.Select(a=>a);
            //  var maj = new List<MajorsViewModel>();
            //  foreach (var item in MAjorList)
            //  {
            //      maj.Add(
            //          new MajorsViewModel
            //          {
            //              Id = item.Id,
            //              Mjr_Name = item.Mjr_Name
            //          });
            //  }


            //var model = new () {
            //    //Std_Majors = ma
            //};
            var model = StudentRepository.CreateCRUDStudentViewModel();
            return View(model);
        }

        // POST: Students/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, CRUDStudentViewModel item)
        {
            try
            {

                repo.Add(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repo.Get(id));
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, CRUDStudentViewModel item)
        {
            try
            {
                repo.Update(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            repo.Delete(repo.Get(id));            
            return View();
        }

        // POST: Students/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
