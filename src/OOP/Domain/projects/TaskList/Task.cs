using Domain.projects.TaskList.tojbect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.Tasks
{
    internal class Task
    {
        public FinishDataTask FinishDataTask { get; private set; }
        public LvlImortance LvlImortance { get; private set; }
        public MembersTask MembersTask { get; private set; }
        public Progres Progres { get; private set; }
        public StartDataTask StartDataTask { get; private set; }
        public TaskId TaskId { get; }
        public Task(
            TaskId taskId,
            StartDataTask startDataTask,
            FinishDataTask finishDataTask,
            LvlImortance lvlImortance,
            Progres progres,
            MembersTask membersTask)
        {
            TaskId = taskId;
            StartDataTask = startDataTask;
            FinishDataTask = finishDataTask;
            LvlImortance = lvlImortance;
            Progres = progres;            
            MembersTask = membersTask;
        }
    }
}
