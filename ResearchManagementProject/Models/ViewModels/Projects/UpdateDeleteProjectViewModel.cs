using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Models.ViewModels.Projects
{
    public class UpdateDeleteProjectViewModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public int ProjectStageId { get; set; }
        public int ProjectLevelId { get; set; }
    }
}