using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record FinishDataTask
    {
        public DateTime FinishDateTask { get; }
        private FinishDataTask(DateTime dateTime)
        {
            FinishDateTask = dateTime;
        }
        public static FinishDataTask Create(DateTime value)
        {
            if (value == default)
            {
                throw new ArgumentNullException("Что-то не то");
            }
            return new FinishDataTask(value);
        }
        public static FinishDataTask Create()
        {
            DateTime value = DateTime.MaxValue;
            return new FinishDataTask(value);
        }
    }
}
