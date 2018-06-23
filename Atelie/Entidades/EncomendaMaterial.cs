using Atelie.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    class EncomendaMaterial
    {
        public int Id { get; set; }
        public int IdEncomenda { get; set; }
        public TipoItemEncomenda Tipo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
