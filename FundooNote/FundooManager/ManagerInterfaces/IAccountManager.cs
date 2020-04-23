// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.ManagerInterface
{
    using FundooModel.Account;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for AccountManager
    /// </summary>
    public interface IAccountManager
    {
        /// <summary>
        /// method for registeration
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        Task<bool> Register(RegisterModel register);

        /// <summary>
        /// Method for LoggingIn.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        string Login(LoginModel login);

        /// <summary>
        /// ForgotPassword method.
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
        /// Method for LoggingIn email.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<bool> EmailLogin(LoginModel login);

        /// <summary>
        /// Method for Facebooklogin
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<RegisterModel> FacebookLogin(LoginModel login);
    }
}
