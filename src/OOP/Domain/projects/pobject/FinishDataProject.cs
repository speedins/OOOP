using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.pobject
{
    internal record FinishDataProject
    {
        public DateTime FinishDateProject { get; }
        private FinishDataProject(DateTime dateTime)
        {
            FinishDateProject = dateTime;
        }
        public static FinishDataProject Create(DateTime value)
        {
            if (value == default)
            {
                throw new ArgumentNullException("Что-то не то");
            }
            return new FinishDataProject(value);
        }
        public static FinishDataProject Create()
        {
            DateTime value = DateTime.MaxValue;
            return new FinishDataProject(value);
        }
    }
}
