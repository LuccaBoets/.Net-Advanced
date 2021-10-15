using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder
              .ToTable("tblStores", "Store")
              .HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(30).IsRequired().HasColumnType("nvarchar");
            builder.Property(x => x.Street).HasMaxLength(60).IsRequired().HasColumnType("nvarchar");
            builder.Property(x => x.Number).HasMaxLength(5).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.Addition).HasMaxLength(3).HasColumnType("nvarchar");
            builder.Property(x => x.Zipcode).HasMaxLength(6).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.city).HasMaxLength(60).HasColumnType("nvarchar").HasColumnName("PlaceTest");
        }
    }
}
