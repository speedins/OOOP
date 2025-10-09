using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.users.uobject
{
    public abstract class UserStatus : Enumeration<UserStatus>
    {
        protected UserStatus(int key, string name) : base(key, name)
        {

        }
        public abstract bool CanExecuteAction();
    }
    public sealed class UserStatusOnline : UserStatus
    {
        public UserStatusOnline()
            : base(0, "Онлаин") { }
        public override bool CanExecuteAction() => true;
    }
    public sealed class UserStatusOffline : UserStatus
    {
        public UserStatusOffline()
            : base(1, "Оффлаин") { }
        public override bool CanExecuteAction() => false;
    }
    public sealed class UserStatusBanned : UserStatus
    {
        public UserStatusBanned()
            : base(3, "Забанен") { }
        public override bool CanExecuteAction() => false;
    }

}
