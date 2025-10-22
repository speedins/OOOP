using Domain.projects.pobject;
using Domain.projects.TaskList.tojbect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.Tasks
{
    internal class ProjectTask
    {

        public Project Project { get; private set; }
        public IdProject IdProject { get; private set; }
        public FinishDataTask FinishDataTask { get; private set; }
        public LvlImortance LvlImortance { get; private set; }
        public Progres Progres { get; private set; }
        public StartDataTask StartDataTask { get; private set; }
        public TaskId TaskId { get; }
        public ProjectTask(
            TaskId taskId,
            StartDataTask startDataTask,
            FinishDataTask finishDataTask,
            LvlImortance lvlImortance,
            Progres progres,
            Project project)
        {
            Project = project;
            IdProject = project.IdProject;
            TaskId = taskId;
            StartDataTask = startDataTask;
            FinishDataTask = finishDataTask;
            LvlImortance = lvlImortance;
            Progres = progres;            
        }
        
    }
}
