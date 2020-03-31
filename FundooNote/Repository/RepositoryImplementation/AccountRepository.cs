using Microsoft.IdentityModel.Tokens;
using Model.Account;
using Repository.AccountContext;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
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

        public async Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            var user = CheckEmail(forgotPassword.Email);
            if (user == true)
            {
                var fromAddress = new MailAddress("sriharshinirao25@gmail.com");
                var fromPassword = "8897287474";
                var toAddress = new MailAddress(forgotPassword.Email);
                string subject = "Reset Password";
                string body = "To reset your password click the below given link :- " + " http:";
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        smtp.Send(message);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                await Task.Run(() => this.context.SaveChangesAsync());
                return "Success";
            }
            return null;
        }

        public async Task<bool> Login(LoginModel login)
        {
            var check = CheckEmail(login.Email);
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



        public Task<int> RegisterAccount(RegisterModel register)
        {
            RegisterModel register1 = new RegisterModel()
            {
                Firstname = register.Firstname,
                Lastname = register.Lastname,
                Email = register.Email,
                Password = register.Password
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
