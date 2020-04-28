// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.RepositoryInterface
{
    using FundooModel.Account;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for AccountRepository
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// method for registering
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        Task<int> RegisterAccount(RegisterModel register);

        /// <summary>
        /// Login Method
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        string Login(LoginModel login);

        /// <summary>
        /// Method for ForgotPassword
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        Task<string> ForgotPassword(ForgotPassword forgotPassword);

        /// <summary>
        /// Method for ResetPassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        Task<string> ResetPassword(ResetPassword resetPassword);

        /// <summary>
        /// Method for EmailLogin
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<string> EmailLogin(LoginModel login);

        /// <summary>
        /// Method for Logging In Facebook
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<string> FacebookLogin(LoginModel login);
    }
}
