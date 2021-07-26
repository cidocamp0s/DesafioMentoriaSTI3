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
                Endereco = enderecoEntregaModel.endereco,
                Bairro = enderecoEntregaModel.bairro,
                Cidade = enderecoEntregaModel.cidade,
                Estado = enderecoEntregaModel.estado,
                Cep = enderecoEntregaModel.cep,
                Numero = enderecoEntregaModel.numero,
                Complemento = enderecoEntregaModel.complemento,
                Referencia = enderecoEntregaModel.referencia

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
