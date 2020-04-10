// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Tests.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNoteTesting
{
    using Manager.ManagerImplementation;
    using Model.Account;
    using NUnit.Framework;

    /// <summary>
    /// class for NunitTesting of Fundoo
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// TestMethod for Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            LoginModel login = new LoginModel();
            login.Email = "sriharshinirao25@gmail.com";
            login.Password = "harshini@25@";
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.Login(login));
        }

        /// <summary>
        /// Test Method for Registering
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            RegisterModel register = new RegisterModel();
            register.Firstname = "ab";
            register.Lastname = "abc";
            register.Email = "abcd@gmail.com";
            register.Password = "abcd";
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.Register(register));
        }

        /// <summary>
        /// TestMethod for ForgotPassword
        /// </summary>
        [Test]
        public void ForgotPasswordTest()
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Email = "sriharshinirao25@gmail.com";
            var result = new AccountManager();
            Assert.IsNotNull(result.ForgotPassword(forgot));
        }

        /// <summary>
        /// Test Method for ResetPassword
        /// </summary>
        [Test]
        public void ResetPasswordTest()
        {
            ResetPassword reset = new ResetPassword()
            {
                Email = "ab@gmail.com",
                Password = "abc",
                NewPassword = "ab",
                ConfirmPassword = "ab"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.ResetPassword(reset));
        }

        /// <summary>
        /// Test Method for EmailLogin
        /// </summary>
        [Test]
        public void EmailLoginTest()
        {
            LoginModel login = new LoginModel()
            {
                Email = "ab@gmail.com",
                Password = "ab"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.EmailLogin(login));
        }

        /// <summary>
        /// Test Method for LoggingIn Facebook
        /// </summary>
        [Test]
        public void FaceBookLoginTest()
        {
            LoginModel login = new LoginModel()
            {
                Email = "ab@gmail.com",
                Password = "ab"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.FacebookLogin(login));
        }
    }
}