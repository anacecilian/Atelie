using Atelie.BancoDeDados;
using Atelie.Entidades;
using Atelie.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class MedidaServico
    {
        private readonly DAO dao;

        private const string nomeTabelaMedida = "table_medida";
        private const string nomeCampoClienteId = "clientecod";
        private const string nomeCampoId = "id";
        private const string nomeCampoTipo = "tipo";
        private const string nomeCampoMedida = "medida";

        public MedidaServico()
        {
            dao = new DAO();
        }

        public List<ClienteMedida> PesquisaPorCliente(int ClienteId)
        {
            List<ClienteMedida> Medidas = new List<ClienteMedida>();

            List<string> filtros = new List<string>();

            if (!String.IsNullOrEmpty(ClienteId.ToString()))
                filtros.Add(nomeCampoClienteId + " = " + ClienteId.ToString());

            string filtro = string.Join(" AND ", filtros.ToArray());

            var result = dao.Select(nomeTabelaMedida, filtro);

            if (result != null)
            {
                foreach (Dictionary<string, string> entity in result)
                {
                    Medidas.Add(LinhaParaEntidade(entity));
                }
            }

            return Medidas;
        }

        private ClienteMedida LinhaParaEntidade(Dictionary<string, string> entity)
        {
            ClienteMedida retorno = new ClienteMedida();
            foreach (KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoClienteId:
                        retorno.ClienteId = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoId:
                        retorno.Id = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoMedida:
                        retorno.Valor = Convert.ToDecimal(atributo.Value);
                        break;
                    case nomeCampoTipo:
                        retorno.Tipo = (TipoMedidaCliente)Convert.ToInt32(atributo.Value);
                        break;
                }
            }
            return retorno;
        }
    }
}
