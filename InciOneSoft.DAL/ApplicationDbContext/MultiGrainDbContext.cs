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
        public DbSet<University> Universities { get; set; }
        public DbSet<Programm> Programms { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Course> Courses { get; set; }


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
                    FirstName = "George",
                    LastName = "Younes"
                });

            University usj = new University()
            {
                Id = Guid.NewGuid(),
                Name = "Université Saint Joseph",
                Address = "Beirut, Lebanon"
            };
            builder.Entity<University>().HasData(usj);

            Faculty engineering = new Faculty()
            {
                Id = Guid.NewGuid(),
                Name = "Engineering",
                Address = "Mar Roukoz, Lebanon",
                UniversityId = usj.Id
            };
            builder.Entity<Faculty>().HasData(engineering);

            Institution esib = new Institution()
            {
                Id = Guid.NewGuid(),
                Name = "ESIB",
                Address = "Mar Roukoz, Lebanon",
                FacultyId = engineering.Id
            };
            builder.Entity<Institution>().HasData(esib);

            Institution inci = new Institution()
            {
                Id = Guid.NewGuid(),
                Name = "INCI",
                Address = "Mar Roukoz, Lebanon",
                FacultyId = engineering.Id
            };
            builder.Entity<Institution>().HasData(inci);

            base.OnModelCreating(builder);
        }
    }
}
