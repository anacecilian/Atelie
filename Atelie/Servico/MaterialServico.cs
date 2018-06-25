using Atelie.BancoDeDados;
using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class MaterialServico
    {
        private const string nomeTabelaMaterial = "table_material";
        private const string nomeCampoEncomendaCod = "encomendacod";
        private const string nomeCampoDescricao = "descricao";
        private const string nomeCampoQuantidade = "quantidade";
        private const string nomeCampoId = "id";
        private const string nomeCampoUniMedida = "uni_medida";

        private readonly DAO dao;

        public MaterialServico()
        {
            dao = new DAO();
        }

        public List<EncomendaMaterial> PesquisaPorEncomenda(int EncomendaId)
        {
            List<EncomendaMaterial> Materiais = new List<EncomendaMaterial>();

            List<string> filtros = new List<string>();

            if (!String.IsNullOrEmpty(EncomendaId.ToString()))
                filtros.Add(nomeCampoEncomendaCod + " = " + EncomendaId.ToString());

            string filtro = string.Join(" AND ", filtros.ToArray());

            var result = dao.Select(nomeTabelaMaterial, filtro);

            if (result != null)
            {
                foreach (Dictionary<string, string> entity in result)
                {
                    Materiais.Add(LinhaParaEntidade(entity));
                }
            }

            return Materiais;
        }

        private EncomendaMaterial LinhaParaEntidade(Dictionary<string, string> entity)
        {
            EncomendaMaterial retorno = new EncomendaMaterial();
            foreach (KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoEncomendaCod:
                        retorno.EncomendaId = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoId:
                        retorno.Id = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoQuantidade:
                        retorno.Quantidade = Convert.ToDecimal(atributo.Value);
                        break;
                    case nomeCampoDescricao:
                        retorno.Detalhes = atributo.Value;
                        break;
                    case nomeCampoUniMedida:
                        retorno.UnidadeMedida = atributo.Value;
                        break;
                }
            }
            return retorno;
        }
    }
}
