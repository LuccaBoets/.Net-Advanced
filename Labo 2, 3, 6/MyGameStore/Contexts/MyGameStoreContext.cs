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


            for (int i = 0; i < 20; i++)
            {
                modelBuilder.Entity<Person>().HasData(new Person() { id = i, FirstName = Faker.Name.First(), LastName = Faker.Name.Last(), Email = Faker.Internet.Email() });

            }


        }
    }
}
