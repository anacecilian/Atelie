using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class EncomendaServico
    {
        private readonly MaterialServico materialServico;

        public EncomendaServico()
        {
            materialServico = new MaterialServico();
        }

        public List<Encomenda> Pesquisa(int ClienteId, DateTime Data)
        {
            List<Encomenda> encomendas = new List<Encomenda>();
            encomendas.Add(new Encomenda
            {
                ClienteId = 1
                ,
                DataEntregaPrevista = DateTime.Now
                ,
                Descricao = "xxx"
                ,
                Id = 1
                ,
                Preco = 50
                ,
                Materiais = materialServico.PesquisaPorEncomenda(1)
            });
            return encomendas;
        }

        public Encomenda RetornaEncomenda(int ClienteId, int EncomendaId)
        {
            return new Encomenda
            {
                ClienteId = 1
                ,
                DataEntregaPrevista = DateTime.Now
                ,
                Descricao = "xxx"
                ,
                Id = 1
                ,
                Preco = 50
                ,
                Materiais = materialServico.PesquisaPorEncomenda(1)
            };
        }

        public bool Salvar(Encomenda encomenda)
        {
            return true;
        }
    }
}
