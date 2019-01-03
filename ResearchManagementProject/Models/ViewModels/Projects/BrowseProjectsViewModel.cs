using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchManagementProject.Models.ViewModels.Projects
{
    public class BrowseProjectsViewModel
    {
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }

        public ICollection<Departments> Departments{get; set;}
        public ICollection<Major> Majors { get; set; }

        public ICollection<Supervisor> Supervisors { get; set; }
        public IPagedList<Project> ListOfProjects{ get; set; }
    }
}

public class Departments
{

    public int Id { get; set; }
    public string Name { get; set; }

}
public class Major
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Supervisor
{
    public int Id { get; set; }
    public string Name { get; set; }
} 