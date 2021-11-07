﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibApp2.Models;

namespace LibApp2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
