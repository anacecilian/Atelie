using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelie.Entidades
{
    public class Encomenda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataEntregaPrevista { get; set; }
        public DateTime DataEntregaEfetiva { get; set; }
        public List<EncomendaMaterial> Materiais { get; set; }
        public List<EncomendaProva> Provas { get; set; }
    }
}
