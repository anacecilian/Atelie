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
        public bool SalvarCliente(Cliente cliente)
        {
            try
            {
                //chamar método salvar no banco 
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
