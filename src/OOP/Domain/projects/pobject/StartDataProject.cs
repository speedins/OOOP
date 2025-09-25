using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.pobject
{
    internal record StartDataProject
    {
        public DateTime StartDateProject { get; }
        private StartDataProject(DateTime dateTime)
        {
            StartDateProject = dateTime;
        }
        public static StartDataProject Create(DateTime value)
        {
            if (value == default)
            {
                throw new ArgumentNullException("Что-то не то");
            }
            return new StartDataProject(value);
        }
        public static StartDataProject Create()
        {
            DateTime value = DateTime.Today;
            return new StartDataProject(value);
        }
    }
}
