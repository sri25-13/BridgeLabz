using Microsoft.IdentityModel.Tokens;
using Model.Account;
using Repository.AccountContext;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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

        public async Task<bool> Login(LoginModel login)
        {
            LoginModel loginModel = new LoginModel(); 
            var check = FindEmailid(login.Email);
            var result = CheckPassword(login.Email, login.Password);
            var tokenHandler = new JwtSecurityTokenHandler(); 
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Email", login.Email),
                    new Claim("Password", login.Password) 
                }),
            };
            var descriptor = tokenHandler.CreateToken(tokenDescriptor);
            var securityToken = tokenHandler.WriteToken(descriptor);
            var res = this.context.SaveChangesAsync(); 
            await Task.Run(() => context.SaveChanges());
            return true;
        }

    
    public bool FindEmailid(string email)
        {
            var result = context.Accountregister.Where(obj => obj.Email == email).FirstOrDefault();
            if(result!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckPassword(string email, string password)
        {
            var result = context.Accountregister.Where(obj => obj.Password == password && obj.Email == email).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
