using BookStoreCommonLayer;
using BookStoreCommonLayer.AccountModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreRepository.BookStoreContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        {
        }
        public DbSet<RegisterModel> Accountregister { get; set; }
        public DbSet<AddBookModel> Books { get; set; }
    }
}
