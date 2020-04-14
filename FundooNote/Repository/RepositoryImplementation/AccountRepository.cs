// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryImplementation
{
    using Microsoft.IdentityModel.Tokens;
    using Model.Account;
    using Repository.AccountContext;
    using Repository.RepositoryInterface;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Net.Mail;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using StackExchange.Redis;

    /// <summary>
    /// class for AccountRepository
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        public Context context;

        /// <summary>
        /// Parameterizedconstructor for AccountRepository
        /// </summary>
        /// <param name="context"></param>
        public AccountRepository(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Async method implementation for Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<bool> EmailLogin(LoginModel login)
        {
            if (CheckEmail(login.Email))
            {
                if (CheckPassword(login.Email, login.Password))
                {
                    try
                    {
                        JwtSettings jwt = new JwtSettings();
                        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwt.Secret"));
                        var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(expires: DateTime.Now.AddDays(1), signingCredentials: credential);
                        var cacheKey = login.Email;
                        ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                        IDatabase data = multiplexer.GetDatabase();
                        data.StringSet(cacheKey, token.ToString());
                        data.StringGet(cacheKey);
                        await this.context.SaveChangesAsync();
                        return true;
                    }
                    catch (Exception exception)
                    {
                        throw new Exception(exception.Message);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Async method implementation for FacebookLogin
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<RegisterModel> FacebookLogin(LoginModel login)
        {
            JwtSettings jwt = new JwtSettings();
            var result = this.context.Accountregister.Where(option => option.Email == login.Email).SingleOrDefault();
            if (result != null)
            {
                try
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwt.Secret"));
                    var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(expires: DateTime.Now.AddDays(1), signingCredentials: credential);
                    var cacheKey = login.Email;
                    ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase data = multiplexer.GetDatabase();
                    data.StringSet(cacheKey, token.ToString());
                    data.StringGet(cacheKey);
                    result.Status = true;
                    await this.context.SaveChangesAsync();
                    return result;
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }

            return default;
        }

        /// <summary>
        /// Async method implementation for ForgotPassword
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        public async Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            JwtSettings jwt = new JwtSettings();
            var user = CheckEmail(forgotPassword.Email);
            if (user == true)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwt.Secret"));
                var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(expires: DateTime.Now.AddDays(1), signingCredentials: credential);
                var fromAddress = new MailAddress("sriharshinirao25@gmail.com");
                var fromPassword = "harshini@25@";
                var toAddress = new MailAddress(forgotPassword.Email);
                string subject = "Reset Password";
                string body = "To reset your password click the  given link :- " + " http://localhost:44387/api/reset";
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

        /// <summary>
        /// Async method implementation for Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<bool> Login(LoginModel login)
        {
            if (CheckEmail(login.Email))
            {
                if (CheckPassword(login.Email, login.Password))
                {
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
            }

            return false;
        }

        /// <summary>
        /// method for checking email id exists or not.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
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

        /// <summary>
        /// checking whether password is correct or not 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Async method implementation for Registering
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Async method implementation for ResetPassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        public async Task<string> ResetPassword(ResetPassword resetPassword)
        {
            JwtSettings jwt = new JwtSettings();
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwt.Secret"));
            var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(expires: DateTime.Now.AddDays(1), signingCredentials: credential);
            string password = resetPassword.Password;
            RegisterModel registerModel = this.context.Accountregister.Where<RegisterModel>(option =>
              option.Password == password).FirstOrDefault();
            if (registerModel != null)
            {
                string pass = resetPassword.ConfirmPassword;
                registerModel.Password = pass;
                this.context.Update(registerModel);
                await Task.Run(() => this.context.SaveChangesAsync());
                return "success";
            }
            return null;
        }
    }
}