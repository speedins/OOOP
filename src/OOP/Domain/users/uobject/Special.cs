using Domain.users.uobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.users.uobject
{
    internal record Special
    {
        public string SpecialValue { get; }
        private Special(string special)
        {
            SpecialValue = special;
        }
        public static Special Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Специальность не может быть пустым");
            }
            return new Special(value);
        }
        public static Special Create()
        {
            string special = "Отсутствует";
            return new Special(special);
        }
        
    }
}