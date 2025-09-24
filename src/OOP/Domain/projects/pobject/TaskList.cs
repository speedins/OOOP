using Domain.projects.TaskList.tojbect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.pobject
{
    internal record Tasklist
    {
        private List<Task> TaskList { get; } = new List<Task>();
        public void AddTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }
            TaskList.Add(task);
        }
        public IReadOnlyList<Task> GetTaskList() { return TaskList; }
        public void ClearTask()
        {
            TaskList.Clear();
        }
        public void DeleteTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }
            TaskList.Remove(task);
        }
    }
}
