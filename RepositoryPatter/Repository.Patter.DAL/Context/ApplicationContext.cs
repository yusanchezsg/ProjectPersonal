using Microsoft.EntityFrameworkCore;
using Repository.Patter.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Patter.DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            _ = Database.EnsureCreated();
        }

        public DbSet<Products> Products { get; set; }
    }
}
