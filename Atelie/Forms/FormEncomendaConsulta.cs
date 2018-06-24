using Atelie.Entidades;
using Atelie.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelie.Forms
{
    public partial class FormEncomendaConsulta : Form
    {
        private const int indexColunaEditar = 0;
        private const int indexColunaEncomendaId = 4;
        private const int indexColunaClienteId = 5;

        public FormEncomenda formEncomenda { get; set; } = new FormEncomenda();

        public List<EncomendaClienteModelo> Encomendas { get; set; } = new List<EncomendaClienteModelo>();

        public FormEncomendaConsulta()
        {
            InitializeComponent();
        }

        private void dgvEncomenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int EncomendaId = Convert.ToInt32(dgvEncomenda.Rows[e.RowIndex].Cells[indexColunaEncomendaId].Value);
            int ClienteId = Convert.ToInt32(dgvEncomenda.Rows[e.RowIndex].Cells[indexColunaClienteId].Value);
            
            if (e.ColumnIndex == indexColunaEditar)
            {
                formEncomenda = new FormEncomenda(EncomendaId, ClienteId);
                formEncomenda.ShowDialog();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //TODO
            Encomendas.Add(new EncomendaClienteModelo { NomeCliente = "Marcia", DataEntrega = DateTime.Now, Descricao = "xxxxxx" });
            AtualizarGridEncomendas();
        }

        private void AtualizarGridEncomendas()
        {
            dgvEncomenda.DataSource = (from e in Encomendas select new { NomeCliente = e.NomeCliente, DataEntrega = e.DataEntrega, Descricao = e.Descricao, EncomendaId = e.EncomendaId, ClienteId = e.ClienteId}).ToList();

            if (Encomendas.Any())
            {
                dgvEncomenda.Columns["NomeCliente"].DisplayIndex = 0;
                dgvEncomenda.Columns["DataEntregaPrev"].DisplayIndex = 1;
                dgvEncomenda.Columns["Descricao"].DisplayIndex = 2;
                dgvEncomenda.Columns["Editar"].DisplayIndex = 3;
            }
        }
    }
}
