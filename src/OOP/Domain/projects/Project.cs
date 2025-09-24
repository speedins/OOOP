using Domain.projects.pobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects
{
    internal class Project
    {
        public FinishDataProject FinishDataProject { get; private set; }
        public IdMembers IdMembers { get; private set; }
        public IdProject IdProject { get; }
        public StartDataProject StartDataProject { get; private set; }
        public Tasklist TaskList { get; private set; }

        public Project(
            FinishDataProject finishDataProject,
            IdMembers idMembers,
            IdProject idProject,
            StartDataProject startDataProject,
            Tasklist taskList) 
        {
            FinishDataProject = finishDataProject;
            IdMembers = idMembers;
            IdProject = idProject;
            StartDataProject = startDataProject;
            TaskList = taskList;
        }
    }
}
