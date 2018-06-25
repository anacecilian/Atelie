using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.BancoDeDados
{
    class ClienteDAO
    {
        public List<Cliente> ClientesREP
        {
            get
            {
                List<Cliente> clientes = new List<Cliente>();
                clientes.Add(new Cliente { Id = 45, Nome = "Ana", Telefone = "(14) 3567-9876", CPF = "9988766544", DataCadastro = DateTime.Now, ClienteEndereco = new ClienteEndereco { Endereco = EnderecoREP[0], Complemento = "apto 3", Numero = "45" }, Medidas = MedidasREP.Where(x => x.ClienteId == 45).ToList()});
                clientes.Add(new Cliente { Id = 67, Nome = "Julia", Telefone = "(14) 3256-9896", CPF = "126987566", DataCadastro = DateTime.Now, ClienteEndereco = new ClienteEndereco { Endereco = EnderecoREP[1], Complemento = "", Numero = "9" }, Medidas = MedidasREP.Where(x => x.ClienteId == 67).ToList() });
                return clientes;
            }
        }

        public List<ClienteMedida> MedidasREP
        {
            get
            {
                List<ClienteMedida> medidas = new List<ClienteMedida>();
                medidas.Add(new ClienteMedida { Id = 98, Tipo = Enumeradores.TipoMedidaCliente.AlturaBusto, Valor = 76, ClienteId = 45});
                medidas.Add(new ClienteMedida { Id = 33, Tipo = Enumeradores.TipoMedidaCliente.Busto, Valor = 99, ClienteId = 45});
                medidas.Add(new ClienteMedida { Id = 77, Tipo = Enumeradores.TipoMedidaCliente.Cintura, Valor = 80, ClienteId = 67 });
                medidas.Add(new ClienteMedida { Id = 12, Tipo = Enumeradores.TipoMedidaCliente.ComprimentoCalca, Valor = 100, ClienteId = 67 });
                return medidas;
            }
        }

        public List<Endereco> EnderecoREP
        {
            get
            {
                List<Endereco> enderecos = new List<Endereco>();
                enderecos.Add(new Endereco { Id = 23, Bairro = "Colina", CEP = "1111", Logradouro = "Rua José" });
                enderecos.Add(new Endereco { Id = 58, Bairro = "Monte Verde", CEP ="2222", Logradouro = "Av. Nações" });
                return enderecos;
            }
        }

        public List<Encomenda> EncomendaREP
        {
            get
            {
                List<Encomenda> encomendas = new List<Encomenda>();
                return encomendas;
            }
        }
    }
}
