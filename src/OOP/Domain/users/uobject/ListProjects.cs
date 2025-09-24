using Domain.projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.users.uobject
{
    internal record ListProjects
    {
        private List<Project> ProjectList { get; } = new List<Project>();
        public void AddProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("Project");
            }
            ProjectList.Add(project);
        }
        public IReadOnlyList<Project> GetProjects() { return ProjectList; }
    }
}