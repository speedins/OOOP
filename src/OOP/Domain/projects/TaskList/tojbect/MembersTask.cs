using Domain.users.uobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.TaskList.tojbect
{
    internal record MembersTask
    {
        private List<UserId> Members { get; } = new List<UserId>();
        public void AddMember(UserId id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Members.Add(id);
        }
        public IReadOnlyList<UserId> GetMembers()
        {
            return Members.AsReadOnly();
        }
        public void ClearMembers()
        {
            Members.Clear();
        }
        public void DeleteMember(UserId id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            Members.Remove(id);
        }
    }
}
