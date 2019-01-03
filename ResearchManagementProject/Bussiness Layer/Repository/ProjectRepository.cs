using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Bussiness_Layer.Repository
{
    public class ProjectRepository
    {
        Research_ManagementEntities context;
        public void Add(Project item)
        {            
            using (context = new Research_ManagementEntities())
            {                
                context.Projects.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(Project item)
        {
            using (context = new Research_ManagementEntities())
            {
                context.Projects.Remove(item);
                context.SaveChanges();
            }
        }

        public Project Get(int id)
        {
            using (context = new Research_ManagementEntities())
            {
                return (context.Projects.FirstOrDefault(c => ((Project)c).Id == id));                
            }
        }

        public List<Project> GetList()
        {
            using (context = new Research_ManagementEntities())
            {
                return (context.Projects.ToList());
            }
        }
        public void Update(Project item)
        {
            using (context = new Research_ManagementEntities())
            {
                var dbItem = context.Projects.FirstOrDefault(c => c.Id == item.Id);
                dbItem.Prj_Desc = item.Prj_Desc;
                dbItem.Prj_Name = item.Prj_Name;
                dbItem.Prj_StageId= item.Prj_StageId;
                //dbItem.Prj_Desc = item.Prj_Desc;
                //dbItem.Prj_Desc = item.Prj_Desc;            
                context.SaveChanges();
            }
        }        
    }
}