using ResearchManagementProject.Models.ViewModels.Majors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Models.ViewModels
{
    public class CRUDStudentViewModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string Std_FirstName { get; set; }
        [DisplayName("Last Name")]
        public string Std_LasttName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string std_Phone { get; set; }
        public ICollection<Major> Std_Majors { get; set; }
        public Major Std_Major { get; set; }
        public virtual ICollection<Student_Projects> Student_Projects { get; set; }
    }
}
