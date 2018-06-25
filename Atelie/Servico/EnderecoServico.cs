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
        public Endereco PesquisaPorCEP(string CEP)
        {
            return new Endereco
            {
                Bairro = "Colina Verde",
                CEP = "17023-003",
                Id = 1,
                Logradouro = "Rua José"
            };
        }
    }
}
