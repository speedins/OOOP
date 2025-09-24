using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record LvlImortance
    {
        public string LvlImortanc;
        private LvlImortance(string value)
        {
            LvlImortanc = value;
        }
        public static LvlImortance Create (string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Что-то не то");
            }
            return new LvlImortance(value);
        }
        public static LvlImortance Create ()
        {
            string value = "Сложность не задана";
            return new LvlImortance(value);
        }
    }
}
