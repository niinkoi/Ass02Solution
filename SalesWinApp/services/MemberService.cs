using BusinessObject;
using DataAccess.repositories;
using DataAccess.repositories.implements;
using Microsoft.Extensions.Configuration;
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
    }
}
