using Model.Account;
using Repository.AccountContext;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImplementation
{
    public class AccountRepository : IAccountRepository
    {
        public Context context;
        public AccountRepository(Context context)
        {
            this.context = context;
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
            throw new NotImplementedException();
        }

        public Task<int> RegisterAccount(RegisterModel register)
        {
            RegisterModel register1 = new RegisterModel()
            {
                Firstname = register.Firstname,
                Lastname=register.Lastname,
                Email=register.Email,
                Password=register.Password
            };
            var reg = this.context.Accountregister.Add(register);
            var result = this.context.SaveChanges();
            return Task.Run(() => result);
        }

        public Task<string> ResetPassword(ResetPassword resetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
