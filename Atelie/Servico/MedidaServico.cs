using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    class MedidaServico
    {
        public List<ClienteMedida> PesquisaPorCliente(int ClienteId)
        {
            List<ClienteMedida> Medidas = new List<ClienteMedida>();
            Medidas.Add(new ClienteMedida { Id = 1, Tipo = Enumeradores.TipoMedidaCliente.AlturaBusto, Valor = 30, ClienteId = 1 });
            Medidas.Add(new ClienteMedida { Id = 2, Tipo = Enumeradores.TipoMedidaCliente.ComprimentoCalca, Valor = 60, ClienteId = 1 });

            return Medidas;
        }
    }
}
