using DesafioMentoriaSTI3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p =>p.Id);

            builder.Property(p => p.Nome).HasColumnType("Varchar(200)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("Varchar(200)");
            builder.Property(p => p.DataNascimento).HasColumnType("Datetime").IsRequired();
            builder.Property(p => p.RazaoSocial).HasColumnType("Varchar(250)");
            builder.Property(p => p.Cnpj).HasColumnType("Varchar(200)");
            builder.Property(p => p.Cpf).HasColumnType("Varchar(11)");


            
        }
    }
}
