using ResearchManagementProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Bussiness_Layer.Repository
{
    public class StudentRepository
    {
        Research_ManagementEntities context;
        public void Add(CRUDStudentViewModel item)
        {
            using (context = new Research_ManagementEntities())
            {
                context.Students.Add(new Student() { Std_Email = item.Email, Std_FirstName = item.Std_FirstName, Std_LastName = item.Std_LasttName, Std_Phone = item.std_Phone, Major = item.Std_Major, Student_Projects = item.Student_Projects });
                context.SaveChanges();
            }
        }

        public void Delete(CRUDStudentViewModel item)
        {
            using (context = new Research_ManagementEntities())
            {
                var student = context.Students.FirstOrDefault(c => c.Id == item.Id);
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        public static CRUDStudentViewModel CreateCRUDStudentViewModel()
        {
            Research_ManagementEntities context;
            var student = new CRUDStudentViewModel();
            using (context = new Research_ManagementEntities())
            {
                student.Std_Majors = context.Majors.ToList();
                return student;
            }
        }

        public CRUDStudentViewModel Get(int id)
        {
            using (context = new Research_ManagementEntities())
            {
                var item = context.Students.FirstOrDefault(c => c.Id == id);
                return (new CRUDStudentViewModel()
                {
                    Email = item.Std_Email,
                    Std_FirstName = item.Std_FirstName,
                    Std_LasttName = item.Std_LastName,
                    Std_Major = item.Major,
                    std_Phone = item.Std_Phone,
                    Student_Projects = item.Student_Projects,
                    Id = item.Id
                });
            }
        }

        public List<CRUDStudentViewModel> GetList()
        {
            using (context = new Research_ManagementEntities())
            {
                var list = context.Students.ToList();
                var std = new List<CRUDStudentViewModel>();
                foreach (var item in list)
                {
                    std.Add(new CRUDStudentViewModel()
                    {
                        Email = item.Std_Email,
                        Std_FirstName = item.Std_FirstName,
                        Std_LasttName = item.Std_LastName,
                        Std_Major = item.Major
                    ,
                        std_Phone = item.Std_Phone,
                        Student_Projects = item.Student_Projects,
                        Id = item.Id
                    });
                }
                return std;
            }
        }

        public void Update(CRUDStudentViewModel item)
        {
            using (context = new Research_ManagementEntities())
            {
                var dbItem = context.Students.FirstOrDefault(c => c.Id == item.Id);
                dbItem.Std_Email = item.Email;
                dbItem.Std_FirstName = item.Std_FirstName;
                dbItem.Std_LastName = item.Std_LasttName;
                dbItem.Major = item.Std_Major;
                dbItem.Std_Phone = item.std_Phone;
                dbItem.Student_Projects = item.Student_Projects;
                dbItem.Id = item.Id;
                context.SaveChanges();
            }
        }
    }
}