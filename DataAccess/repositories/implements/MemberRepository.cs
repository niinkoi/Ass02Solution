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
    }
}
