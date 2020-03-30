using Model.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
   public interface IAccountRepository
    {
        Task<int> RegisterAccount(RegisterModel register);
        Task<string> Login(LoginModel login);
        Task<string> ForgotPassword(ForgotPassword forgotPassword);
        Task<string> ResetPassword(ResetPassword resetPassword);
        Task<RegisterModel> EmailLogin(LoginModel login);
        Task<RegisterModel> FacebookLogin(LoginModel login);
    }
}
