using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.users.uobject
{
    internal record PhoneNumbers
    {
        private static readonly Regex regex = new Regex (@"[8](\d{10})|[+7](\d{11})");
        public string PhoneNumber { get; }
        private PhoneNumbers(string value)
        {
            PhoneNumber = value;
        }
        public static PhoneNumbers Create(string value)
        {
            if (regex.Match(value).Success == false)
            {
                throw new ArgumentException("Ошибка в проверки маски телефона");
            }
            return new PhoneNumbers(value);
        }
    }
}