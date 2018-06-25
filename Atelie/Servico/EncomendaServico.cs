using Atelie.BancoDeDados;
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
        private readonly ProvaServico provaServico;
        private readonly DAO dao;

        private const string nomeTabelaEncomenda = "table_encomenda";
        private const string nomeCampoDataEntregaPrev = "data_entrega_prevista";
        private const string nomeCampoPreco = "preco";
        private const string nomeCampoAnotacao = "anotacao";
        private const string nomeCampoDataEntregaEfet = "data_entrega_efetiva";
        private const string nomeCampoDataPagamento = "data_pagamento";
        private const string nomeCampoClienteId = "clientecod";
        private const string nomeCampoEncomendaId = "id";
        private const string nomeCampoEncomendaCod = "encomendacod";
        private const string nomeCampoProvaDia = "dia";
        private const string nomeCampoProvaAnotacao = "anotacao";
        private const string nomeCampoProvaHorario = "horario";
        private const string nomeTabelaProva = "table_prova";
        private const string nomeCampoMaterialDescricao = "descricao";
        private const string nomeCampoMaterialQuantidade = "quantidade";
        private const string nomeCampoMaterialUniMedida = "uni_medida";


        public EncomendaServico()
        {
            materialServico = new MaterialServico();
            provaServico = new ProvaServico();
            dao = new DAO();
        }

        public List<Encomenda> Pesquisa(int ClienteId, DateTime Data)
        {
            List<Encomenda> encomendas = new List<Encomenda>();
            List<string> filtros = new List<string>();

            if (!String.IsNullOrEmpty(ClienteId.ToString()))
                filtros.Add(nomeCampoClienteId + " = " + ClienteId.ToString());
            if (Data != null)
                filtros.Add(nomeCampoDataEntregaPrev + " = " + Data.ToString());

            string filtro = string.Join(" AND ", filtros.ToArray());

            var result = dao.Select(nomeTabelaEncomenda, filtro);

            if (result != null)
            {
                foreach (Dictionary<string, string> entity in result)
                {
                    encomendas.Add(LinhaParaEntidade(entity));
                }
            }

            return encomendas;
        }

        public Encomenda RetornaEncomenda(int ClienteId, int EncomendaId)
        {
            List<Encomenda> encomendas = new List<Encomenda>();
            List<string> filtros = new List<string>();

            if (!String.IsNullOrEmpty(ClienteId.ToString()))
                filtros.Add(nomeCampoClienteId + " = " + ClienteId.ToString());
            if (!String.IsNullOrEmpty(EncomendaId.ToString()))
                filtros.Add(nomeCampoEncomendaId + " = " + EncomendaId.ToString());

            string filtro = string.Join(" AND ", filtros.ToArray());

            var result = dao.Select(nomeTabelaEncomenda, filtro);

            if (result != null && result.Count > 0)
                return LinhaParaEntidade(result.First());
            else
                return new Encomenda();
        }

        public bool Salvar(Encomenda encomenda)
        {
            try
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();

                campos.Add(nomeCampoPreco);
                valores.Add(encomenda.Preco.ToString());

                campos.Add(nomeCampoAnotacao);
                valores.Add(encomenda.Descricao);

                campos.Add(nomeCampoDataPagamento);
                valores.Add(encomenda.DataPagamento.ToShortDateString());

                campos.Add(nomeCampoDataEntregaPrev);
                valores.Add(encomenda.DataEntregaPrevista.ToShortDateString());

                campos.Add(nomeCampoDataEntregaEfet);
                valores.Add(encomenda.DataEntregaEfetiva.ToShortDateString());

                campos.Add(nomeCampoClienteId);
                valores.Add(encomenda.ClienteId.ToString());

                dao.InsereLinha(nomeTabelaEncomenda, campos, valores);

                foreach (EncomendaProva prova in encomenda.Provas)
                {
                    campos = new List<string>();
                    valores = new List<string>();

                    campos.Add(nomeCampoEncomendaCod);
                    valores.Add(prova.EncomendaId.ToString());

                    campos.Add(nomeCampoProvaDia);
                    valores.Add(prova.Data.ToShortDateString());

                    campos.Add(nomeCampoProvaHorario);
                    valores.Add(prova.Data.ToShortTimeString());

                    campos.Add(nomeCampoProvaAnotacao);
                    valores.Add(prova.Anotacao);

                    dao.InsereLinha(nomeTabelaProva, campos, valores);
                }

                foreach (EncomendaMaterial material in encomenda.Materiais)
                {
                    campos = new List<string>();
                    valores = new List<string>();

                    campos.Add(nomeCampoMaterialDescricao);
                    valores.Add(material.Detalhes);

                    campos.Add(nomeCampoMaterialQuantidade);
                    valores.Add(material.Quantidade.ToString());

                    campos.Add(nomeCampoMaterialUniMedida);
                    valores.Add(material.UnidadeMedida);

                    campos.Add(nomeCampoEncomendaCod);
                    valores.Add(material.EncomendaId.ToString());

                    dao.InsereLinha(nomeTabelaProva, campos, valores);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Excluir(int encomendaId, int clienteId)
        {
            try
            {
                dao.ApagaLinha(nomeTabelaEncomenda, nomeCampoClienteId + " = " + clienteId + " AND " + nomeCampoEncomendaId + " = " + encomendaId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Encomenda LinhaParaEntidade(Dictionary<string, string> entity)
        {
            Encomenda retorno = new Encomenda();
            foreach (KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoEncomendaId:
                        retorno.Id = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoClienteId:
                        retorno.ClienteId = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoPreco:
                        retorno.Preco = Convert.ToDecimal(atributo.Value);
                        break;
                    case nomeCampoAnotacao:
                        retorno.Descricao = atributo.Value;
                        break;
                    case nomeCampoDataPagamento:
                        retorno.DataPagamento = DateTime.Parse(atributo.Value);
                        break;
                    case nomeCampoDataEntregaPrev:
                        retorno.DataEntregaPrevista = DateTime.Parse(atributo.Value);
                        break;
                    case nomeCampoDataEntregaEfet:
                        retorno.DataEntregaEfetiva = DateTime.Parse(atributo.Value);
                        break;
                }
            }

            retorno.Provas = provaServico.Pesquisa(retorno.Id);
            retorno.Materiais = materialServico.PesquisaPorEncomenda(retorno.Id);

            return retorno;
        }
    }
}
