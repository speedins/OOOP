using Domain.users.uobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record StartDataTask
    {
        public DateTime StartDateTask { get;}
        private StartDataTask(DateTime dateTime)
        {
            StartDateTask = dateTime;
        }
        public static StartDataTask Create (DateTime value)
        {
            if (value == default)
            {
                throw new ArgumentNullException("Что-то не то");
            }
            return new StartDataTask(value);
        }
        public static StartDataTask Create ()
        {
            DateTime value = DateTime.Today;
            return new StartDataTask(value);
        }
    }
}
