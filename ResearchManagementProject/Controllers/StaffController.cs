using ResearchManagementProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ResearchManagementProject.Models.ViewModels.Staff;

namespace ResearchManagementProject.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            using (var context = new Research_ManagementEntities())
            {
                var dbStaffList = context.StaffMembersContacts.ToList();               
                return View(dbStaffList);
            }            
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            var staff = new StaffCreateViewModel();
            return View(staff);           
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection, StaffCreateViewModel staffMember, HttpPostedFileBase file)
        {
            try
            {
                using (var context = new Research_ManagementEntities())
                {
                    var staffContact = new StaffMembersContact()
                    {
                        Staff_Email = staffMember.Email,
                        Staff_Phone = staffMember.PhoneNo,
                        Staff_FirstName = staffMember.FirstName,
                        Staff_LastName = staffMember.LastName,
                        RowId = Guid.NewGuid()
                    };

                    if (file != null)
                    {
                        staffContact.Photo = new byte[file.ContentLength];
                        file.InputStream.Read(staffContact.Photo, 0, file.ContentLength);
                    }
                                  
                    context.StaffMembersContacts.Add(staffContact);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }                
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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
