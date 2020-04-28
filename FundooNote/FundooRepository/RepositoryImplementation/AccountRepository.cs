// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.RepositoryImplementation
{

    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using FundooModel.Account;
    using FundooRepository.FundooContext;
    using FundooRepository.RepositoryInterface;
    using StackExchange.Redis;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;
    using Experimental.System.Messaging;

    /// <summary>
    /// class for AccountRepository
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        public Context context;
        private readonly IConfiguration configuration;
        /// <summary>
        /// Parameterizedconstructor for AccountRepository
        /// </summary>
        /// <param name="context"></param>
        public AccountRepository(Context context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        //hav u recieved mail?

        /// <summary>
        /// Async method implementation for Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<string> EmailLogin(LoginModel login)
        {
            if (CheckEmail(login.Email))
            {
                if (CheckPassword(login.Email, login.Password))
                {
                    var key = configuration["Jwt:Key"];
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                    var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:url"],
                        audience: configuration["Jwt:url"],
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signInCr
                        );
                    var securityToken = new JwtSecurityTokenHandler().WriteToken(token);
                    var cacheKey = login.Email;
                    ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase data = multiplexer.GetDatabase();
                    data.StringSet(cacheKey, token.ToString());
                    data.StringGet(cacheKey);
                    await this.context.SaveChangesAsync();
                    return securityToken;
                }
            }
            return "invalid";
        }

        /// <summary>
        /// Async method implementation for FacebookLogin
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<string> FacebookLogin(LoginModel login)
        {
            if (CheckEmail(login.Email))
            {
                if (CheckPassword(login.Email, login.Password))
                {
                    var key = configuration["Jwt:Key"];
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                    var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:url"],
                        audience: configuration["Jwt:url"],
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signInCr
                        );
                    var securityToken = new JwtSecurityTokenHandler().WriteToken(token);
                    var cacheKey = login.Email;
                    ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase data = multiplexer.GetDatabase();
                    data.StringSet(cacheKey, token.ToString());
                    data.StringGet(cacheKey);
                    await this.context.SaveChangesAsync();
                    return securityToken;
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
            string email = forgotPassword.Email;
            var user = CheckEmail(forgotPassword.Email);
            if (user == true)
            {
                string message = forgotPassword.Email;
                MessageQueue queue;
                if (MessageQueue.Exists(@".\private$\queue"))
                {
                    queue = new MessageQueue(@".\private$\queue");
                }
                else
                {
                    queue = MessageQueue.Create(@".\private$\queue");
                }
                Message message1 = new Message
                {
                    Formatter = new BinaryMessageFormatter(),
                    Body = user,
                    Label = "msmqMessage"
                };
                if (message.Contains(email))
                {
                    message1.Priority = MessagePriority.High;
                }
                else
                {
                    message1.Priority = MessagePriority.Low;
                }
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
                using (var msg = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        smtp.Send(msg);
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
        public string Login(LoginModel login)
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
                    return FinalToken;
                }
            }

            return "invalid";
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
