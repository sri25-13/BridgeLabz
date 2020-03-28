using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model.Account;

namespace Repository.Context
{
   public class AccountContext:DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Register> Accountregister { get; set; }
    }
}

