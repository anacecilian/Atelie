using Atelie.BancoDeDados;
using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class ClienteEnderecoServico
    {
        private readonly EnderecoServico enderecoServico;
        private readonly DAO dao;

        private const string nomeCampoNumero = "numero";
        private const string nomeCampoComplemento = "complemento";
        private const string nomeTabelaClienteEndereco = "table_clienteendereco";
        private const string nomeCampoEnderecoCod = "enderecocod";
        private const string nomeCampoClienteCod = "clientecod";

        public ClienteEnderecoServico()
        {
            enderecoServico = new EnderecoServico();
            dao = new DAO();
        }

        public ClienteEndereco PesquisaPorCliente(int ClienteId)
        {
            List<string> campos = new List<string>();
           
            string filtro = nomeCampoClienteCod + " = " + ClienteId;

            var result = dao.Select(nomeTabelaClienteEndereco, filtro);

            if (result != null && result.Count > 0)
                return LinhaParaEntidade(result.First());
            else
                return new ClienteEndereco();
        }

        private ClienteEndereco LinhaParaEntidade(Dictionary<string, string> entity)
        {
            ClienteEndereco retorno = new ClienteEndereco();
            foreach(KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoNumero:
                        retorno.Numero = atributo.Value;
                        break;
                    case nomeCampoComplemento:
                        retorno.Complemento = atributo.Value;
                        break;
                    case nomeCampoEnderecoCod:
                        retorno.Endereco.Id = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoClienteCod:
                        retorno.ClienteId = Convert.ToInt32(atributo.Value);
                        break;
                }
            }
            return retorno;
        }
    }
}
