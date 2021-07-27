using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Mappings
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Parcela).HasColumnName("integer").IsRequired();
            builder.Property(p => p.Valor).HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(p => p.Codigo).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Nome).HasColumnType("Varchar(100)").IsRequired();

       
         


        }
    }
}
