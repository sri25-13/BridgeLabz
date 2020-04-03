// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNote.Controllers
{
    using Manager.ManagerInterface;
    using Microsoft.AspNetCore.Mvc;
    using Model.Account;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// controller class for Fundoo
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
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
        [Route("api/emaillogin")]
        public async Task<ActionResult> EmailLogin([FromBody]LoginModel loginModel)
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
        [Route("api/register")]
        public ActionResult Register([FromBody]RegisterModel register)
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
        [Route("api/login")]
        public async Task<ActionResult> Login([FromBody]LoginModel loginModel)
        {
            try
            {
                bool result = await this.accountManager.Login(loginModel);
                if (result)
                {
                    return this.Ok("login successfull");
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
        [Route("api/forget")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPassword forgotPassword)
        {
            try
            {
                var result = await this.accountManager.ForgotPassword(forgotPassword);
                return Ok(result);
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
        [Route("api/reset")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword resetPassword)
        {
            try
            {
                var result = await this.accountManager.ResetPassword(resetPassword);
                return Ok(result);
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
        [Route("api/fblogin")]
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