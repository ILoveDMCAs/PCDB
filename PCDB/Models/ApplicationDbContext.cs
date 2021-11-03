﻿using Microsoft.AspNet.Identity.EntityFramework;
using PCDB.Models.Components;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PCDB.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<CPU>().ToTable("CPU");
            modelBuilder.Entity<CPUCooler>().ToTable("CPUCooler");
            modelBuilder.Entity<Memory>().ToTable("Memory");
            modelBuilder.Entity<Storage>().ToTable("Storage");
        }

        public DbSet<Component> Components { get; set; }
        public DbSet<CPU> CPU { get; set; }
        public DbSet<CPUCooler> CPUCooler { get; set; }
        public DbSet<Memory> Memory { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}