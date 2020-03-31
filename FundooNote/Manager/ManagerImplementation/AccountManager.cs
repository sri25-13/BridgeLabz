using Manager.ManagerInterface;
using Model.Account;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImplementation
{
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository accountRepository;
        public AccountManager()
        {

        }
        public AccountManager(IAccountRepository repository)
        {
            this.accountRepository = repository;
        }
        public Task<RegisterModel> EmailLogin(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterModel> FacebookLogin(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(LoginModel login)
        {
            return this.accountRepository.Login(login);
        }

        public async Task<bool> Register(RegisterModel register)
        {
            await this.accountRepository.RegisterAccount(register);
            return true;
        }

        public Task<string> ResetPassword(ResetPassword resetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
