using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories.implements
{
    public class MemberRepository : RepositoryBase<MemberObject>, IMemberRepository
    {
        public MemberRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateMember(MemberObject member) => Create(member);

        public void DeleteMember(MemberObject member) => Delete(member);

        public IEnumerable<MemberObject> GetAllMembers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(m => m.Email)
            .ToList();

        public MemberObject? GetMember(int theId, bool trackChanges) =>
            FindByCondition(m => m.ID.Equals(theId), trackChanges)
            .SingleOrDefault();
    }
}
