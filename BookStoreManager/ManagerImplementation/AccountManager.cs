using BookStoreCommonLayer.AccountModel;
using BookStoreManager.ManagerInterfaces;
using BookStoreRepository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManager.ManagerImplementation
{
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository accountRepository;
        public AccountManager(IAccountRepository repository)
        {
            this.accountRepository = repository;
        }
        public async Task register(RegisterModel model)
        {
            await this.accountRepository.register(model);
        }
        public async Task<string> Login(LoginModel login)
        {
            return await accountRepository.Login(login);
        }
    }
}
