using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    class EncomendaProva
    {
        public int Id { get; set; }
        public int EncomendaId { get; set; }
        public string Anotacao { get; set; }
        public DateTime Data { get; set; }
    }
}
