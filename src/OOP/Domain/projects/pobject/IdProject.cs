using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.pobject
{
    internal record IdProject
    {
        public Guid Id { get; }
        private IdProject(Guid id)
        {
            Id = id;
        }
        public static IdProject Create(Guid value)
        {
            if (Guid.Empty == value)
            {
                throw new ArgumentNullException("Что-то пошло не так.");
            }
            return new IdProject(value);
        }
        public static IdProject Create()
        {
            Guid id = Guid.NewGuid();
            return new IdProject(id);
        }

    }
}
