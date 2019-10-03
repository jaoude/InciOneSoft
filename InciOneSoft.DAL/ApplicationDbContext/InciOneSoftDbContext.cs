using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InciOneSoft.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InciOneSoft.DAL.DBContext
{
    public class InciOneSoftDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<FileInfo> FileInfos { get; set; }
        public DbSet<FileData> FileDatas { get; set; }


        public InciOneSoftDbContext(DbContextOptions<InciOneSoftDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            // seed the database with dummy data

            builder.Entity<Person>().HasData(
                new Person()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Sassine",
                    LastName = "Abou-Jaoude"
                },
                new Person()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Anthony",
                    LastName = "Khalife"
                },
                new Person()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Marc",
                    LastName = "Abou Rjeili"
                });

            

            base.OnModelCreating(builder);
        }
    }
}
