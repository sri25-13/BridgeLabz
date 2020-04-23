// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNote.Controllers
{
    using FundooManager.ManagerInterface;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using FundooModel.Account;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// controller class for Fundoo
    /// </summary>
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager accountManager;
        public AccountController(IAccountManager manager)
        {
            this.accountManager = manager;
        }


        /// <summary>
        /// Controllermethod for EmailLogin
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("emaillogin")]
        public async Task<IActionResult> EmailLogin([FromBody]LoginModel loginModel)
        {
            try
            {
                bool result = await this.accountManager.EmailLogin(loginModel);
                if (result)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// method for Registering
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody]RegisterModel register)
        {
            try
            {
                var result = this.accountManager.Register(register);
                return Ok(register);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// controller method for login
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody]LoginModel loginModel)
        {
            try
            {
                string result = this.accountManager.Login(loginModel);
                if (result != null)
                {
                    return this.Ok(result);
                }
                else
                {
                    return BadRequest("invalid data");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Controller method  implementation for forgotpassword
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        [HttpPut]

        [Route("forget")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPassword forgotPassword)
        {
            try
            {
                var result = await this.accountManager.ForgotPassword(forgotPassword);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        /// <summary>
        /// Controller method  implementation for resetpassword
        /// </summary>
        /// <param name="resetPassword"></param>
        /// <returns></returns>
        [HttpPut]

        [Route("reset")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword resetPassword)
        {
            try
            {
                var result = await this.accountManager.ResetPassword(resetPassword);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// method for loggingIn Facebook
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("fblogin")]
        public async Task<IActionResult> FacebookLogin([FromBody] LoginModel login)
        {
            try
            {
                var result = await this.accountManager.FacebookLogin(login);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
