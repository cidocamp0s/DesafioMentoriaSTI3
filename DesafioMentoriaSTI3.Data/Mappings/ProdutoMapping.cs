﻿using DesafioMentoriaSTI3.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p=>p.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Valor).HasColumnType("decimal(15,2)").IsRequired();


        }
    }
}
