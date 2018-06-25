using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            Medidas = new List<ClienteMedida>();
            ClienteEndereco = new ClienteEndereco();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public ClienteEndereco ClienteEndereco { get; set; }
        public List<ClienteMedida> Medidas { get; set; }

        public override string ToString()
        {
            string cadastrocliente = "nome=" + Nome + "',CPF='" + CPF + "',cel_num='" + Telefone + "'";
            return cadastrocliente;
        }
    }
}
