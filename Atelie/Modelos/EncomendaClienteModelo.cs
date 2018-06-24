using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Modelos
{
    public class EncomendaClienteModelo
    {
        public int ClienteId { get; set; }
        public int EncomendaId { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Descricao { get; set; }
    }
}
