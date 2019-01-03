using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Bussiness_Layer.Repository
{
    public class MajorRepository
    {
        Research_ManagementEntities context;
        public void Add(Major item)
        {
            using (context = new Research_ManagementEntities())
            {
                context.Majors.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(Major item)
        {
            using (context = new Research_ManagementEntities())
            {
                context.Majors.Remove(item);
                context.SaveChanges();
            }
        }

        public Major Get(int id)
        {
            using (context = new Research_ManagementEntities())
            {
                return (context.Majors.FirstOrDefault(c => ((Major)c).Id == id));
            }
        }

        public List<Major> GetList()
        {
            using (context = new Research_ManagementEntities())
            {
                return (context.Majors.ToList());
            }
        }
        public void Update(Major item)
        {
            using (context = new Research_ManagementEntities())
            {
                var dbItem = context.Majors.FirstOrDefault(c => c.Id == item.Id);
                dbItem.Mjr_Name = item.Mjr_Name;
                context.SaveChanges();
            }
        }



    }
}