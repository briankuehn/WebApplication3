﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class AspNetCoreIdentityDbContext : IdentityDbContext
    {
        public AspNetCoreIdentityDbContext(DbContextOptions<AspNetCoreIdentityDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }

}
