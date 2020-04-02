using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model.Account;
using System;
using System.Threading.Tasks;

namespace FundooNote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager accountManager;
        public AccountController(IAccountManager manager)
        {
            this.accountManager = manager;
        }
        [HttpPost]
        [Route("api/emaillogin")]
        public ActionResult EmailLogin([FromBody]LoginModel loginModel)
        {
            try
            {
                var result = this.accountManager.EmailLogin(loginModel);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
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