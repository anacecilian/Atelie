using Atelie.BancoDeDados;
using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class EnderecoServico
    {
        private const string nomeTabelaEndereco = "table_endereco";
        private const string nomeCampoCEP = "CEP";
        private const string nomeCampoLogradouro = "logradouro";
        private const string nomeCampoBairro = "bairro";
        private const string nomeCampoId = "id";

        private readonly DAO dao;
        
        public EnderecoServico()
        {
            dao = new DAO();
        }

        public Endereco PesquisaPorCEP(string CEP)
        {
            var result = dao.Select(nomeTabelaEndereco, nomeCampoCEP + " = " + CEP);

            if (result != null && result.Count > 0)
                return LinhaParaEntidade(result.First());
            else
                return new Endereco();
        }

        private Endereco LinhaParaEntidade(Dictionary<string, string> entity)
        {
            Endereco retorno = new Endereco();
            foreach (KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoCEP:
                        retorno.CEP = atributo.Value;
                        break;
                    case nomeCampoLogradouro:
                        retorno.Logradouro = atributo.Value;
                        break;
                    case nomeCampoBairro:
                        retorno.Bairro = atributo.Value;
                        break;
                    case nomeCampoId:
                        retorno.Id = Convert.ToInt32(atributo.Value);
                        break;
                }
            }
            return retorno;
        }
    }
}
