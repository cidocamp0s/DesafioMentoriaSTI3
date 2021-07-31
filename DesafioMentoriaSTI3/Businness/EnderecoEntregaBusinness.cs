using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{
    public class EnderecoEntregaBusinness
    {
        private readonly DesafioContext _context;

        public EnderecoEntregaBusinness()
        {
            _context = new DesafioContext();
        }

        public void AdicionarEndereco(EnderecoEntregaModel enderecoEntregaModel)
        {

            EnderecoEntrega enderecoEntrega = new EnderecoEntrega
            {
               Id = enderecoEntregaModel.Id,
                Endereco = enderecoEntregaModel.Endereco,
                Bairro = enderecoEntregaModel.Bairro,
                Cidade = enderecoEntregaModel.Cidade,
                Estado = enderecoEntregaModel.Estado,
                Cep = enderecoEntregaModel.Cep,
                Numero = enderecoEntregaModel.Numero,
                Complemento = enderecoEntregaModel.Complemento,
                Referencia = enderecoEntregaModel.Referencia
            };


            if (_context.EnderecosEntregas.Any(p => p.Id == enderecoEntrega.Id))
            {
                return;
            }
            else
            {
                _context.EnderecosEntregas.Add(enderecoEntrega);
                _context.SaveChanges();
            }


        }
    }
}
