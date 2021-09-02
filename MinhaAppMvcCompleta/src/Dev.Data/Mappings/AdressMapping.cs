using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Data.Mappings
{
    class AdressMapping : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(a => a.NameStreet)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.Number)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(a => a.Complement)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(a => a.CEP)
               .IsRequired()
               .HasColumnType("varchar(8)");

            builder.Property(a => a.District)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(a => a.City)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(a => a.State)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.ToTable("Adresses");


        }
    }
}
