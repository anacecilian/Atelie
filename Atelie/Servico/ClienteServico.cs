using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atelie.BancoDeDados;

namespace Atelie.Servico
{
    public class ClienteServico
    {
        private readonly MedidaServico medidaServico;
        private readonly DAO dao;

        private const string nomeCampoNome = "nome";
        private const string nomeCampoCPF = "CPF";
        private const string nomeCampoDataCadastro = "data_cadastro";
        private const string nomeCampoEnderecoId = "enderecoId";
        private const string nomeCampoIdCliente = "id";
        private const string nomeCampoCel = "cel_num";
        private const string nomeTabelaCliente = "table_cliente";
        private const string nomeTabelaEndereco = "table_endereco";

        private const string nomeCampoLogradouro = "logradouro";
        private const string nomeCampoBairro = "bairro";
        private const string nomeCampoCEP = "CEP";
        
        private const string nomeCampoNumero = "numero";
        private const string nomeCampoComplemento = "complemento";
        private const string nomeTabelaClienteEndereco = "table_clienteendereco";
        private const string nomeCampoEnderecoCod = "enderecocod";
        private const string nomeCampoClienteCod = "clientecod";


        public ClienteServico()
        {
            medidaServico = new MedidaServico();
            dao = new DAO("ateliecostura", "usr", "pss");
        }

        public bool Salvar(Cliente cliente)
        {
            try
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();

                //se não existir o endereço, salva o endereço
                if (cliente.ClienteEndereco.Endereco.Id <= 0)
                {
                    campos.Add(nomeCampoLogradouro);
                    valores.Add(cliente.ClienteEndereco.Endereco.Logradouro);

                    campos.Add(nomeCampoBairro);
                    valores.Add(cliente.ClienteEndereco.Endereco.Bairro);

                    campos.Add(nomeCampoCEP);
                    valores.Add(cliente.ClienteEndereco.Endereco.CEP);

                    dao.InsereLinha(nomeTabelaEndereco, campos, valores);
                }

                campos = new List<string>();
                valores = new List<string>();

                campos.Add(nomeCampoNome);
                valores.Add(cliente.Nome);

                campos.Add(nomeCampoCPF);
                valores.Add(cliente.CPF);

                campos.Add(nomeCampoCel);
                valores.Add(cliente.Telefone);

                campos.Add(nomeCampoDataCadastro);
                campos.Add(DateTime.Now.ToShortDateString());
                
                dao.InsereLinha(nomeTabelaCliente, campos, valores);

                campos = new List<string>();
                valores = new List<string>();

                campos.Add(nomeCampoNumero);
                valores.Add(cliente.ClienteEndereco.Numero);

                campos.Add(nomeCampoComplemento);
                valores.Add(cliente.ClienteEndereco.Complemento);

                campos.Add(nomeCampoEnderecoCod);
                valores.Add(cliente.ClienteEndereco.Endereco.Id.ToString());

                campos.Add(nomeCampoClienteCod);
                valores.Add(cliente.Id.ToString());

                dao.InsereLinha(nomeTabelaClienteEndereco, campos, valores);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Excluir(int clienteId)
        {
            try
            {
                //TODO
                //chamar método excluir no banco 
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Cliente RetornaCliente(int ClienteId)
        {
            return new Cliente
            {
                CPF = "39339353855"
                ,
                DataCadastro = DateTime.Now
                ,
                Id = 1
                ,
                Nome = "Ana Cecília"
                ,
                Telefone = "(14) 99803-9924"
                ,
                Medidas = medidaServico.PesquisaPorCliente(1)
                ,
                ClienteEndereco = new ClienteEndereco { }
            };
        }

        public List<Cliente> PesquisaClientes(string nome, string cpf, string telefone)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(RetornaCliente(1));
            return clientes;
        }
    }
}
