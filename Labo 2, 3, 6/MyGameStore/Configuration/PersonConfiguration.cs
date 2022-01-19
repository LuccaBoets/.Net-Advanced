using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
              .ToTable("tblPeople", "Person")
              .HasKey(x => x.id);

            builder.Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("nvarchar");

            builder.Property(x => x.LastName)
                .HasMaxLength(70)
                .IsRequired()
                .HasColumnType("nvarchar");

            builder.Property(x => x.Email)
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .HasColumnName("EmailAddress");
        }
    }
}
