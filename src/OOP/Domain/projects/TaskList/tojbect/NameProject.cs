using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record NameProject
    {
        public string ProjectNameValue { get; }
        private NameProject(string username)
        {
            ProjectNameValue = username;
        }
        public static NameProject Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Название не может быть пустым");
            }
            if (value.Length < 4)
            {
                throw new ArgumentException("Название не должен быть короче 4 символов");
            }
            if (value.Length > 30)
            {
                throw new ArgumentException("Название не должен быть длинее 30 символов");
            }
            return new NameProject(value);
        }
    }
}
