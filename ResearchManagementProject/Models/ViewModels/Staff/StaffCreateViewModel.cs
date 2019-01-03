using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Models.ViewModels.Staff
{
    public class StaffCreateViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }        
        [RegularExpression(pattern: @"((\+|00)?[0-9]{3}|0)?[0-9]{9}", ErrorMessage ="Invalid Phone Format. Should be in local or international format (xx)(xxx)(xxxx)")]
        public string PhoneNo { get; set; }
        public byte[] Photo { get; set; }
        public string Major { get; set; }
    }
}