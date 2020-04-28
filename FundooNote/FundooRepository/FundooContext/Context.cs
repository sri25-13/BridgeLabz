// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Context.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.FundooContext
{
    using Microsoft.EntityFrameworkCore;
    using FundooModel.Account;
    using FundooModel.Collaborators;
    using FundooModel.Label;
    using FundooModel.Notes;
    
    /// <summary>
    /// context class for database connection
    /// </summary>
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        {
        }
        public DbSet<RegisterModel> Accountregister { get; set; }
        public DbSet<Labelmodel> Labels { get; set; }
        public DbSet<NotesModel> Notes { get; set; }
        public DbSet<CollaboratorModel> Collaborators { get; set; }
    }
}
