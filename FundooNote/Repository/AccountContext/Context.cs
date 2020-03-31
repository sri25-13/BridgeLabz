using Microsoft.EntityFrameworkCore;
using Model.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.AccountContext
{
  public  class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<RegisterModel> Accountregister { get; set; }
    }
}

