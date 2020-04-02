using Manager.ManagerImplementation;
using Model.Account;
using NUnit.Framework;

namespace FundooNoteTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void LoginTest()
        {
            LoginModel login = new LoginModel
            {
                Email = "sriharshinirao25@gmail.com",
                Password = "harshini@25@"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.Login(login));
        }

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
        [Test]
        public void ForgotPasswordTest()
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Email = "sriharshinirao25@gmail.com";
            var result = new AccountManager();
            Assert.IsNotNull(result.ForgotPassword(forgot));
        }
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

