using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public Endereco Endereco { get; set; }
        public List<ClienteMedida> Medidas { get; set; }
    }
}
