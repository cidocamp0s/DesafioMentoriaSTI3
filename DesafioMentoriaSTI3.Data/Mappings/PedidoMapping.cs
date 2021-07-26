using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Mappings
{
    class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Numero).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.DataCriacao).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.DataAlteracao).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.Status).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Desconto).HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(p => p.Frete).HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(p => p.SubTotal).HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(p => p.ValorTotal).HasColumnType("decimal(15,2)").IsRequired();


            //builder.HasMany(i => i.Itens).WithOne(p => p.Pedido);
            ////builder.HasOne(i => i.Cliente).WithMany(p => p.Pedido);
            //////builder.HasOne(i => i.EnderecoEntrega).WithMany(p => p.Pedido);
            ////builder.HasOne(i => i.Pagamento).WithOne(p => p.Pedido);


        }
    }
}
