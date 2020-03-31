using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model.Account;
using System;

namespace FundooNote.Controllers
{
    public class AccountController :ControllerBase
    {
        private readonly IAccountManager accountManager;
        public AccountController(IAccountManager manager)
        {
            this.accountManager = manager;
        }
        [HttpPost]
        [Route ("api/register")]
        public ActionResult Register([FromBody]RegisterModel register)
        {
            try
            {
                var result = this.accountManager.Register(register);
                return Ok(register);
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
        [HttpPost]
        [Route ("api/login")]
        public ActionResult Login([FromBody]LoginModel loginModel)
        {
            try
            {
                var result = accountManager.Login(loginModel);
                if(result)
                {
                    return true;
                }
                return false;
                
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
