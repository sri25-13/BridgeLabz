using BookStoreCommonLayer.AccountModel;
using BookStoreRepository.BookStoreContext;
using BookStoreRepository.RepositoryInterfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepository.RepositoryImplementation
{ 
    public class AccountRepository : IAccountRepository
    {
        public Context context;
        private readonly IConfiguration configuration;
        public AccountRepository(Context context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
            public async Task register(RegisterModel register)
            {
            RegisterModel register1 = new RegisterModel()
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                Password = register.Password
            };
            var keyNew = PasswordEncryption.GeneratePassword(10);
            var password = PasswordEncryption.EncodePassword(register.Password, keyNew);
            register1.Password = password;
            this.context.Accountregister.Add(register1);
            await Task.Run(() => this.context.SaveChanges());
        }
        public async Task<string> Login(LoginModel login)
        {
            if (CheckEmail(login.Email))
            {
                if (CheckPassword(login.Email, login.Password))
                {
                    var key = configuration["Jwt:key"];
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                    var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:_url"],
                        audience: configuration["Jwt:_url"],
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signInCr);
                    var FinalToken = new JwtSecurityTokenHandler().WriteToken(token);
                    await Task.Run(() => this.context.SaveChangesAsync());
                    return FinalToken;
                }
            }
            return "invalid";
        }
        public bool CheckEmail(string email)
        {
            var result = context.Accountregister.Where(option => option.Email == email).FirstOrDefault();
            if (result != null)
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
            var result = context.Accountregister.Where(option => option.Email == email && option.Password == password).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}