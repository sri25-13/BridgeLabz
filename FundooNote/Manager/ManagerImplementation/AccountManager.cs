// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.ManagerImplementation
{
    using Manager.ManagerInterface;
    using Model.Account;
    using Repository.RepositoryInterface;
    using System.Threading.Tasks;

    /// <summary>
    /// Manager class for Account 
    /// </summary>
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository accountRepository;

        public AccountManager()
        {
        }

        /// <summary>
        /// constructor for AccountManager
        /// </summary>
        /// <param name="repository"></param>
        public AccountManager(IAccountRepository repository)
        {
            this.accountRepository = repository;
        }

        /// <summary>
        /// async method for EmailLogin
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<bool> EmailLogin(LoginModel login)
        {
            return await this.accountRepository.EmailLogin(login);
        }

        /// <summary>
        /// async method for FacebookLogin
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<RegisterModel> FacebookLogin(LoginModel login)
        {
            return await this.accountRepository.FacebookLogin(login);
        }

        /// <summary>
        /// async method for ForgotPassword
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        public async Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            return await this.accountRepository.ForgotPassword(forgotPassword);
        }

        /// <summary>
        /// async method for Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<bool> Login(LoginModel login)
        {
            return await this.accountRepository.Login(login);
        }

        /// <summary>
        /// async method for registering
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        public async Task<bool> Register(RegisterModel register)
        {
            await this.accountRepository.RegisterAccount(register);
            return true;
        }

        /// <summary>
        /// async method for ResetPassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        public async Task<string> ResetPassword(ResetPassword resetPassword)
        {
            return await this.accountRepository.ResetPassword(resetPassword);
        }
    }
}
