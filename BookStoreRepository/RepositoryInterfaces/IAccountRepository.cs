using BookStoreCommonLayer.AccountModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepository.RepositoryInterfaces
{
   public interface IAccountRepository
    {
        Task register(RegisterModel register);
        Task<string> Login(LoginModel loginModel);
    }
}
