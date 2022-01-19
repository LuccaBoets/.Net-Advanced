using Microsoft.EntityFrameworkCore;
using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Context
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>()
            //    .ToTable("tblPerson", "dbo")
            //    .HasKey(p => p.id);

            //modelBuilder.Entity<Person>()
            //    .Property(p => p.FirstName)
            //    .IsRequired()
            //    .HasColumnName("FirstName")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(80);

            //modelBuilder.Entity<Person>()
            //        .Property(p => p.LastName)
            //        .IsRequired()
            //        .HasColumnName("LastName")
            //        .HasColumnType("nvarchar")
            //        .HasMaxLength(80);

            //modelBuilder.Entity<Person>()
            //    .Property(p => p.mail)
            //    .IsRequired()
            //    .HasColumnName("Mail")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(80);

            //modelBuilder.Entity<Person>()
            //    .Property(p => p.gender)
            //    .IsRequired()
            //    .HasColumnName("Gender")
            //    .HasColumnType("smallint")
            //    .HasMaxLength(80);

        }
    }
}
