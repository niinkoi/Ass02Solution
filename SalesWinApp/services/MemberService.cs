using AutoMapper;
using BusinessObject;
using DataAccess.repositories;
using DataAccess.repositories.implements;
using Microsoft.Extensions.Configuration;
using SalesWinApp.raws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.services
{
    public class MemberService
    {
        IRepositoryManager _repository = new RepositoryManager();

        public MemberObject? Authenticate(string email, string password)
        {
            if (IsDefaultAccount(email, password))
            {
                return new MemberObject() { Email = email, Password = password };
            }
            else
            {
                return ((MemberRepository)_repository.Member)
                .FindByCondition(member => member.Email == email && member.Password == password, false)
                .FirstOrDefault();
            }
        }

        public void UpdateProfile(IMapper mapper, int theId, MemberRaw member)
        {
            var entity = _repository.Member.GetMember(theId, true);
            if (entity == null)
            {
                throw new Exception($"No member with id: {theId} exists.");
            }
            mapper.Map(member, entity);
            _repository.Save();
        }

        public void CreateMember(IMapper mapper, MemberRaw raw)
        {
            _repository.RemoveTracker();
            var entity = mapper.Map<MemberObject>(raw);
            _repository.Member.CreateMember(entity);
            _repository.Save();
        }

        public void DeleteMember(IMapper mapper, int theId)
        {
            var member = _repository.Member.GetMember(theId, true);
            if (member == null)
            {
                throw new Exception("No member found");
            }
            _repository.Member.DeleteMember(member);
            _repository.Save();
        }

        public MemberRaw LoadProfile(IMapper mapper, int theId)
        {
            var found = _repository.Member.GetMember(theId, false);
            if (theId == -1)
            {
                return new MemberRaw()
                {
                    Email = RetrieveDefaultAccount("Email"),
                    Password = RetrieveDefaultAccount("Password")
                };
            }
            else if (found == null)
            {
                throw new Exception($"No member with id: {theId} exists.");
            }
            else
            {
                return mapper.Map<MemberRaw>(found);
            }
        }

        private bool IsDefaultAccount(string email, string password)
        {
            var defaultEmail = RetrieveDefaultAccount("Email");
            var defaultPassword = RetrieveDefaultAccount("Password");

            return email.Equals(defaultEmail) && password.Equals(defaultPassword);
        }

        public string RetrieveDefaultAccount(string prop)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
            return configuration.GetSection($"DefaultAccount:{prop}").Value;
        }

        public List<MemberObject> GetAll(IMapper mapper) => _repository.Member.GetAllMembers(false).ToList();
    }
}
