using Domain.projects.pobject;
using Domain.projects.TaskList.tojbect;
using Domain.projects.Tasks;

namespace Domain.projects
{
    internal class Project
    {
        private List<ProjectTask> tasks = [];
        public IReadOnlyCollection<ProjectTask> Tasks { get { return tasks; } } 
        public FinishDataProject? FinishDataProject { get; private set; }
        public IdProject IdProject { get; }
        public StartDataProject StartDataProject { get; private set; }
        public NameProject NameProject { get; private set; }
        public Project(
            FinishDataProject? finishDataProject,
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
