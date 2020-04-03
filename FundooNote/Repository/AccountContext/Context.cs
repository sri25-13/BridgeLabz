// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Context.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.AccountContext
{
    using Microsoft.EntityFrameworkCore;
    using Model.Account;

    /// <summary>
    /// context class for database connection
    /// </summary>
    public  class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        {
        }
        public DbSet<RegisterModel> Accountregister { get; set; }
    }
}