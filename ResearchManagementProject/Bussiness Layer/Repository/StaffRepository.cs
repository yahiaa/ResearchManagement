using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Bussiness_Layer.Repository
{
    public class StaffRepository
    {

        Research_ManagementEntities context;
        public void Add(StaffMembersContact item)
        {
            using (context = new Research_ManagementEntities())
            {
                context.StaffMembersContacts.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(StaffMembersContact item)
        {
            using (context = new Research_ManagementEntities())
            {
                context.StaffMembersContacts.Remove(item);
                context.SaveChanges();
            }
        }

        public StaffMembersContact Get(int id)
        {
            using (context = new Research_ManagementEntities())
            {
                return (context.StaffMembersContacts.FirstOrDefault(c => ((StaffMembersContact)c).Id == id));
            }
        }

        public List<StaffMembersContact> GetList()
        {
            using (context = new Research_ManagementEntities())
            {
                return (context.StaffMembersContacts.ToList());
            }
        }
        public void Update(StaffMembersContact item)
        {
            using (context = new Research_ManagementEntities())
            {
                var dbItem = context.StaffMembersContacts.FirstOrDefault(c => c.Id == item.Id);
                dbItem.Staff_FirstName = item.Staff_FirstName;
                dbItem.Staff_LastName = item.Staff_LastName;
                dbItem.Staff_Phone = item.Staff_Phone;
                dbItem.Photo = item.Photo;
                dbItem.MajorId = item.MajorId;
                dbItem.Staff_Email = item.Staff_Email;
                context.SaveChanges();
            }
        }


    }
}