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
        public List<EncomendaMaterial> PesquisaPorEncomenda(int EncomendaId)
        {
            List<EncomendaMaterial> Materiais = new List<EncomendaMaterial>();
            Materiais.Add(new EncomendaMaterial { Id = 1, Detalhes = "m1", EncomendaId = 1, Quantidade = 3, UnidadeMedida = "metros" });
            Materiais.Add(new EncomendaMaterial { Id = 2, Detalhes = "m2", EncomendaId = 1, Quantidade = 1, UnidadeMedida = "unidade" });

            return Materiais;
        }
    }
}
