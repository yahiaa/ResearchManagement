using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ResearchManagementProject.Models.ViewModels
{
    public class CreateProjectViewModel
    {

        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public int ProjectStageId { get; set; }
        public int ProjectLevelId { get; set; }
    }
}