using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Context
{
    public class DesafioContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localHost; port=3306; user=root; password=248169; database=DesafioMentoriaSTI3;")
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .LogTo(x => Debug.WriteLine(x));

            base.OnConfiguring(optionsBuilder);

        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<EnderecoEntrega> EnderecosEntregas { get; set; }
        public virtual DbSet<ItensPedido> ItensPedidos{ get; set; }
        public virtual DbSet<Pagamento>Pagamentos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());

            modelBuilder.ApplyConfiguration(new EnderecoEntregaMapping()) ;

            modelBuilder.ApplyConfiguration(new ItensPedidoMapping());

            modelBuilder.ApplyConfiguration(new ProdutoMapping());

            modelBuilder.ApplyConfiguration(new PedidoMapping());

            modelBuilder.ApplyConfiguration(new PagamentoMapping());     



            base.OnModelCreating(modelBuilder);
        }
    }
}
