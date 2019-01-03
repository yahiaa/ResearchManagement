using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Models.ViewModels
{
    public class StaffViewModel
    {
        public int Id { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }         
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Invalid Phone Format")]
        public string PhoneNo { get; set; }
        public System.Guid RowId { get; set; }
        public byte[] Photo { get; set; }
    }
}