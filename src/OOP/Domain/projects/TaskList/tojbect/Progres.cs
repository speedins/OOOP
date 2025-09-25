using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record Progres
    {
        public short progres { get; }
        private Progres(short value)
        {
            progres = value;
        }
        public static Progres Create ()
        {
          return new Progres (0);
        }
        public static Progres Create (short value)
        {
            if (value > 100 || value <0)
            {
                throw new ArgumentOutOfRangeException ("Что-то пошло не так");
            }
            return new Progres (value);
        }
    }
}
