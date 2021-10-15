using Microsoft.EntityFrameworkCore;
using MyGameStore.Configuration;
using MyGameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Contexts
{
    public class MyGameStoreContext : DbContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<Store> Stores { get; set; }

        public MyGameStoreContext(DbContextOptions<MyGameStoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());

            modelBuilder.Entity<Person>().HasData(new Person() { id = 1, FirstName = "Lucca", LastName = "Boets", Email = "lucca@itest.be" });
            modelBuilder.Entity<Person>().HasData(new Person() { id = 2, FirstName = "Cedric", LastName = "Martel", Email = "C@itest.be" });

        }
    }
}
