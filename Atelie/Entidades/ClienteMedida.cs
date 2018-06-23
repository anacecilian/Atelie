using Atelie.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    class ClienteMedida
    {
        public int Id { get; set; }
        public TipoMedidaCliente Tipo { get; set; }
        public decimal Valor { get; set; }
    }
}
