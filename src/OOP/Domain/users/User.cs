using Domain.users.uobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.users
{
    internal class User
    {
        public ListProjects ListProjects { get; private set; }
        public Special Special { get; private set; }
        public UserId UserId { get; }
        public UserName UserName { get; private set; }
        public User 
            (
            ListProjects listProjects,
            Special special,
            UserId userId,
            UserName userName
            )
        {
            ListProjects = listProjects;
            Special = special;
            UserId = userId;
            UserName = userName;
        } 
    }
}
