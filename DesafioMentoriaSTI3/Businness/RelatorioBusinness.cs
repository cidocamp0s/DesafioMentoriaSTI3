using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace DesafioMentoriaSTI3.Businness
{

    class RelatorioBusinness
    {
        private readonly DesafioContext _context;

        public RelatorioBusinness()
        {
            _context = new DesafioContext();
        }

        public List<RelatorioModel> ListaPedidosRelatorioGeral()
        {

            var lista = _context.Pedidos.AsNoTracking().Select(p => new RelatorioModel
            {
                Numero = p.Numero,
                DataCriacao = p.DataCriacao,
                Cliente = _context.Clientes.AsNoTracking().Where(c => c.Id == p.Cliente.Id).Select(c => c.Nome).First(),
                Status = p.Status,
                ValorTotal = p.ValorTotal


            }).ToList().OrderBy(x => x.Numero).ToList();



            return lista;
        }

        public List<RelatorioModel> ListaPedidosRelatorioPorCliente(List<RelatorioModel> listaParaFiltrar, List<ClienteModel> ListaCLientes)
        {
            return listaParaFiltrar.Where(x => ListaCLientes.Any(t => t.Nome == x.Cliente)).ToList();
        }

        public List<RelatorioModel> ListaPedidosRelatorioPorStatus(List<RelatorioModel> listaStatus, List<RelatorioModel> listaParaFiltrar)
        {

         

           return listaParaFiltrar.Where(x => listaStatus.Any(t => t.Status == x.Status)).ToList();

           
        }

        public List<RelatorioModel> ListaPedidosRelatorioPorNumero(double numeroInicial, double numeroFInal, List<RelatorioModel> listaParaFiltrar)
        {

            var lista = listaParaFiltrar.Where(p => p.Numero >= numeroInicial && p.Numero <= numeroFInal).ToList();


            return lista;
        }

        public List<RelatorioModel> ListaPedidosRelatorioPorValor(decimal valorInicial, decimal valorFInal, List<RelatorioModel> listaParaFiltrar)
        {

            var lista = listaParaFiltrar.Where(p => p.ValorTotal >= valorInicial && p.ValorTotal <= valorFInal).ToList();



            return lista;
        }

        public List<RelatorioModel> ListaPedidosRelatorioPorData(DateTime dataInicial, DateTime dataFinal, List<RelatorioModel> listaParaFiltrar)
        {

            var lista = listaParaFiltrar.Where(p => p.DataCriacao >= dataInicial && p.DataCriacao <= dataFinal).ToList();



            return lista;
        }

        public List<RelatorioModel> ListaFiltrada(List<RelatorioModel> listaParaExibir)
        {

            var lista = listaParaExibir;



            return lista;
        }

        public List<RelatorioModel> Clientes()
        {
            return _context.Clientes.Select(s => new RelatorioModel
            {

                Cliente = s.Nome

            }).OrderBy(x => x.Cliente).ToList();
        }

        public List<RelatorioModel> ClientesChecados(List<ClienteModel> listaClientesChecados)
        {
            var lista = listaClientesChecados.Select(s => new RelatorioModel
            {

                Cliente = s.Nome
            }).ToList();

            return lista;


        }

        public List<RelatorioModel> StatusExistentes()
        {
            var lista = _context.Pedidos.GroupBy(x => new { x.Status }).Select(c => new { c.Key.Status }).ToList();

            var list = lista.Select(x => new RelatorioModel
            {

                Status = x.Status

            }).ToList();

            return list;


        }


    }



}

