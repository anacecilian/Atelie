using Atelie.BancoDeDados;
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
        private const string nomeTabelaProva = "table_prova";
        private const string nomeTabelaCliente = "table_cliente";
        private const string nomeCampoEncomendaCod = "encomendacod";
        private const string nomeCampoProvaData = "dia";
        private const string nomeCampoProvaId = "id";
        private const string nomeCampoProvaHorario = "horario";
        private const string nomeCampoProvaAnotacao = "anotacao";

        private readonly DAO dao;
        private readonly ClienteServico clienteServico;
        private readonly EncomendaServico encomendaServico;

        public ProvaServico()
        {
            dao = new DAO();
            clienteServico = new ClienteServico();
        }

        public List<EncomendaProva> Pesquisa(int EncomendaId)
        {
            List<EncomendaProva> Provas = new List<EncomendaProva>();

            List<string> filtros = new List<string>();

            if (!String.IsNullOrEmpty(EncomendaId.ToString()))
                filtros.Add(nomeCampoEncomendaCod + " = " + EncomendaId.ToString());

            string filtro = string.Join(" AND ", filtros.ToArray());

            var result = dao.Select(nomeTabelaProva, filtro);

            if (result != null)
            {
                foreach (Dictionary<string, string> entity in result)
                {
                    Provas.Add(LinhaParaEntidade(entity));
                }
            }

            return Provas;
        }

        public List<ProvaModelo> ObterListagem(int ClienteId, DateTime Data)
        {
            List<ProvaModelo> Provas = new List<ProvaModelo>();
            //EncomendaProva prova = new EncomendaProva();
            //Encomenda encomenda = new Encomenda();
            //ProvaModelo modelo = new ProvaModelo();
            //Cliente cliente = new Cliente();

            //List<string> filtros = new List<string>();

            //if (Data != null)
            //    filtros.Add(nomeCampoProvaData + " = " + Data.ToShortDateString());

            //string filtro = string.Join(" AND ", filtros.ToArray());

            //var result = dao.Select(nomeTabelaProva, filtro);

            //foreach (Dictionary<string, string> entity in result)
            //{
            //    prova = LinhaParaEntidade(entity);

            //    modelo = new ProvaModelo();
            //    encomenda = encomendaServico.RetornaEncomenda()

            //    Provas.Add();
            //}

            return Provas;
        }

        private EncomendaProva LinhaParaEntidade(Dictionary<string, string> entity)
        {
            string data = string.Empty;
            string hora = string.Empty;
            EncomendaProva retorno = new EncomendaProva();
            foreach (KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoEncomendaCod:
                        retorno.EncomendaId = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoProvaAnotacao:
                        retorno.Anotacao = atributo.Value;
                        break;
                    case nomeCampoProvaData:
                        data = atributo.Value;
                        break;
                    case nomeCampoProvaHorario:
                        hora = atributo.Value;
                        break;
                    case nomeCampoProvaId:
                        retorno.Id = Convert.ToInt32(atributo.Value);
                        break;
                }
            }

            retorno.Data = DateTime.Parse(data + " " + hora);

            return retorno;
        }
    }
}
