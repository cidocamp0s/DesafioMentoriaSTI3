using DesafioMentoriaSTI3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Mappings
{
    public class EnderecoEntregaMapping : IEntityTypeConfiguration<EnderecoEntrega>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntrega> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Endereco).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.Bairro).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Cidade).HasColumnType("Varchar(100)").IsRequired();
            builder.Property(p => p.Cep).HasColumnType("varchar(8)").IsRequired();
            builder.Property(p => p.Complemento).HasColumnType("Varchar(100)").IsRequired();
            builder.Property(p => p.Estado).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Numero).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.Referencia).HasColumnType("varchar(100)").IsRequired();

       


        }
    }
}
