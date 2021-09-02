using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Data.Mappings
{
    class ProviderMapping : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("Varchar(200)");

            builder.Property(p => p.Document)
                .IsRequired()
                .HasColumnType("Varchar(14)");

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Adress)
                .WithOne(e => e.Provider);

            // 1 : N => Fornecedor : Produtos
            builder.HasMany(p => p.Products)
                .WithOne(p => p.Provider)
                .HasForeignKey(p => p.ProviderId);

            builder.ToTable("Fornecedores");
        }
    }
}
