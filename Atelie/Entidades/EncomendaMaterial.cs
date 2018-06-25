using Atelie.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    public class EncomendaMaterial
    {
        public int Id { get; set; }
        public int EncomendaId { get; set; }
        public string UnidadeMedida { get; set; }
        public string Detalhes { get; set; }
        public decimal Quantidade { get; set; }
    }
}
