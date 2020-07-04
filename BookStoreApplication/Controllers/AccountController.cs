using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreCommonLayer;
using BookStoreCommonLayer.AccountModel;
using BookStoreManager.ManagerInterfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreApplication.Controllers
{
    
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager accountManager;

        public AccountController(IAccountManager manager)
        {
            this.accountManager = manager;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]RegisterModel registerModel)
        {
            try
            {
                await this.accountManager.register(registerModel);
                return this.Ok();
            }
            catch
            {
                return this.BadRequest();
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginModel loginModel)
        {
            try
            {
                string result = await this.accountManager.Login(loginModel);
                if (result != null)
                {
                    return this.Ok(new { Token = result });
                }
                else
                {
                    return BadRequest("invalid data");
                }
            }
            catch (Exception e)
            {
                var json = new Jsonmodel();
                json.ErrorMessage = "invalid details";
                json.ErrorCode = 400;
                return BadRequest(json);
                throw new Exception(e.Message);
            }
        }


    }
    
}