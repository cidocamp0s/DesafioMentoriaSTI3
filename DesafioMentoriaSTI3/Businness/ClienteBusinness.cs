using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{

    public class ClienteBusinness
    {

        private readonly DesafioContext _context;

        public ClienteBusinness()
        {
            _context = new DesafioContext();
        }

        public void AdicionarCliente(ClienteModel clienteModel)
        {

            Cliente cliente = new Cliente
            {
                Id = clienteModel.Id,
                Cnpj = clienteModel.Cnpj,
                Cpf = clienteModel.Cpf,
                Email = clienteModel.Email,
                DataNascimento = clienteModel.DataNascimento,
                Nome = clienteModel.Nome,
                RazaoSocial = clienteModel.RazaoSocial

            };


            if (_context.Clientes.Any(p=>p.Id==cliente.Id))
            {
                return;
            }
            else
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
           


            

        }
    }
}
