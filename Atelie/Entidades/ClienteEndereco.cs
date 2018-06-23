using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    class ClienteEndereco
    {
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int EnderecoId { get; set; }
        public int ClienteId { get; set; }
    }
}
