using Model.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
   public interface IAccountRepository
    {
        Task<int> RegisterAccount(Register register);
        Task<string> Login(Login login);
        Task<string> ForgotPassword(ForgotPassword forgotPassword);
        Task<string> ResetPassword(ResetPassword resetPassword);
        Task<Register> EmailLogin(Login login);
        Task<Register> FacebookLogin(Login login);
    }
}
