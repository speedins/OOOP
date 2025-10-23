using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record NameProject
    {
        public const int MIN_VALUE_PROJECTNAME = 4;
        public const int MAX_VALUE_PROJECTNAME = 30;
        public string ProjectNameValue { get; }
        public NameProject(string username)
        {
            ProjectNameValue = username;
        }
        public static NameProject Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Название не может быть пустым");
            }
            if (value.Length < MIN_VALUE_PROJECTNAME)
            {
                throw new ArgumentException("Название не должен быть короче 4 символов");
            }
            if (value.Length > MAX_VALUE_PROJECTNAME)
            {
                throw new ArgumentException("Название не должен быть длинее 30 символов");
            }
            return new NameProject(value);
        }
    }
}
