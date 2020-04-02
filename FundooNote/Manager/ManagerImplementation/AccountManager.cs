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
        public async  Task<bool> EmailLogin(LoginModel login)
        {
            return  await this.accountRepository.EmailLogin(login);
        }

        public async Task<RegisterModel> FacebookLogin(LoginModel login)
        {
            return await this.accountRepository.FacebookLogin(login);
        }

        public async Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            return await this.accountRepository.ForgotPassword(forgotPassword);
        }

        public async Task<bool> Login(LoginModel login)
        {
            return await this.accountRepository.Login(login);
        }

        public async Task<bool> Register(RegisterModel register)
        {
            await this.accountRepository.RegisterAccount(register);
            return true;
        }

        public async Task<string> ResetPassword(ResetPassword resetPassword)
        {
            return await this.accountRepository.ResetPassword(resetPassword);
        }
    }
}
