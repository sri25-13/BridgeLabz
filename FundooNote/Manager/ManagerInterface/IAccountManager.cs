using Model.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
   public interface IAccountManager
    {
        Task<bool> Register(RegisterModel register);
        Task<bool> Login(LoginModel login);
        Task<string> ForgotPassword(ForgotPassword forgotPassword);
        Task<string> ResetPassword(ResetPassword resetPassword);
        Task<bool> EmailLogin(LoginModel login);
        Task<RegisterModel> FacebookLogin(LoginModel login);
    }
}

