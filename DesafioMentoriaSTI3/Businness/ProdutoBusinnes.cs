using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{
    class ProdutoBusinnes
    {

        private readonly DesafioContext _context;

        public ProdutoBusinnes()
        {
            _context = new DesafioContext();
        }

        public void AdicionarProdutos(ProdutoModel produtoModel)
        {

            var produtos = new Produto
            {
                Id = produtoModel.Id,
                Nome = produtoModel.Nome,
                Valor =produtoModel.Valor
            };


            if (_context.Produtos.Any(p => p.Id == produtos.Id))
            {
                return;
            }
            else
            {
                _context.Produtos.Add(produtos);
                _context.SaveChanges();
            }





        }
    }
}
