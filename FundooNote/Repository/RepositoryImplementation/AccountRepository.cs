﻿using Model.Account;
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
            Register register1 = new Register()
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
