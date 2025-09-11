using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.users.uobject
{
    internal record UserName
    {
        public string UserNameValue { get; }
        private UserName(string username)
        {
            UserNameValue = username;
        }
        public static UserName Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Никнейм не может быть пустым");
            }
            if (value.Length < 4)
            {
                throw new ArgumentException("Никнейм не должен быть короче 4 символов");
            }
            if (value.Length > 30)
            {
                throw new ArgumentException("Никнейм не должен быть длинее 30 символов");
            }
            return new UserName(value);
        }
    }
}
