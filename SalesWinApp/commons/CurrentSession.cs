using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.commons
{

    public enum RoleBased 
    {
        Admin,
        User
    }

    public class CurrentSession
    {
        public RoleBased Role { get; set; }
        public MemberObject MemberInfo { get; set; }
    }
}
