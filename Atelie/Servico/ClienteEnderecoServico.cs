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

        public ClienteEnderecoServico()
        {
            enderecoServico = new EnderecoServico();
        }

        public ClienteEndereco PesquisaPorCliente(int ClienteId)
        {
            return new ClienteEndereco
            {
                Complemento = "apto 8",
                Endereco = enderecoServico.PesquisaPorCEP(string.Empty),
                Numero = "1-87"
            };
        }
    }
}
