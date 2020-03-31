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
                bool result =await  this.accountManager.Login(loginModel);
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
        [Route ("api/forget")]
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
    }
}
