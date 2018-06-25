using Atelie.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Servico
{
    public class ClienteServico
    {
        private readonly MedidaServico medidaServico;

        public ClienteServico()
        {
            medidaServico = new MedidaServico();
        }

        public bool SalvarCliente(Cliente cliente)
        {
            try
            {
                //TODO
                //chamar método salvar no banco 
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
                , DataCadastro = DateTime.Now
                , Id = 1
                , Nome = "Ana Cecília"
                , Telefone = "(14) 99803-9924"
                , Medidas = medidaServico.PesquisaPorCliente(1)
                , ClienteEndereco = new ClienteEndereco { }                
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
