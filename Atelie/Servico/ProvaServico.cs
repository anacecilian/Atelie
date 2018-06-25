using Atelie.Entidades;
using Atelie.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class ProvaServico
    {
        public List<EncomendaProva> Pesquisa(int EncomendaId)
        {
            List<EncomendaProva> Provas = new List<EncomendaProva>();
            Provas.Add(new EncomendaProva { Id = 1, EncomendaId = 1, Anotacao = "tudo certo", Data = DateTime.Now });
            Provas.Add(new EncomendaProva { Id = 2, EncomendaId = 1, Anotacao = "tudo ok", Data = DateTime.Now });

            return Provas;
        }

        public List<ProvaModelo> ObterListagem(int ClienteId, DateTime Data)
        {
            List<ProvaModelo> Provas = new List<ProvaModelo>();
            Provas.Add(new ProvaModelo { NomeCliente = "Ana", Data = DateTime.Now });
            Provas.Add(new ProvaModelo { NomeCliente = "Julia", Data = DateTime.Now });

            return Provas;
        }
    }
}
