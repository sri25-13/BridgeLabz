using BookStoreCommonLayer.AccountModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManager.ManagerInterfaces
{
   public interface IAccountManager
    {
        Task register(RegisterModel model);
        Task<string> Login(LoginModel loginModel);
    }
}
