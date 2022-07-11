using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories
{
    public interface IMemberRepository
    {
        public IEnumerable<MemberObject> GetAllMembers(bool trackChanges);
        public MemberObject? GetMember(int theId, bool trackChanges);
        public void CreateMember(MemberObject member);
        public void DeleteMember(MemberObject member);
    }
}
