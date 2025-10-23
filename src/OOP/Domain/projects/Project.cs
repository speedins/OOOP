using Domain.projects.pobject;
using Domain.projects.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects
{
    internal class Project
    {
        private List<ProjectTask> tasks = [];
        public IReadOnlyCollection<ProjectTask> Tasks { get { return tasks; } } 
        public FinishDataProject FinishDataProject { get; private set; }
        public IdProject IdProject { get; }
        public StartDataProject StartDataProject { get; private set; }
        public Name NameProject { get; private set; }
        public Project(
            FinishDataProject finishDataProject,
            IdProject idProject,
            StartDataProject startDataProject,
            NameProject nameProject) 
        {
            FinishDataProject = finishDataProject;
            IdProject = idProject;
            StartDataProject = startDataProject;
            NameProject = nameProject;
        }
    }
}
