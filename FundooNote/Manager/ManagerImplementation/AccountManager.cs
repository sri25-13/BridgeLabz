using Manager.ManagerInterface;
using Model.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImplementation
{
    public class AccountManager : IAccountManager
    {
        public Task<Register> EmailLogin(Login login)
        {
            throw new NotImplementedException();
        }

        public Task<Register> FacebookLogin(Login login)
        {
            throw new NotImplementedException();
        }

        public Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(Login login)
        {
            throw new NotImplementedException();
        }

        public Task<int> RegisterAccount(Register register)
        {
            throw new NotImplementedException();
        }

        public Task<string> ResetPassword(ResetPassword resetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
