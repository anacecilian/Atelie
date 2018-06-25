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
        private readonly ClienteEnderecoServico clienteEnderecoServico;
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
            clienteEnderecoServico = new ClienteEnderecoServico();
            dao = new DAO();
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
                dao.ApagaLinha(nomeTabelaCliente, nomeCampoIdCliente + " = " + clienteId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Cliente RetornaCliente(int ClienteId)
        {
            var result = dao.Select(nomeTabelaCliente, nomeCampoIdCliente + " = " + ClienteId);

            if (result != null && result.Count > 0)
                return LinhaParaEntidade(result.First());
            else
                return new Cliente();
        }

        public List<Cliente> PesquisaClientes(string nome, string cpf, string telefone)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<string> filtros = new List<string>();

            filtros.Add(!String.IsNullOrEmpty(nome) ? nomeCampoNome + " = " + nome : string.Empty);
            filtros.Add(!String.IsNullOrEmpty(cpf) ? nomeCampoCPF + " = " + cpf : string.Empty);
            filtros.Add(!String.IsNullOrEmpty(telefone) ? nomeCampoCel + " = " + telefone : string.Empty);

            string filtro = string.Join(" AND ", filtros.ToArray());

            var result = dao.Select(nomeTabelaCliente, filtro);

            if (result != null)
            {
                foreach (Dictionary<string, string> entity in result)
                {
                    clientes.Add(LinhaParaEntidade(entity));
                }
            }

            return clientes;
        }

        private Cliente LinhaParaEntidade(Dictionary<string, string> entity)
        {
            Cliente retorno = new Cliente();
            foreach (KeyValuePair<string, string> atributo in entity)
            {
                switch (atributo.Key)
                {
                    case nomeCampoNome:
                        retorno.Nome = atributo.Value;
                        break;
                    case nomeCampoCPF:
                        retorno.CPF = atributo.Value;
                        break;
                    case nomeCampoDataCadastro:
                        retorno.DataCadastro = DateTime.Parse(atributo.Value);
                        break;
                    case nomeCampoIdCliente:
                        retorno.Id = Convert.ToInt32(atributo.Value);
                        break;
                    case nomeCampoCel:
                        retorno.Telefone = atributo.Value;
                        break;
                }
            }

            retorno.Medidas = medidaServico.PesquisaPorCliente(retorno.Id);
            retorno.ClienteEndereco = clienteEnderecoServico.PesquisaPorCliente(retorno.Id);
            
            return retorno;
        }
    }
}
