using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Mappings
{
    public class ItensPedidoMapping : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(EntityTypeBuilder<ItensPedido> builder)
        {
            builder.HasKey(p=>p.Id);

           
            builder.Property(p => p.Nome).HasColumnType("varchar(100)");
            builder.Property(p => p.Quantidade).HasColumnType("double").IsRequired();
            builder.Property(p => p.ValorUnitario).HasColumnType("decimal(15,2)");
           


        }
    }
}
