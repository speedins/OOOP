using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record TaskId
    {
        public Guid Id { get; }
        private TaskId(Guid id)
        {
            Id = id;
        }
        public static TaskId Create(Guid value)
        {
            if (Guid.Empty == value)
            {
                throw new ArgumentNullException("Что-то пошло не так.");
            }
            return new TaskId(value);
        }
        public static TaskId Create()
        {
            Guid id = Guid.NewGuid();
            return new TaskId(id);
        }

    }
}
